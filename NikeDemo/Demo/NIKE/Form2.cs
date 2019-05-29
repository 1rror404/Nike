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
    public partial class Form2 : Form
    {

        Sunisoft.IrisSkin.SkinEngine skinEngine = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
            skinEngine.SkinFile = "ssk皮肤/MSN.ssk";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTabPage(string TabName, Form form)
        {   
            if (TabPgeIsExist(TabName)) return;
            TabPage page = new TabPage(TabName);
            form.TopLevel = false;
            form.Visible = true;
            page.Controls.Add(form);
            this.tabControl2.TabPages.Add(page);
            this.tabControl2.SelectedTab = page;

        }
        private bool TabPgeIsExist(string TabName)
        {
            bool isExist = false;
            foreach (TabPage page in this.tabControl2.TabPages)
            {
                if (page.Text == TabName)
                {
                    isExist = true;
                    this.tabControl2.SelectedTab = page;
                    break;
                }
            }
            return isExist;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            AddTabPage("商品入库",form3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            AddTabPage("商品浏览", form4);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult re = MessageBox.Show("确定关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine.SkinFile = "ssk皮肤/" + this.comboBox1.SelectedItem.ToString() + ".ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            AddTabPage("员工管理", form5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label11.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }
    }
}
