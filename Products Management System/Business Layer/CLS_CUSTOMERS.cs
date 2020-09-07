using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management_System.Business_Layer
{
    class CLS_CUSTOMERS
    {

        public void ADD_CUSTOMERS(string FIRST_NAME, string LAST_NAME,
           string TEL, string EMAIL, byte[] PICUTRE,string Criterion)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.NVarChar, 25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.NVarChar,25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.NChar,15);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@PICUTRE", SqlDbType.Image);
            param[4].Value = PICUTRE;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar,50);
            param[5].Value = Criterion;


            DAL.ExcecuteCommand("ADD_CUSTOMERS", param);
            DAL.close();

        }


        public DataTable GET_ALL_CUSTOMERS()
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.close();
            return Dt;
        }



        
        
        public void EDIT_CUSTOMERS(string FIRST_NAME, string LAST_NAME,
                        string TEL, string EMAIL, byte[] PICUTRE, string Criterion,int id)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.NVarChar, 25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.NVarChar, 25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 15);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@PICUTRE", SqlDbType.Image);
            param[4].Value = PICUTRE;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = id;


            DAL.ExcecuteCommand("EDIT_CUSTOMERS", param);
            DAL.close();

        }



        public void DELETE_CUSTOMERS(int id)
        {




            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;


            DAL.ExcecuteCommand("DELETE_CUSTOMER", param);
            DAL.close();

        }



        public DataTable SEARCH_CUSTOMER(string Criterion)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("SEARCH_CUSTOMER", param);
            DAL.close();
            return Dt;
        }


    }
}
