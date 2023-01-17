using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nuhaa
{
	/// <summary>
	/// Description of Transaksi.
	/// </summary>
	public partial class Transaksi : Form
	{
		MySqlCommand query;
		MySqlCommand query1;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		MySqlDataAdapter adapter1;
		string sql;
		string sql1;
		DataTable tabel;
		DataSet ds;
		public Transaksi()
		{
			InitializeComponent();
			TampilDalamTabel1();
			TampilDalamTabel2();
		}
		
		void TampilDalamTabel1(){
			ViewData1 tampilkan = new ViewData1();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.bacasemua();
			dataGridView1.DataSource = tabel;
		}
		
		public class ViewData1
		{
			MySqlCommand query;
			Koneksi sambung;
			MySqlDataAdapter adapter;
			string sql;
			DataTable tabel;
			
			public DataTable bacasemua()
			{
				sambung = new Koneksi();
				sql = "SELECT * FROM barang";
				tabel = new DataTable();
			try
			{
				sambung.buka();
				query = new MySqlCommand(sql,sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
			}
		}
		
		void TampilDalamTabel2(){
			ViewData2 tampilkan = new ViewData2();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.bacasemua();
			dataGridView2.DataSource = tabel;
		}
		
		public class ViewData2
		{
			MySqlCommand query;
			Koneksi sambung;
			MySqlDataAdapter adapter;
			string sql;
			DataTable tabel;
			
			public DataTable bacasemua()
			{
				sambung = new Koneksi();
				sql = "SELECT * FROM penjualan";
				tabel = new DataTable();
			try
			{
				sambung.buka();
				query = new MySqlCommand(sql,sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
			}
		}
		
		public void bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
		}
		
		public void simpan()
		{
			sambung = new Koneksi();
			sql = "insert into penjualan (kdpenjualan, nama, kdbarang, hargabarang, jmlhbeli, total, tgl_pembelian) " +
				"VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"'," +
				"'"+textBox9.Text+"','"+textBox8.Text+"','"+dateTimePicker1.Text+"')";
			sql1 = "update barang set jmlhbarang='"+ ((Convert.ToInt32(textBox5.Text)-Convert.ToInt32(textBox9.Text)).ToString()) + "' where kdbarang='"+ textBox3.Text +"'";
		
		try
		{
			sambung.buka();
			query = new MySqlCommand(sql,sambung.koneksi);
			query1 = new MySqlCommand(sql1,sambung.koneksi);
			adapter = new MySqlDataAdapter(query);
			adapter1 = new MySqlDataAdapter(query1);
			query.ExecuteNonQuery();
			query1.ExecuteNonQuery();
			TampilDalamTabel1();
			TampilDalamTabel2();
			dataGridView1.Refresh();
			dataGridView2.Refresh();
			bersihkan();
			MessageBox.Show("Data Berhasil Tersimpan !!!", "Information");
		}
		catch (Exception er)
		{
			MessageBox.Show(er.Message);
		}
			sambung.tutup();
			
		}
				
		public void caribarang()
		{
			sambung= new Koneksi();
			sql= "Select * from barang where kdbarang like '%"+ textBox6.Text+"%' or nmbarang like '%"+ textBox6.Text+"%'";		
		try
		{
				sambung.buka();
				query= new MySqlCommand(sql,sambung.koneksi);
				ds = new DataSet();
				adapter = new MySqlDataAdapter(query);
				adapter.Fill(ds,"barang");
				query.ExecuteNonQuery();
				dataGridView1.Refresh();
				dataGridView1.DataSource=ds;
				dataGridView1.DataMember="barang";
					
		}
		catch(Exception er)
		{
			MessageBox.Show(er.Message);
		}
			sambung.tutup();
		}
		
		public void caripenjualan()
		{
			sambung= new Koneksi();
			sql= "Select * from penjualan where kdpenjualan like '%"+ textBox7.Text+"%' or nama like '%"+ textBox7.Text+"%'";		
		try
		{
				sambung.buka();
				query= new MySqlCommand(sql,sambung.koneksi);
				ds = new DataSet();
				adapter = new MySqlDataAdapter(query);
				adapter.Fill(ds,"penjualan");
				query.ExecuteNonQuery();
				dataGridView2.Refresh();
				dataGridView2.DataSource=ds;
				dataGridView2.DataMember="penjualan";
					
		}
		catch(Exception er)
		{
			MessageBox.Show(er.Message);
		}
			sambung.tutup();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			simpan();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox8.Text = (Convert.ToInt32(textBox4.Text)*Convert.ToInt32(textBox5.Text)).ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			bersihkan();
		}			
		void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
			textBox1.Text = row.Cells["kdpenjualan"].Value.ToString();
			textBox2.Text = row.Cells["nama"].Value.ToString();
			textBox3.Text = row.Cells["kdbarang"].Value.ToString();
			textBox4.Text = row.Cells["hargabarang"].Value.ToString();
			textBox9.Text = row.Cells["jmlhbeli"].Value.ToString();
			textBox8.Text = row.Cells["total"].Value.ToString();
			dateTimePicker1.Text = row.Cells["tgl_pembelian"].Value.ToString();
		}
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			textBox3.Text = row.Cells["kdbarang"].Value.ToString();
			textBox4.Text = row.Cells["hargabarang"].Value.ToString();
			textBox5.Text = row.Cells["jmlhbarang"].Value.ToString();
		}
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			caribarang();
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			caripenjualan();
		}
	}
}


