using System;
using System.Drawing;
using System.Windows.Forms;

namespace nuhaa
{
	/// <summary>
	/// Description of MenuUtama.
	/// </summary>
	public partial class MenuUtama : Form
	{
		public static MenuUtama menu;
		MenuStrip mnstrip;
		
		MainForm Login;
		public void Login_Closed(object sender, FormClosedEventArgs e)
		{
			Login = null;
		}
		
		DataBarang frmdtbarang;
		public void frmdtbarang_Closed(object sender, FormClosedEventArgs e)
		{
			frmdtbarang = null;
		}
		
		DataPenjualan frmdtpenjualan;
		public void frmdtpenjualan_Closed(object sender, FormClosedEventArgs e)
		{
			frmdtpenjualan = null;
		}
		
		Transaksi frmtransaksi;
		public void frmtransaksi_Closed(object sender, FormClosedEventArgs e)
		{
			frmtransaksi = null;
		}
		
		About mnabout;
		public void mnabout_Closed(object sender, FormClosedEventArgs e)
		{
			mnabout = null;
		}
			
		public void MenuTerkunci()
		{
			menuLogin.Enabled = true;
			menuLogout.Enabled = false;
			menuData.Enabled = false;
			menuTransaksi.Enabled = false;
			menuSetting.Enabled = true;
			menu = this;
		}
		
		public MenuUtama()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void MenuUtamaLoad(object sender, EventArgs e)
		{
			MenuTerkunci();
		}
		void MenuLoginClick(object sender, EventArgs e)
		{
			if (Login == null) 
			{
				Login = new MainForm();
				Login.FormClosed += new FormClosedEventHandler(Login_Closed);
				Login.ShowDialog();
			}
			else
			{
				Login.Activate();
			}
		}
		void MenuLogoutClick(object sender, EventArgs e)
		{
			MenuTerkunci();
			MessageBox.Show("Anda Telah Logout", "Information");
		}
		void DataBarangClick(object sender, EventArgs e)
		{
			if (frmdtbarang == null) 
			{
				frmdtbarang = new DataBarang();
				frmdtbarang.FormClosed += new FormClosedEventHandler(frmdtbarang_Closed);
				frmdtbarang.ShowDialog();
			}
			else
			{
				frmdtbarang.Activate();
			}
		}
		void DataPenjualanClick(object sender, EventArgs e)
		{
			if (frmdtpenjualan == null) 
			{
				frmdtpenjualan = new DataPenjualan();
				frmdtpenjualan.FormClosed += new FormClosedEventHandler(frmdtpenjualan_Closed);
				frmdtpenjualan.ShowDialog();
			}
			else
			{
				frmdtpenjualan.Activate();
			}
		}
		void MenuPenjualanClick(object sender, EventArgs e)
		{
			if (frmtransaksi == null) 
			{
				frmtransaksi = new Transaksi();
				frmtransaksi.FormClosed += new FormClosedEventHandler(frmtransaksi_Closed);
				frmtransaksi.ShowDialog();
			}
			else
			{
				frmtransaksi.Activate();
			}
		}
		void MenuAboutClick(object sender, EventArgs e)
		{
			if (mnabout == null) 
			{
				mnabout = new About();
				mnabout.FormClosed += new FormClosedEventHandler(mnabout_Closed);
				mnabout.ShowDialog();
			}
			else
			{
				mnabout.Activate();
			}
		}
	}
}
