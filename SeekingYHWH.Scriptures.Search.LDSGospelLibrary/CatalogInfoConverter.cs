using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using Innovoft.Text.JSON;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary
{
	internal static class CatalogInfoConverter
	{
		#region Fields
		private static readonly byte[] propertyVersion = Encoding.UTF8.GetBytes("catalogVersion");
		#endregion //Fields

		#region Methods
		public static CatalogInfo Parse(Stream streamStream, byte[] buffer)
		{
			using (var stream = new UTF8JSONReaderStream(streamStream, buffer))
			{
				var reader = stream.Create();
				return Parse(stream, ref reader);
			}
		}

		public static CatalogInfo Parse(UTF8JSONReaderStream stream, ref Utf8JsonReader reader)
		{
			if (!stream.Read(ref reader))
			{
				throw new EndOfStreamException();
			}
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new FormatException();
			}
			var value = new CatalogInfo();
			while (true)
			{
				if (!stream.Read(ref reader))
				{
					throw new EndOfStreamException();
				}
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					return value;
				}
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					throw new FormatException();
				}
				if (reader.ValueTextEquals(propertyVersion))
				{
					if (!stream.Read(ref reader))
					{
						throw new EndOfStreamException();
					}
					value.Version = reader.GetInt32();
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
