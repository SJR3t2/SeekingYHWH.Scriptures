using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class VerseInfoConverter
{
	private static readonly byte[] verseProperty = Encoding.UTF8.GetBytes("verse");
	private static readonly byte[] textProperty = Encoding.UTF8.GetBytes("text");

	public static void Parse(VerseInfo value, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
	{
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
			if (reader.ValueTextEquals(verseProperty))
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				value.Verse = reader.GetString();
			}
			else if (reader.ValueTextEquals(textProperty))
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				value.Text = reader.GetString();
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
