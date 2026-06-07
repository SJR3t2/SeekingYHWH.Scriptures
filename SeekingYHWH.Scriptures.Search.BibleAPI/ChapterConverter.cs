using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class ChapterConverter
{
	private static readonly byte[] versesProperty = Encoding.UTF8.GetBytes("verses");

	public static void Parse(List<VerseInfo> values, Stream streamStream, byte[] buffer)
	{
		using (var stream = new UTF8JSONReaderStream(streamStream, buffer))
		{
			var reader = stream.Create();
			Parse(values, stream, ref reader);
		}
	}

	public static void Parse(List<VerseInfo> values, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
	{
		if (!stream.Read(ref reader))
		{
			throw new EndOfStreamException();
		}
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new FormatException();
		}
		while (true)
		{
			if (!stream.Read(ref reader))
			{
				throw new EndOfStreamException();
			}
			if (reader.TokenType == JsonTokenType.EndObject)
			{
				return;
			}
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new FormatException();
			}
			if (reader.ValueTextEquals(versesProperty))
			{
				ParseVerses(values, stream, ref reader);
			}
			else
			{
				if (!stream.TrySkip(ref reader))
				{
					throw new EndOfStreamException();
				}
			}
		}
	}
	public static void ParseVerses(List<VerseInfo> values, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
	{
		if (!stream.Read(ref reader))
		{
			throw new EndOfStreamException();
		}
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			throw new FormatException();
		}
		while (true)
		{
			if (!stream.Read(ref reader))
			{
				throw new EndOfStreamException();
			}
			if (reader.TokenType == JsonTokenType.EndArray)
			{
				return;

			}
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new FormatException();
			}
			var value = new VerseInfo();
			VerseInfoConverter.Parse(value, stream, ref reader);
			values.Add(value);
		}
	}
}
