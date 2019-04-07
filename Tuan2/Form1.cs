using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tuan2
{
    public partial class Form1 : Form
    {
        private static String connStr = @"server=localhost;port=3306;database=keypass;user=root;password=root";
        //MySqlConnection con = new MySqlConnection(connStr);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }


        private void BindData()
        {
            DataTable dt = new DataTable();


            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select id, `desc`,`username`,`domain` from info";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgvInfor.DataSource = dt;
                }

                cn.Close();
            }
            


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (MySqlConnection cnn = new MySqlConnection(connStr))
            {
                cnn.Open();
                if(txtDomain.Text == "" || txtPass.Text == "" || txtUser.Text == "")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    String sql = "insert into info (`desc`,`domain`,`username`,`password`) values ('" + txtDesc.Text + "','" + txtDomain.Text + "','" + txtUser.Text + "','" + txtPass.Text + "')";
                    //String sql = "insert into info (desc,domain,username,password) values ('txtDesc.Text txtDomain.Text + "','" + txtUser.Text + "','" + txtPass.Text + "')";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.InsertCommand = new MySqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    BindData();
                    cmd.Dispose();
                    cnn.Close();

                }
            }
   
        }

        



    

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cnn = new MySqlConnection(connStr))
            {
                cnn.Open();
                string sel_id = dgvInfor.CurrentRow.Cells["id"].Value.ToString();
                String sql = "delete from info where id = " + sel_id;
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.InsertCommand = new MySqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                BindData();
                cmd.Dispose();
                cnn.Close();

            }
        }



        private void btnShowPass_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cnn = new MySqlConnection(connStr))
            {
                cnn.Open();
                string sel_id = dgvInfor.CurrentRow.Cells["id"].Value.ToString();
                string sql = "select password from info where id = " + sel_id;
                MySqlCommand cmd = new MySqlCommand(sql,cnn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string value = "";
            
                if (dataReader.Read())
                {
                    value = dataReader["password"].ToString();
                }
                dataReader.Close();
                
                
                cnn.Close();
                MessageBox.Show(value);


            }

        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();


            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select * from info where domain like('%" + txtSearch.Text + "%')";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgvInfor.DataSource = dt;
                }

                cn.Close();
            }
        }

       
    }
}
