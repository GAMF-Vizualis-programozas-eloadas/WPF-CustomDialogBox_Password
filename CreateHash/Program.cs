using System.Security.Cryptography;
using System.Text;


// Password to be stored (hashed)
string HashedPassword = HashPassword("1234");

Console.WriteLine("Stored Hashed Password: " + HashedPassword);


static string HashPassword(string password)
{
	using (var sha256 = SHA256.Create())
	{
		byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
		return Convert.ToBase64String(hashBytes);
	}
}
