using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nuhaa
{
	/// <summary>
	/// Description of DataBarang.
	/// </summary>
	public partial class DataBarang : Form
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		string sql;
		DataTable tabel;
		DataSet ds;
		
		public DataBarang()
		{
			InitializeComponent();
			TampilDalamTabel();
		}
		
		void TampilDalamTabel(){
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.bacasemua();
			dataGridView1.DataSource = tabel;
		}
		
		public class ViewData
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
		
		public void bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
		}
		
		public void simpan()
		{
			sambung = new Koneksi();
			sql = "insert into barang (kdbarang, nmbarang, merek, hargabarang, jmlhbarang, tgl_masuk) " +
				"VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"'," +
				"'"+textBox5.Text+"','"+dateTimePicker1.Text+"')";
		try
		{
			sambung.buka();
			query = new MySqlCommand(sql,sambung.koneksi);
			adapter = new MySqlDataAdapter(query);
			query.ExecuteNonQuery();
			TampilDalamTabel();
			dataGridView1.Refresh();
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
			sql = "update barang set nmbarang='"+ textBox2.Text + "',merek='"+ textBox3.Text + "'," +
				"hargabarang='"+ textBox4.Text + "',jmlhbarang='"+ textBox5.Text + "',tgl_masuk='"+dateTimePicker1.Text+"'" +
				"where kdbarang='"+textBox1.Text+"'";
		try
		{
			sambung.buka();
			query = new MySqlCommand(sql,sambung.koneksi);
			adapter = new MySqlDataAdapter(query);
			query.ExecuteNonQuery();
			TampilDalamTabel();
			dataGridView1.Refresh();
			bersihkan();
			MessageBox.Show("Data Berhasil Terupdate !!!", "Information");
		}
		catch (Exception er)
		{
			MessageBox.Show(er.Message);
		}
			sambung.tutup();
		}
		
		public void hapus()
		{
			if (MessageBox.Show("Yakin akan menghapus data Barang : "+ textBox2.Text +" ?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sambung = new Koneksi();
				sql = "delete from barang where kdbarang='"+ textBox1.Text +"'";
			{
				sambung.buka();
				query = new MySqlCommand(sql,sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				TampilDalamTabel();
				dataGridView1.Refresh();
				bersihkan();
				MessageBox.Show("Data Berhasil Terhapus !!!", "Information");
			}
			}
		}
		
		public void cari()
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
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			cari();
		}		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			textBox1.Text = row.Cells["kdbarang"].Value.ToString();
			textBox2.Text = row.Cells["nmbarang"].Value.ToString();
			textBox3.Text = row.Cells["merek"].Value.ToString();
			textBox4.Text = row.Cells["hargabarang"].Value.ToString();
			textBox5.Text = row.Cells["jmlhbarang"].Value.ToString();
			dateTimePicker1.Text = row.Cells["tgl_masuk"].Value.ToString();
		}
	}
}
