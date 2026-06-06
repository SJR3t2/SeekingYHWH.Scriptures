using System.ComponentModel;

namespace SeekingYHWH.Scriptures;

public sealed class DownloadBookModel : INotifyPropertyChanged
{
	private readonly BookInfo book;

	private bool downloaded;

	public DownloadBookModel(BookInfo book, bool downloaded)
	{
		this.book = book;
		this.downloaded = downloaded;
	}

	public BookInfo Book => book;

	public string Code => book.Code;

	public string Name => book.Name;

	public bool Downloaded => downloaded;

	public string Download => downloaded ? "Refresh" : "Download";

	public event PropertyChangedEventHandler? PropertyChanged;

	public void OnDownloaded()
	{
		downloaded = true;
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Downloaded)));
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Download)));
	}

	public void OnRemoved()
	{
		downloaded = false;
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Downloaded)));
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Download)));
	}
}
