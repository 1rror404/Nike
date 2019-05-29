using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIKE
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        DBHelper db = new DBHelper();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Salesan; ");
            DataSet ds = db.getDataSet(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["temp"];

            this.textBox1.Text = SalesmanName;
            this.textBox2.Text = Mobile;
            this.comboBox1.Text = Gender;
            this.textBox3.Text = BaseSalary;
            this.textBox4.Text = CommissionRate;
            this.comboBox2.Text = Role;
        }

        public static string SalesmanName;
        public static string Mobile;
        public static string Gender;
        public static string BaseSalary;
        public static string CommissionRate;
        public static string Role;
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanName = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Mobile = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Gender = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            BaseSalary = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            CommissionRate = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Role = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            Form6 from6 = new Form6();
            from6.ShowDialog();


          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = this.textBox1.Text;
            string a2 = this.textBox2.Text;
            string a3 = this.comboBox1.Text;
            string a4 = this.textBox3.Text;
            string a5 = this.textBox4.Text;
            string a6 = this.comboBox2.Text;


            string sql = string.Format(@"insert into Salesan(SalesmanName,Mobile,Gender,BaseSalary,CommissionRate,Role)values
                                          ('{0}','{1}','{2}','{3}','{4}','{5}')", a1, a2, a3, a4, a5, a6);
//            string sql = string.Format(@"insert into Salesan(SalesmanName,Mobile,Gender,BaseSalary,CommissionRate,Role)values
//                                                          ('{0}','{1}','{2}','{3}','{4}',{5})", a1, a2, a3, a4,a5,a6);
            int rows = db.zsg(sql);
            if (rows > 0)
            {
                MessageBox.Show("添加成功");

                string sql1 = string.Format("select * from Salesan; ");
                DataSet ds = db.getDataSet(sql1);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = ds.Tables["temp"];

            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
