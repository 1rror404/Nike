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


namespace NIKE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = this.textBox1.Text;  //条形码
            string a2 = this.textBox2.Text;   //商品名称
            string a3 = this.comboBox1.Text;   //商品分类
            string a33 = this.comboBox2.Text;
            string a4 = this.textBox3.Text;    //进货价格
            string a5 = this.textBox4.Text;   //零售价格
            string a6 = this.textBox5.Text;   //折扣
            string a7 = this.textBox6.Text;   //入库数量
            if (a1 == "" || a2 == "" || a3 == "" || a4 == "" || a5 == "" || a6 == "" || a7 == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }
            string sql = string.Format("@insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum)values('{0}','{1}','{2}','{3}','{4}')",a1,a3,a2,a4,a5,a6,a7);
            int rows = db.zsg(sql);
            if (rows > 0)
            {
                MessageBox.Show("添加成功");
             
            }
            else
            {
                MessageBox.Show("添加失败");
            }

                                                                              

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
              
             

        }
    }
}
