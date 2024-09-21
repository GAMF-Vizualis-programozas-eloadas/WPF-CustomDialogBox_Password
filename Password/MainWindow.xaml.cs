using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace CustomBialogBox_Password
{
	public partial class MainWindow : Window
	{
		// secret
		string StoredHashedPassword = "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=";
		public MainWindow()
		{
			InitializeComponent();
			var wnd = new wndPassword();
			var res = wnd.ShowDialog();
			if (res == true)
			{
				var InputHashedPassword = HashPassword(wnd.Password);
				if (wnd.UserName == "user" && InputHashedPassword == StoredHashedPassword)
				{
					// Do something if the correct username and password were entered.
					MessageBox.Show("You entered the correct username and password pair!");
				}
				else
					MessageBox.Show("Wrong username or passord!");
			}
		}

		string HashPassword(string password)
		{
			using (var sha256 = SHA256.Create())
			{
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(hashBytes);
			}
		}
	}
}