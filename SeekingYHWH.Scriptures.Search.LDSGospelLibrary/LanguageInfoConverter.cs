using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary
{
	internal static class LanguageInfoConverter
	{
		#region Fields
		private static readonly byte[] propertyId = Encoding.UTF8.GetBytes("id");
		private static readonly byte[] propertyCode = Encoding.UTF8.GetBytes("iso639_3Code");
		private static readonly byte[] propertyName = Encoding.UTF8.GetBytes("nativeName");
		#endregion //Fields

		#region Methods
		public static LanguageInfo ParseStarted(UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
		{
			var value = new LanguageInfo();
			ParseStarted(value, stream, ref reader);
			return value;
		}

		public static void ParseStarted(LanguageInfo value, UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
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
				if (reader.ValueTextEquals(propertyId))
				{
					if (!stream.Read(ref reader))
					{
						throw new EndOfStreamException();
					}
					value.Id = reader.GetInt32();
				}
				else if (reader.ValueTextEquals(propertyCode))
				{
					if (!stream.Read(ref reader))
					{
						throw new EndOfStreamException();
					}
					value.Code = reader.GetString();
				}
				else if (reader.ValueTextEquals(propertyName))
				{
					if (!stream.Read(ref reader))
					{
						throw new EndOfStreamException();
					}
					value.Name = reader.GetString();
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
		#endregion //Methods
	}
}
