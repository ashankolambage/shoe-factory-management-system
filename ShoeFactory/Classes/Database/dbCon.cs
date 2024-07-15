using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeFactory.Classes.Database
{
    class dbCon
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Programming Projects\Visual Studio\Version 2019\ShoeFactory\ShoeFactory\ShoeFactory.accdb");

        public int WriteDB(string query)
        {
            int i = 0;
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                i = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + '\n' + ex.Message);
            }
            con.Close();
            return i;
        }

        public DataTable ReadDB(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + '\n' + ex.Message);
            }
            con.Close();
            return dt;
        }

        public string NextID(string table, string column, string prefix)
        {
            string nextID = "";
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select top 1 " + column + " from " + table + " order by " + column + " desc";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    nextID = prefix + "0000" + 1;
                }
                else
                {
                    nextID = dt.Rows[0][0].ToString();
                    string digits = new string(nextID.Where(char.IsDigit).ToArray());
                    string letters = new string(nextID.Where(char.IsLetter).ToArray());

                    int number;
                    if (!int.TryParse(digits, out number))
                    {
                        Console.WriteLine("ID Generate Error");
                    }
                    nextID = letters + (++number).ToString("D5");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + '\n' + ex.Message);
            }
            con.Close();
            return nextID;
        }
    }
}
