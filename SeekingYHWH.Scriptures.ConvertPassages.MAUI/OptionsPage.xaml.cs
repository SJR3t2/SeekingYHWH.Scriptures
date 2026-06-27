namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class OptionsPage : ContentPage
{
	private string optionsPath;
	private Options options;

	public OptionsPage(string optionsPath, Options options)
	{
		InitializeComponent();

		this.optionsPath = optionsPath;
		this.options = options;
		this.BindingContext = options;
	}

	private void OnLDSBoMS(object sender, EventArgs args)
	{
		if (ldsBoMGrid == null)
		{
			return;
		}

		ldsBoMCenterLabel.IsEnabled = true;
		ldsBoMCenter.IsEnabled = true;

		ldsBoMPre.Text = "(LDS ";
		ldsBoMCenter.Text = ")(RLDS ";
		ldsBoMPost.Text = ")";
	}

	private void OnLDSBoMO(object sender, EventArgs args)
	{
		if (ldsBoMGrid == null)
		{
			return;
		}

		ldsBoMCenterLabel.IsEnabled = true;
		ldsBoMCenter.IsEnabled = true;

		ldsBoMPre.Text = "(RLDS ";
		ldsBoMCenter.Text = ")(LDS ";
		ldsBoMPost.Text = ")";
	}

	private void OnLDSBoMN(object sender, EventArgs args)
	{
		if (ldsBoMGrid == null)
		{
			return;
		}

		ldsBoMCenterLabel.IsEnabled = false;
		ldsBoMCenter.IsEnabled = false;

		ldsBoMPre.Text = string.Empty;
		ldsBoMCenter.Text = null;
		ldsBoMPost.Text = string.Empty;
	}

	private void OnRLDSBoMS(object sender, EventArgs args)
	{
		if (rldsBoMGrid == null)
		{
			return;
		}

		rldsBoMCenterLabel.IsEnabled = true;
		rldsBoMCenter.IsEnabled = true;

		rldsBoMPre.Text = "(RLDS ";
		rldsBoMCenter.Text = ")(LDS ";
		rldsBoMPost.Text = ")";
	}

	private void OnRLDSBoMO(object sender, EventArgs args)
	{
		if (rldsBoMGrid == null)
		{
			return;
		}

		rldsBoMCenterLabel.IsEnabled = true;
		rldsBoMCenter.IsEnabled = true;

		rldsBoMPre.Text = "(LDS ";
		rldsBoMCenter.Text = ")(RLDS ";
		rldsBoMPost.Text = ")";
	}

	private void OnRLDSBoMN(object sender, EventArgs args)
	{
		if (rldsBoMGrid == null)
		{
			return;
		}

		rldsBoMCenterLabel.IsEnabled = false;
		rldsBoMCenter.IsEnabled = false;

		rldsBoMPre.Text = string.Empty;
		rldsBoMCenter.Text = null;
		rldsBoMPost.Text = string.Empty;
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		if (options.Changed)
		{
			options.Write(optionsPath);
			options.ClearChanged();
		}
	}
}