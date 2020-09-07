using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Products_Management_System.Data_Access_Layer;

namespace Products_Management_System.Business_Layer
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar,50);
            param[1].Value = PWD;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.close();
            return Dt; 
        }



        public DataTable ADD_USER(string ID, string PWD,string fullname,string type)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            param[2] = new SqlParameter("@FullName", SqlDbType.NVarChar, 100);
            param[2].Value = fullname;

            param[3] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            param[3].Value = type;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ADD_USER", param);
            DAL.close();
            return Dt;
        }



        public DataTable SEARCH_USERS(string Criterion)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;

            Dt = DAL.SelectData("SEARCH_USERS", param);
            DAL.close();
            return Dt;
        }


        public DataTable EDIT_USER(string ID, string PWD, string fullname, string type)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            param[2] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            param[2].Value = type;

            param[3] = new SqlParameter("@FullName", SqlDbType.NVarChar, 100);
            param[3].Value = fullname;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("EDIT_USER", param);
            DAL.close();
            return Dt;
        }




        public DataTable DELETE_USER(string ID)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("DELETE_USER", param);
            DAL.close();
            return Dt;
        }

    }
}
