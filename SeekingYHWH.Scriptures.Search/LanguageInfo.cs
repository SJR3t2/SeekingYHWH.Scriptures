using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SeekingYHWH.Scriptures;

[DebuggerDisplay("{Code} {Name}")]
public class LanguageInfo
{
	public string Code { get; set; }
	public string Name { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
