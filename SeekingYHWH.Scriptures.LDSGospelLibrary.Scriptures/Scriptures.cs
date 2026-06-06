using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.LDSGospelLibrary
{
	public static class Scriptures
	{
		#region Fields
		private static readonly HashSet<string> excludes = new HashSet<string>()
		{
			"/scriptures/ot/title-page",
			"/scriptures/ot/introduction",
			"/scriptures/ot/dedication",
			"/scriptures/ot/explanation",
			"/scriptures/ot/illustrations",
			"/scriptures/ot/pronunciation",
			"/scriptures/ot/reference",
			"/scriptures/ot/chron-order",
			"/scriptures/ot/esth/1",
			"/scriptures/ot/esth/2",
			"/scriptures/ot/esth/3",
			"/scriptures/ot/esth/4",
			"/scriptures/ot/esth/5",
			"/scriptures/ot/esth/6",
			"/scriptures/ot/esth/7",
			"/scriptures/ot/esth/8",
			"/scriptures/ot/esth/9",
			"/scriptures/ot/esth/10",
			"/scriptures/ot/song/1",
			"/scriptures/ot/song/2",
			"/scriptures/ot/song/3",
			"/scriptures/ot/song/4",
			"/scriptures/ot/song/5",
			"/scriptures/ot/song/6",
			"/scriptures/ot/song/7",
			"/scriptures/ot/song/8",
			"/scriptures/nt/title-page",
			"/scriptures/nt/introduction",
			"/scriptures/nt/dedication",
			"/scriptures/nt/explanation",
			"/scriptures/nt/illustrations",
			"/scriptures/nt/pronunciation",
			"/scriptures/nt/reference",
			"/scriptures/nt/chron-order",
			"/scriptures/bofm/title-page",
			"/scriptures/bofm/introduction",
			"/scriptures/bofm/dedication",
			"/scriptures/bofm/explanation",
			"/scriptures/bofm/illustrations",
			"/scriptures/bofm/pronunciation",
			"/scriptures/bofm/reference",
			"/scriptures/bofm/chron-order",
			"/scriptures/dc-testament/title-page",
			"/scriptures/dc-testament/introduction",
			"/scriptures/dc-testament/dedication",
			"/scriptures/dc-testament/explanation",
			"/scriptures/dc-testament/illustrations",
			"/scriptures/dc-testament/pronunciation",
			"/scriptures/dc-testament/reference",
			"/scriptures/dc-testament/chron-order",
			"/scriptures/dc-testament/dc/77",
			"/scriptures/dc-testament/dc/102",
			"/scriptures/dc-testament/dc/108",
			"/scriptures/dc-testament/dc/109",
			"/scriptures/dc-testament/dc/110",
			"/scriptures/dc-testament/dc/111",
			"/scriptures/dc-testament/dc/113",
			"/scriptures/dc-testament/dc/114",
			"/scriptures/dc-testament/dc/115",
			"/scriptures/dc-testament/dc/118",
			"/scriptures/dc-testament/dc/123",
			"/scriptures/dc-testament/dc/124",
			"/scriptures/dc-testament/dc/126",
			"/scriptures/dc-testament/dc/127",
			"/scriptures/dc-testament/dc/128",
			"/scriptures/dc-testament/dc/129",
			"/scriptures/dc-testament/dc/130",
			"/scriptures/dc-testament/dc/131",
			"/scriptures/dc-testament/dc/132",
			"/scriptures/dc-testament/dc/135",
			"/scriptures/dc-testament/dc/136",
			"/scriptures/dc-testament/dc/137",
			"/scriptures/dc-testament/dc/138",
			"/scriptures/dc-testament/od/1",
			"/scriptures/dc-testament/od/2",
			"/scriptures/pgp/title-page",
			"/scriptures/pgp/introduction",
			"/scriptures/pgp/dedication",
			"/scriptures/pgp/explanation",
			"/scriptures/pgp/illustrations",
			"/scriptures/pgp/pronunciation",
			"/scriptures/pgp/reference",
			"/scriptures/pgp/chron-order",
			"/scriptures/pgp/abr/fac-1",
			"/scriptures/pgp/abr/fac-2",
			"/scriptures/pgp/abr/fac-3",
			//"/scriptures/pgp/js-h/1",
			"/scriptures/jst/title-page",
			"/scriptures/jst/introduction",
			"/scriptures/jst/dedication",
			"/scriptures/jst/explanation",
			"/scriptures/jst/illustrations",
			"/scriptures/jst/pronunciation",
			"/scriptures/jst/reference",
			"/scriptures/jst/chron-order",
		};
		#endregion //Fields

		#region Methods
		public static bool IsScripture(string uri)
		{
			if (!uri.StartsWith("/scriptures/"))
			{
				return false;
			}

			if (excludes.Contains(uri))
			{
				return false;
			}

			return true;
		}
		#endregion //Methods
	}
}
