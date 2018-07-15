using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DataBase 的摘要说明
/// </summary>
/// 

namespace Hospital.DB
{
    public class DataBase
    {
        protected SqlConnection Connection;
        protected string ConnectionString;
		public DataBase()
		{
            ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
		private void Open()
		{
			if (Connection == null)
			{
				Connection = new SqlConnection(ConnectionString);
				Connection.Open();
			}
			else
			{
			  if (Connection.State.Equals(ConnectionState.Closed))
				  Connection.Open();   
			}
		}
		public void Close() 
		{
			if (Connection.State.Equals(ConnectionState.Open))
			{
				Connection.Close();     
			}
		}

        /// <summary>
		/// 析构函数，释放非托管资源
		/// </summary>
		~DataBase()
		{
			try
			{
				if (Connection != null)
					Connection.Close();
			}
			catch{}
			try
			{
				Dispose();
			}
			catch{}
		}
		public void Dispose()
		{
			if (Connection != null)		
			{
				Connection.Dispose();
				Connection = null;
			}
		}
        public bool GetRecord(string XSqlString)
        {
            Open();
            SqlDataAdapter adapter = new SqlDataAdapter(XSqlString, Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            Close();

            if (dataset.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetRecordCount(string XSqlString)
        {
            string SCount;

            Open();
            SqlCommand Cmd = new SqlCommand(XSqlString, Connection);
            SCount = Cmd.ExecuteScalar().ToString().Trim();
            if (SCount == "")
                SCount = "0";
            Close();
            return Convert.ToInt32(SCount);
        } 
        public DataSet GetDataSet(string queryString)
        {
            Open();
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            Close();
            return dataset;
        }
        public int GetIDInsert(string XSqlString)
        {
            int Count = -1;
            Open();
            SqlCommand cmd = new SqlCommand(XSqlString, Connection);
            Count = Convert.ToInt32(cmd.ExecuteScalar().ToString().Trim());
            Close();
            return Count;
        }
        public int InsertOrUpdate(string sqlString)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlString, Connection);
            int effectCount = -1;
            try
            {
                effectCount = cmd.ExecuteNonQuery();
            }
            finally
            {
                Close();
            }
            return effectCount; 
        }
        public bool ExecuteSQL(String[] SqlStrings)
        {
            bool success = true;
            Open();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction trans = Connection.BeginTransaction(); 
            cmd.Connection = Connection;
            cmd.Transaction = trans;

            int i = 0;
            try
            {
                foreach (String str in SqlStrings)
                {
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    i++;
                }
                trans.Commit();
            }
            catch
            {
                success = false;
                Close();
                trans.Rollback();
            }
            finally
            {
                Close();
            }
            return success;
        }
    }
}
