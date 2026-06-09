namespace SeekingYHWH.Scriptures;

public static class Languages
{
	private static string mastersBRPath;
	private static string mastersHSHPath;
	private static string localsPath;

	private static readonly List<LanguageInfo> masters = new List<LanguageInfo>();
	private static readonly Dictionary<string, int> mastersOffsets = new Dictionary<string, int>();
	private static readonly List<LanguageInfo> locals = new List<LanguageInfo>();
	private static readonly HashSet<string> localsSet = new HashSet<string>();
	private static readonly Comparison<LanguageInfo> localsComparison = LocalsComparison;
	
	public static List<LanguageInfo> Masters => masters;
	public static List<LanguageInfo> Locals => locals;

	public static void Prepare(string path)
	{
		mastersBRPath = LanguageInfosPaths.GetPathBr(path);
		mastersHSHPath = LanguageInfosPaths.GetHashPath(path);
		localsPath = LanguageInfosPaths.GetPath(path);

		if (!File.Exists(mastersBRPath))
		{
			Delete();
			return;
		}

		MastersRead();
		if (File.Exists(localsPath))
		{
			LocalsRead();
		}
	}

	public static bool MastersTryIndexOf(LanguageInfo value, out int offset)
	{
		var code = value.Code;
		for (var i = 0; i < masters.Count; ++i)
		{
			var master = masters[i];
			if (code == master.Code)
			{
				offset = i;
				return true;
			}
		}
		offset = default;
		return false;
	}

	public static void LocalsAdd(LanguageInfo language)
	{
		var languageCode = language.Code;

		if (localsSet.Contains(languageCode))
		{
			return;
		}

		locals.Add(language);
		localsSet.Add(languageCode);
		locals.Sort(localsComparison);

		using (var writer = LanguageInfosWriter.OpenTSV(localsPath))
		{
			writer.Write(locals);
		}
	}

	public static void LocalsRemove(LanguageInfo language)
	{
		var languageCode = language.Code;
		if (!localsSet.Remove(languageCode))
		{
			return;
		}

		for (var i = locals.Count - 1; i >= 0; --i)
		{
			var value = locals[i];
			if (language.Code == value.Code)
			{
				locals.RemoveAt(i);
			}
		}

		if (locals.Count > 0)
		{
			using (var writer = LanguageInfosWriter.OpenTSV(localsPath))
			{
				writer.Write(locals);
			}
		}
		else
		{
			File.Delete(localsPath);
		}
	}

	public static bool LocalsContains(string languageCode)
	{
		foreach (var value in locals)
		{
			if (languageCode == value.Code)
			{
				return true;
			}
		}
		return false;
	}

	public static void Download()
	{
		byte[] hsh;
		using (var client = new HttpClient())
		{
			hsh = client.GetByteArrayAsync(URLs.GetLanguagesHSH()).Result;

			if (File.Exists(mastersHSHPath))
			{
				var old = File.ReadAllBytes(mastersHSHPath);
				if (HashConverter.Equals(hsh, old))
				{
					return;
				}
			}

			using (var response = client.GetAsync(URLs.GetLanguagesBR()).Result)
			{
				if (!response.IsSuccessStatusCode)
				{
					return;
				}

				using (var writer = new FileStream(mastersBRPath, FileMode.Create, FileAccess.Write, FileShare.Read))
				{
					response.Content.CopyTo(writer, null, CancellationToken.None);
				}
			}
		}

		File.WriteAllBytes(mastersHSHPath, hsh);

		var removes = new string[masters.Count];
		for (var i = removes.Length - 1; i >= 0; --i)
		{
			removes[i] = masters[i].Code;
		}

		MastersRead();

		var set = new HashSet<string>();
		foreach (var value in masters)
		{
			set.Add(value.Code);
		}
		var removed = false;
		foreach (var value in removes)
		{
			if (set.Contains(value))
			{
				continue;
			}

			Directory.Delete(Path.Combine(Stores.Path, value), recursive: true);
			if (!localsSet.Remove(value))
			{
				continue;
			}
			removed = true;
			for (var i = locals.Count - 1; i >= 0; --i)
			{
				var local = locals[i];
				if (value == local.Code)
				{
					locals.RemoveAt(i);
				}
			}
		}
		if (removed)
		{
			using (var writer = LanguageInfosWriter.OpenTSV(localsPath))
			{
				writer.Write(locals);
			}
		}
	}

	private static void Delete()
	{
		File.Delete(mastersHSHPath);
		foreach (var directory in Directory.GetDirectories(Stores.Path))
		{
			Directory.Delete(directory, recursive: true);
		}
		File.Delete(localsPath);
	}

	private static void MastersRead()
	{
		masters.Clear();
		mastersOffsets.Clear();

		using (var reader = LanguageInfosReader.OpenBR(mastersBRPath))
		{
			while (reader.TryRead(out var value))
			{
				mastersOffsets.Add(value.Code, masters.Count);
				masters.Add(value);
			}
		}

		foreach (var directory in Directory.GetDirectories(Stores.Path))
		{
			var name = Path.GetFileName(directory);
			if (mastersOffsets.ContainsKey(name))
			{
				continue;
			}
			Directory.Delete(directory, recursive: true);
		}
	}

	private static void LocalsRead()
	{
		var removed = false;
		using (var reader = LanguageInfosReader.OpenTSV(localsPath))
		{
			while (reader.TryRead(out var value))
			{
				if (!mastersOffsets.TryGetValue(value.Code, out var valueOffset))
				{
					removed = true;
					continue;
				}

				value = masters[valueOffset];
				locals.Add(value);
				localsSet.Add(value.Code);
			}
		}
		if (removed)
		{
			if (locals.Count > 0)
			{
				using (var writer = LanguageInfosWriter.OpenTSV(localsPath))
				{
					writer.Write(locals);
				}
			}
			else
			{
				File.Delete(localsPath);
			}
		}
	}

	private static int LocalsComparison(LanguageInfo x, LanguageInfo y)
	{
		var xFound = mastersOffsets.TryGetValue(x.Code, out var xOffset);
		var yFound = mastersOffsets.TryGetValue(y.Code, out var yOffset);

		if (!xFound && !yFound)
		{
			return StringComparer.Ordinal.Compare(x.Code, y.Code);
		}
		if (xFound && !yFound)
		{
			return +1;
		}
		if (!xFound && yFound)
		{
			return -1;
		}
		if (xOffset == yOffset)
		{
			return 0;
		}
		if (xOffset > yOffset)
		{
			return +1;
		}
		else
		{
			return -1;
		}
	}
}
