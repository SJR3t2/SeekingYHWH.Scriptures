using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class BookInfoConverter
{
	private static readonly byte[] idProperty = Encoding.UTF8.GetBytes("id");
	private static readonly byte[] nameProperty = Encoding.UTF8.GetBytes("name");
	private static readonly byte[] urlProperty = Encoding.UTF8.GetBytes("url");

	public static void Parse(BookInfo value, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
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
			if (reader.ValueTextEquals(idProperty))
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				value.Id = reader.GetString();
			}
			else if (reader.ValueTextEquals(nameProperty))
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				value.Name = reader.GetString();
			}
			else if (reader.ValueTextEquals(urlProperty))
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
