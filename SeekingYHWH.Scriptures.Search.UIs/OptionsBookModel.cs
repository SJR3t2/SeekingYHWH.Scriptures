using System.ComponentModel;

namespace SeekingYHWH.Scriptures;

public sealed class OptionsBookModel : INotifyPropertyChanged
{
	private readonly string code;
	private readonly string name;
	private readonly string pre;

	private readonly bool prePossible;

	private bool include;
	private bool includeChanged;
	private bool preUse;
	private bool preUseChanged;

	private readonly BookInfo book = new BookInfo();

	public OptionsBookModel(BookInfo book)
	{
		this.book.Code = this.code = book.Code;
		this.book.Name = this.name = book.Name;
		this.pre = book.Pre;

		this.prePossible = !string.IsNullOrWhiteSpace(this.pre);
	}

	public string Code => code;

	public string Name => name;

	public string Pre => pre;

	public bool PrePossible => prePossible;

	public bool Include
	{
		get => include;
		set
		{
			if (value == include)
			{
				return;
			}
			include = value;
			includeChanged = !includeChanged;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Include)));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IncludeChanged)));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Changed)));
		}
	}

	public bool IncludeChanged => includeChanged;
	
	public bool PreUse
	{
		get => preUse;
		set
		{
			if (value == preUse)
			{
				return;
			}
			preUse = value;
			if (value)
			{
				book.Pre = pre;
			}
			else
			{
				book.Pre = null;
			}
			preUseChanged = !preUseChanged;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PreUse)));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PreUseChanged)));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Changed)));
		}
	}

	public bool PreUseChanged => preUseChanged;

	public bool Changed => includeChanged || preUseChanged;

	public BookInfo Book => book;

	public event PropertyChangedEventHandler? PropertyChanged;

	public void ResetChanged()
	{
		includeChanged = false;
		preUseChanged = false;
	}
}
