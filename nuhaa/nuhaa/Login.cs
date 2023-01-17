using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nuhaa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlCommand query;
		Koneksi sambung;
		string sql;
		MySqlDataAdapter adapter;
		MySqlDataReader dr;
		DataSet ds;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sambung.buka();
			sql = "Select * from data_user where namaUser='"+textBox1.Text+"' and passUser='"+textBox2.Text+"' ";
			query = new MySqlCommand(sql,sambung.koneksi);
			dr = query.ExecuteReader();
			dr.Read();
			if (dr.HasRows) {
				MenuUtama.menu.menuLogin.Enabled = false;
				MenuUtama.menu.menuLogout.Enabled = true;
				MenuUtama.menu.menuData.Enabled = true;
				MenuUtama.menu.menuTransaksi.Enabled = true;
				this.Close();
				MessageBox.Show("Login Berhasil", "Information");
			}else{
				MessageBox.Show("Username dan Password Salah", "Information");
			}
		}
	}
}
