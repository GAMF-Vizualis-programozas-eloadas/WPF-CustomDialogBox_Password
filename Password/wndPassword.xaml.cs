using System.Windows;

namespace CustomBialogBox_Password
{
	/// <summary>
	/// Interaction logic for wndPassword.xaml
	/// </summary>
	public partial class wndPassword : Window
	{
		public string UserName 
		{ get { return tbName.Text; } 
		}
		public string Password => pbPassword.Password;

		public wndPassword()
		{
			InitializeComponent();
		}

		private void btOK_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
		}
	}
}
