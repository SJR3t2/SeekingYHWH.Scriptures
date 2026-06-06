using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeekingYHWH.Scriptures
{
	[RunInstaller(true)]
	public partial class Installer : System.Configuration.Install.Installer
	{
		public Installer()
		{
			InitializeComponent();
		}

		public override void Uninstall(IDictionary savedState)
		{
			base.Uninstall(savedState);

			DeleteDirectorys(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
			DeleteDirectorys(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		}

		private void DeleteDirectorys(string path)
		{
			var delete = Path.Combine(path, "SeekingYHWH", "ScripturesConvertPassages");
			try
			{
				Directory.Delete(delete, true);
			}
			catch
			{
				//Nothing on purpose
			}
			delete = Path.Combine(path, "SeekingYHWH");
			var values = Directory.GetFileSystemEntries(delete);
			if (values == null || values.Length <= 0)
			{
				try
				{
					Directory.Delete(delete, true);
				}
				catch
				{
					//Nothing on purpose
				}
			}
		}
	}
}
