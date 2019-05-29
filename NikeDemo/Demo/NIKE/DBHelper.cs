using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NIKE
{
    class DBHelper
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=NIKE;Integrated Security=True");
        public DataSet getDataSet(string sql)
        {

            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            dap.Fill(ds,"temp");
            return ds;
            
        }
        public int zsg(string sql)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn); //写语句并执行
            int rows = cmd.ExecuteNonQuery(); //执行语句
            conn.Close();
            return rows;

        }

        public int dl(string sql)
        {
            conn.Open();
            SqlCommand ds = new SqlCommand(sql, conn);
            int rows = (int)ds.ExecuteScalar();
            conn.Close();
            return rows;
        }

    }
}
