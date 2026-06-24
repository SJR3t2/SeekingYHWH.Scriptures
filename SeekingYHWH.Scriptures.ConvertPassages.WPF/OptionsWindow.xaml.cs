using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SeekingYHWH.Scriptures
{
	/// <summary>
	/// Interaction logic for OptionsWindow.xaml
	/// </summary>
	public partial class OptionsWindow : Window
	{
		public OptionsWindow()
		{
			InitializeComponent();
		}

		private void OnLDSBoMS(object sender, RoutedEventArgs args)
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

		private void OnLDSBoMO(object sender, RoutedEventArgs args)
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

		private void OnLDSBoMN(object sender, RoutedEventArgs args)
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

		private void OnRLDSBoMS(object sender, RoutedEventArgs args)
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

		private void OnRLDSBoMO(object sender, RoutedEventArgs args)
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

		private void OnRLDSBoMN(object sender, RoutedEventArgs args)
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
	}
}
