using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class ChapterInfoConverter
{
	private static readonly byte[] urlVersion = Encoding.UTF8.GetBytes("url");

	public static void Parse(ChapterInfo value, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
	{
		while(true)
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
			if (reader.ValueTextEquals(urlVersion))
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				value.URL = reader.GetString();
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
}
