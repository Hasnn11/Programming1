/*
 * Created by SharpDevelop.
 * User: Hasnn
 * Date: 12/11/2022
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nuhaa
{
	partial class MenuUtama
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		public System.Windows.Forms.ToolStripMenuItem menuLogin;
		public System.Windows.Forms.ToolStripMenuItem menuLogout;
		public System.Windows.Forms.ToolStripMenuItem menuData;
		private System.Windows.Forms.ToolStripMenuItem dataBarang;
		private System.Windows.Forms.ToolStripMenuItem dataPenjualan;
		public System.Windows.Forms.ToolStripMenuItem menuTransaksi;
		private System.Windows.Forms.ToolStripMenuItem menuPenjualan;
		public System.Windows.Forms.ToolStripMenuItem menuSetting;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuData = new System.Windows.Forms.ToolStripMenuItem();
			this.dataBarang = new System.Windows.Forms.ToolStripMenuItem();
			this.dataPenjualan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPenjualan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuFile,
			this.menuData,
			this.menuTransaksi,
			this.menuSetting});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(876, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuLogin,
			this.menuLogout});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// menuLogin
			// 
			this.menuLogin.Name = "menuLogin";
			this.menuLogin.Size = new System.Drawing.Size(112, 22);
			this.menuLogin.Text = "Login";
			this.menuLogin.Click += new System.EventHandler(this.MenuLoginClick);
			// 
			// menuLogout
			// 
			this.menuLogout.Name = "menuLogout";
			this.menuLogout.Size = new System.Drawing.Size(112, 22);
			this.menuLogout.Text = "Logout";
			this.menuLogout.Click += new System.EventHandler(this.MenuLogoutClick);
			// 
			// menuData
			// 
			this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.dataBarang,
			this.dataPenjualan});
			this.menuData.Name = "menuData";
			this.menuData.Size = new System.Drawing.Size(43, 20);
			this.menuData.Text = "Data";
			// 
			// dataBarang
			// 
			this.dataBarang.Name = "dataBarang";
			this.dataBarang.Size = new System.Drawing.Size(153, 22);
			this.dataBarang.Text = "Data Barang";
			this.dataBarang.Click += new System.EventHandler(this.DataBarangClick);
			// 
			// dataPenjualan
			// 
			this.dataPenjualan.Name = "dataPenjualan";
			this.dataPenjualan.Size = new System.Drawing.Size(153, 22);
			this.dataPenjualan.Text = "Data Penjualan";
			this.dataPenjualan.Click += new System.EventHandler(this.DataPenjualanClick);
			// 
			// menuTransaksi
			// 
			this.menuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuPenjualan});
			this.menuTransaksi.Name = "menuTransaksi";
			this.menuTransaksi.Size = new System.Drawing.Size(66, 20);
			this.menuTransaksi.Text = "Transaksi";
			// 
			// menuPenjualan
			// 
			this.menuPenjualan.Name = "menuPenjualan";
			this.menuPenjualan.Size = new System.Drawing.Size(126, 22);
			this.menuPenjualan.Text = "Penjualan";
			this.menuPenjualan.Click += new System.EventHandler(this.MenuPenjualanClick);
			// 
			// menuSetting
			// 
			this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuAbout,
			this.toolStripMenuItem1,
			this.exitToolStripMenuItem1});
			this.menuSetting.Name = "menuSetting";
			this.menuSetting.Size = new System.Drawing.Size(56, 20);
			this.menuSetting.Text = "Setting";
			// 
			// menuAbout
			// 
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(107, 22);
			this.menuAbout.Text = "About";
			this.menuAbout.Click += new System.EventHandler(this.MenuAboutClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1380, 720);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MenuUtama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(876, 567);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MenuUtama";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NuhaBeautyShop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MenuUtamaLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
