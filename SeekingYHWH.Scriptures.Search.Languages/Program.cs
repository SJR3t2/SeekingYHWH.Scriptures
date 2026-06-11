namespace SeekingYHWH.Scriptures.Search;

internal static class Program
{
	private static int Main(string[] args)
	{
		return Execute();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";

	private static int Execute()
	{
		var brPath = LanguageInfosPaths.GetPathBr(scripturesPath);
		var tsvPath = LanguageInfosPaths.GetPath(scripturesPath);
		Compression.Decompress(brPath, tsvPath);
		Console.WriteLine("delete");
		Console.WriteLine("keep");
		Console.WriteLine("use");
		Console.WriteLine();
		while (true)
		{
			Console.Write("Command: ");
			var input = Console.ReadLine();
			switch (input)
			{
			case "delete":
				File.Delete(tsvPath);
				goto Done;

			case "keep":
				goto Done;

			case "use":
				Compression.Compress(tsvPath, brPath);
				File.Delete(tsvPath);
				var hashPath = LanguageInfosPaths.GetHashPath(scripturesPath);
				Hash.ComputeBR(brPath, hashPath);
				goto Done;
			}
		}
	Done:
		return 0;
	}
}