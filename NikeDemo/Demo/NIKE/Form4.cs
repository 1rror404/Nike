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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void Form4_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select GoodsID, BarCode,TypeName,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate from Goods,Type where Goods.TypeID=Type.TypeID ");
                                                                                 
            DataSet ds = db.getDataSet(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["temp"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = textBox1.Text;
            string a2 = textBox2.Text;
            if (a1 == "" && a2 == "")
            {
                MessageBox.Show("请输入完整的查询条件");
                return;
            }
            if (a1 != "") 
            {
                string sql = string.Format("select  GoodsID, BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate from Goods where BarCode={0}", a1);
                DataSet ds = db.getDataSet(sql);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = ds.Tables["temp"];
            }
            if (a2 != "")
            {
                string sql = string.Format("select  GoodsID, BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate from Goods where GoodsName like '%{0}%'", a2);
                DataSet ds = db.getDataSet(sql);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = ds.Tables["temp"];
            }
            if (a1 != "" && a2 != "")
            {
                string sql = string.Format("select  GoodsID, BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate from Goods where BarCode={0}  and GoodsName like '%{1}%';",a1, a2);
                DataSet ds = db.getDataSet(sql);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = ds.Tables["temp"];
            }
           
        }
    }
}
