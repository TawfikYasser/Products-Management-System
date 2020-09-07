using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management_System.Data_Access_Layer
{
    class Data_Access_Layer
    {
        SqlConnection sqlconnection;

        //This constructor inisialize the connection object
        public Data_Access_Layer()

        {
            sqlconnection = new SqlConnection("Server=DESKTOP-KM1EAAM; Database=POS_DB; Integrated Security=true");
        }

        //Method to open the connection
        public void open()
        {
            if(sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method to read data from databases
        public DataTable SelectData(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method to (Insert/Update/Delete) Data from databases
        public void ExcecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }


    }
}
