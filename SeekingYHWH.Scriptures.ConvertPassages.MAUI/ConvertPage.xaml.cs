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

	private void OnConvert(object? sender, EventArgs args)
	{
		try
		{
			var value = passagesText.Text;
			convertedText.Text = converter.Convert(value);
		}
		catch (Exception exception)
		{
			convertedText.Text = string.Empty;

			DisplayAlert("Error", "Can't Convert", "OK");

			return;
		}
		switch (options.Convert)
		{
		case "N":
		case "n":
			break;

		case "A":
		case "a":
		default:
			try
			{
				Clipboard.SetTextAsync(convertedText.Text).Wait();
			}
			catch (Exception exception)
			{
				DisplayAlert("Error", "Can't Copy", "OK");
			}
			break;

		case "S":
		case "s":
			if (!converter.Error)
			{
				try
				{
					Clipboard.SetTextAsync(convertedText.Text).Wait();
				}
				catch (Exception exception)
				{
					DisplayAlert("Error", "Can't Copy", "OK");
				}
			}
			else
			{
			}
			break;
		}
	}

	private void OnCopy(object? sender, EventArgs args)
	{
		try
		{
			Clipboard.SetTextAsync(convertedText.Text).Wait();
		}
		catch (Exception exception)
		{
			DisplayAlert("Error", "Can't Copy", "OK");
		}
	}

	private void OnTextChanged(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}

	private void OnClear(object? sender, EventArgs args)
	{
		throw new NotImplementedException();
	}
}
