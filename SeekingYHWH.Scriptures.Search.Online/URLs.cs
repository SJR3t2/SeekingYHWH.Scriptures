using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
    public static class URLs
    {
		private const string URL = "https://seekingyhwh.github.io/SeekingYHWH.Scriptures.Search/";
		private const string languagesBRURL = URL + LanguageInfosPaths.BR;
		private const string languagesHSHURL = URL + LanguageInfosPaths.HSH;
		private const string separator = "/";

		public static string GetLanguagesBR()
		{
			return languagesBRURL;
		}

		public static string GetLanguagesHSH()
		{
			return languagesHSHURL;
		}

		public static string GetBooksBR(LanguageInfo language)
		{
			var url = string.Concat(URL, language.Code, separator, BookInfosPaths.BR);
			return url;
		}

		public static string GetBooksHSH(LanguageInfo language)
		{
			var url = string.Concat(URL, language.Code, separator, BookInfosPaths.HSH);
			return url;
		}

		public static string GetBook(LanguageInfo language, string name)
		{
			var url = string.Concat(URL, language.Code, separator, name);
			return url;
		}
	}
}
