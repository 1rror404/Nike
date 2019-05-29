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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text;
            string b = this.textBox2.Text;

            if (a == "" || b == "")
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }

            string sql = string.Format("select count(*) from Salesan where Mobile='{0}' and pwd='{1}'",a,b);
            int rows = db.dl(sql);
            if (rows > 0)
            {
                MessageBox.Show("登录成功");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
