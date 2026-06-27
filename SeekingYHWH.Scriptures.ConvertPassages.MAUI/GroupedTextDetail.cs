using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

internal sealed class GroupedTextDetail : ObservableCollection<TextDetail>
{
	public string? Title { get; set; }
}
