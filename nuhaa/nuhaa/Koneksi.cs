using System;
using MySql.Data.MySqlClient;

namespace nuhaa
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	public class Koneksi
	{
		string alamat ="server=localhost; database=nuhaashop; uid=root ;pwd=";
		public MySqlConnection koneksi;
		
		public void buka()
		 {
		 	koneksi = new MySqlConnection(alamat);
		 	koneksi.Open();
		 }
		 public void tutup()
		 {
		 	koneksi = new MySqlConnection(alamat);
		 	koneksi.Close();
		 }
	}
}
