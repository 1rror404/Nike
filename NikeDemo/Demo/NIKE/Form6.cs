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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Salesan set SalesmanName='{0}',Mobile='{1}',Gender='{2}',BaseSalary='{3}',CommissionRate='{4}',Role='{5}'where SalesmanName='{6}'", this.textBox1.Text, this.textBox2.Text,this.comboBox1.Text, this.textBox3.Text, this.textBox4.Text, this.comboBox2.Text);
            int rows = db.zsg(sql);
            if (rows > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
                return;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Salesan;");
            DataSet ds = db.getDataSet(sql);
           
            this.textBox1.Text = Form5.SalesmanName;
            this.textBox2.Text = Form5.Mobile;
            this.comboBox1.Text = Form5.Gender;
            this.textBox3.Text = Form5.BaseSalary;
            this.textBox4.Text = Form5.CommissionRate;
            this.comboBox2.Text = Form5.Role;
        }
    }
}
