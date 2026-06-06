using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary
{
	internal static class LanguageInfosConverter
	{
		#region Methods
		public static void Parse(Stream streamStream, byte[] buffer, Action<LanguageInfo> action)
		{
			using (var stream = new UTF8JSONReaderStream(streamStream, buffer))
			{
				var reader = stream.Create();
				Parse(stream, ref reader, action);
			}
		}

		public static void Parse(UTF8JSONReaderStream stream, ref Utf8JsonReader reader, Action<LanguageInfo> action)
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
				var value = LanguageInfoConverter.ParseStarted(stream, ref reader);
				action(value);
			}
		}
		#endregion //Methods
	}
}
