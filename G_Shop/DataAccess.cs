using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace G_Shop
{
    internal class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcmd;
        public SqlCommand Sqlcmd
        {
            get { return this.sqlcmd; }
            set { this.sqlcmd = value; }
        }
        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
           this.sqlcon=new SqlConnection("Data Source=DESKTOP-UH9KLVQ\\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
           Sqlcon.Open();
        }
        private void QueryText(string query)
        {
            this.Sqlcmd = new SqlCommand(query, this.Sqlcon);
        }
        public DataSet ExecuteQuery(string sql) //For Select Query or Data Retrive
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcmd);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcmd);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }
        public int ExecuteDMLQuery(string sql) //Data Manipulation Op( Insert, Update, Delete)
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlcon);
            int u = this.Sqlcmd.ExecuteNonQuery();
            return u;
        }

    }
}
