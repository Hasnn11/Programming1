/*
 * Created by SharpDevelop.
 * User: Hasnn
 * Date: 19/11/2022
 * Time: 19:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nuhaa
{
	partial class DataPenjualan
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
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
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(92, 158);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(245, 20);
			this.textBox6.TabIndex = 54;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 161);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 53;
			this.label10.Text = "Total Bayar";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(12, 249);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(331, 245);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DataTransaksi";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(192, 19);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(133, 20);
			this.textBox7.TabIndex = 18;
			this.textBox7.TextChanged += new System.EventHandler(this.TextBox7TextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(97, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(134, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "Cari Kode/Nama";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 45);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(319, 194);
			this.dataGridView2.TabIndex = 19;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(92, 182);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 51;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(92, 132);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(48, 20);
			this.textBox5.TabIndex = 50;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(92, 109);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(245, 20);
			this.textBox4.TabIndex = 49;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(92, 86);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 48;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(92, 63);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(245, 20);
			this.textBox2.TabIndex = 47;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 46;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 45;
			this.label6.Text = "Tanggal Beli";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 44;
			this.label5.Text = "Jumlah";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 43;
			this.label4.Text = "Harga Barang";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 42;
			this.label3.Text = "Kode Barang";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 41;
			this.label2.Text = "Nama";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 40;
			this.label1.Text = "Kode Penjualan";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(261, 215);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 24;
			this.button4.Text = "CLEAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(180, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 23;
			this.button3.Text = "HAPUS";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(99, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "EDIT";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(18, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "SAVE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Salmon;
			this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(40, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(275, 27);
			this.label7.TabIndex = 55;
			this.label7.Text = "NUHABEAUTYSHOP";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DataPenjualan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 502);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "DataPenjualan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataPenjualan";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
