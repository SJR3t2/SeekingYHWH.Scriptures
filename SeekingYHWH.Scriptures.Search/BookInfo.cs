using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public class BookInfo
{
	public string Code { get; set; }
	public string Name { get; set; }
	public string Pre { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
