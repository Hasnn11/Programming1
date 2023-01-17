using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nuhaa
{
	/// <summary>
	/// Description of DataPenjualan.
	/// </summary>
	public partial class DataPenjualan : Form
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		string sql;
		DataTable tabel;
		DataSet ds;
		public DataPenjualan()
		{
			InitializeComponent();
			TampilDalamTabel2();
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
		}
		
		public void simpan()
		{
			sambung = new Koneksi();
			sql = "insert into penjualan (kdpenjualan, nama, kdbarang, hargabarang, jmlhbeli, total, tgl_pembelian) " +
				"VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"'," +
				"'"+textBox5.Text+"','"+textBox5.Text+"','"+dateTimePicker1.Text+"')";
		try
		{
			sambung.buka();
			query = new MySqlCommand(sql,sambung.koneksi);
			adapter = new MySqlDataAdapter(query);
			query.ExecuteNonQuery();
			TampilDalamTabel2();
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
		
		public void edit()
		{
			sambung = new Koneksi();
			sql = "update penjualan set nama='"+ textBox2.Text + "',kdbarang='"+ textBox3.Text + "'," +
				"hargabarang='"+ textBox4.Text + "',jmlhbeli='"+ textBox5.Text + "',total='"+textBox6.Text+"'," +
				"tgl_pembelian='"+dateTimePicker1.Text+"' where kdpenjualan='"+ textBox1.Text +"'";
		try
		{
			sambung.buka();
			query = new MySqlCommand(sql,sambung.koneksi);
			adapter = new MySqlDataAdapter(query);
			query.ExecuteNonQuery();
			TampilDalamTabel2();
			dataGridView2.Refresh();
			bersihkan();
			MessageBox.Show("Data Berhasil Terupdate !!!", "Information");
		}
		catch (Exception er)
		{
			MessageBox.Show(er.Message);
		}
			sambung.tutup();
		}
		
		public void caripenjualan()
		{
			sambung= new Koneksi();
			sql= "Select * from barang where kdpenjualan like '%"+ textBox7.Text+"%' or nama like '%"+ textBox7.Text+"%'";		
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
		
		public void hapus()
		{
			if (MessageBox.Show("Yakin akan menghapus data pembelian : "+ textBox2.Text +" ?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sambung = new Koneksi();
				sql = "delete from penjualan where kdpenjualan='"+ textBox1.Text +"'";
			{
				sambung.buka();
				query = new MySqlCommand(sql,sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				TampilDalamTabel2();
				dataGridView2.Refresh();
				bersihkan();
				MessageBox.Show("Data Berhasil Terhapus !!!", "Information");
			}
			}
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			simpan();
		}
		void Button2Click(object sender, EventArgs e)
		{
			edit();
		}
		void Button3Click(object sender, EventArgs e)
		{
			hapus();
		}
		void Button4Click(object sender, EventArgs e)
		{
			bersihkan();
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			caripenjualan();
		}
		void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
			textBox1.Text = row.Cells["kdpenjualan"].Value.ToString();
			textBox2.Text = row.Cells["nama"].Value.ToString();
			textBox3.Text = row.Cells["kdbarang"].Value.ToString();
			textBox4.Text = row.Cells["hargabarang"].Value.ToString();
			textBox5.Text = row.Cells["jmlhbeli"].Value.ToString();
			textBox6.Text = row.Cells["total"].Value.ToString();
			dateTimePicker1.Text = row.Cells["tgl_pembelian"].Value.ToString();
		}
		
	}
}

