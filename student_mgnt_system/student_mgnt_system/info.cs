using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace student_mgnt_system
{
    public partial class info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=student_info;Integrated Security=True");
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Table] values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted successfully...!");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update [table] set Name='"+textBox2.Text+"',Address='"+textBox3.Text+"',Class='"+textBox4.Text+"' where ID='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated successfully...!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("delete from [Table] where ID='"+textBox1.Text+"' ",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted successfully");
            con.Close();
        }
    }
}
