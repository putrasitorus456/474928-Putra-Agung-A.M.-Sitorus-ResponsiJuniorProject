using Npgsql;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ResponsiPutra";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select id_karyawan, nama, karyawan.id_dep, nama_dep from karyawan inner join departemen on karyawan.id_dep = departemen.id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from karyawan_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinput", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = cbDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDep.Text = r.Cells["id_dep"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris yang mau di-edit", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from karyawan_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinput", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = cbDep.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris yang mau dihapus", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar ingin menghapus data " + r.Cells["nama"].Value.ToString() + " ?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from karyawan_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        tbNama.Text = cbDep.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}