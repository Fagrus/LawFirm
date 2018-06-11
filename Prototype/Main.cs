using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Prototype
{
    public partial class Main : Form
    {
        public SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protoDataSet.Pro_tbl' table. You can move, or remove it, as needed.
            this.pro_tblTableAdapter.Fill(this.protoDataSet.Pro_tbl);
            //cmd.Connection = Connect;

            //System.Data.SqlClient.SqlConnection sqlconnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\Year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True");
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Pro_tbl";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Connect;
            Connect.Open();

            reader = cmd.ExecuteReader();
            Connect.Close();
        }

        private void SQL_delete()
        {
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True"))// = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\Year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = ("INSERT INTO Pro_tbl (Name, Surname) values ('" + Name_txt.Text + "','" + SN_txt.Text + "')");
                    cmd.Connection = Connect;
                    Connect.Open();
                    cmd.ExecuteNonQuery();
                    this.pro_tblTableAdapter.Fill(this.protoDataSet.Pro_tbl);
                    Connect.Close();
                    Id_txt.Enabled = true;
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True")) //SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\Year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    var id = Id_txt.Text;
                    cmd.CommandText = ("DELETE FROM Pro_tbl WHERE Id='" + id + "'");
                    cmd.Connection = Connect;
                    Connect.Open();
                    cmd.ExecuteNonQuery();
                    this.pro_tblTableAdapter.Fill(this.protoDataSet.Pro_tbl);
                    Connect.Close();
                }
            }
        }

        private void Nxt_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True"));
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    var id = Id_txt.Text;
                    cmd.CommandText = ("SELECT * FROM Pro_tbl WHERE Id >'" + id + "'");
                    cmd.Connection = Connect;
                    Connect.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        try
                        {
                            oReader.Read();
                            Id_txt.Text = oReader["Id"].ToString();
                            Name_txt.Text = oReader["Name"].ToString();
                            SN_txt.Text = oReader["Surname"].ToString();
                        }
                        catch (Exception)
                        {
                            //Nxt_btn.Enabled = false ;
                        }
                    }
                    Connect.Close();
                }
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True")) //SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\ATS-V-FS12\StudentHome$\Year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Prototype\Proto.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    var id = Id_txt.Text;
                    cmd.CommandText = ("SELECT * FROM Pro_tbl WHERE Id <'" + id + "'");
                    cmd.Connection = Connect;
                    Connect.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Id_txt.Text = oReader["Id"].ToString();
                            Name_txt.Text = oReader["Name"].ToString();
                            SN_txt.Text = oReader["Surname"].ToString();
                        }
                    }
                    Connect.Close();
                }
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Id_txt.Clear();
            Id_txt.Enabled = false;
            Name_txt.Clear();
            SN_txt.Clear();
        }

        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LForm = new Login();
            LForm.Closed += (s, args) => this.Close();
            LForm.Show();
        }

        private void dataTableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TForm = new Table();
            TForm.Closed += (s, args) => this.Close();
            TForm.Show();
        }

        private void backToLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var LForm = new Login();
            LForm.Closed += (s, args) => this.Close();
            LForm.Show();
        }
    }
}
