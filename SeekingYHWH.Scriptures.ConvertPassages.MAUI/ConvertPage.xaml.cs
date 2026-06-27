namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class ConvertPage : ContentPage
{
	private readonly Options options;
	private readonly PassagesConverter converter = new PassagesConverter();
	private readonly Dictionary<string, BookConverter> lds = PassagesConverter.CreateBooksEmpty();
	private readonly Dictionary<string, BookConverter> rlds = PassagesConverter.CreateBooksEmpty();

	public ConvertPage(Options options)
	{
		InitializeComponent();

		this.options = options;

		options.SetInitialize(converter, lds, rlds);

		switch (options.Direction)
		{
		case "L":
		case "l":
		default:
			OnLDSToRLDS(null, null);
			break;

		case "R":
		case "r":
			OnRLDSToLDS(null, null);
			break;
		}
	}

	private void OnLoaded(object? sender, EventArgs args)
	{
		passagesText.Focus();
	}

	private void OnLDSToRLDS(object sender, EventArgs args)
	{
		directionButton.Clicked -= OnLDSToRLDS;
		converter.Books = lds;
		fromLabel.Text = "LDS";
		toLabel.Text = "RLDS";
		directionButton.Clicked += OnRLDSToLDS;
	}

	private void OnRLDSToLDS(object sender, EventArgs args)
	{
		directionButton.Clicked -= OnRLDSToLDS;
		converter.Books = rlds;
		fromLabel.Text = "RLDS";
		toLabel.Text = "LDS";
		directionButton.Clicked += OnLDSToRLDS;
	}

	private void OnTextChanged(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}

	private void OnClear(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}

	private void OnCopy(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}

	private void OnConvert(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}
}
