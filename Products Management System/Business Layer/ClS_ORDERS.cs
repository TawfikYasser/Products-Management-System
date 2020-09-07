using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management_System.Business_Layer
{
    class ClS_ORDERS
    {



        public DataTable GET_LAST_ORDER_ID()
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.close();
            return Dt;
        }


        public void ADD_ORDER(
            int ID_ORDER, DateTime DATE_ORDER,
                int CUSTOMER_ID, string DESCRIPTION_ORDER, string SALESMAN)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.NVarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALESMAN", SqlDbType.NVarChar,75);
            param[4].Value = SALESMAN;


            DAL.ExcecuteCommand("ADD_ORDER", param);
            DAL.close();

        }



        public void ADD_ORDER_DETAILS(
            string ID_PRODUCT,int ID_ORDER,int QTE, string PRICE,
            float DISCOUNT,string AMOUNT,string TOTAL_AMOUNT
            )
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = TOTAL_AMOUNT;


            DAL.ExcecuteCommand("ADD_ORDER_DETAILS", param);
            DAL.close();

        }



        public DataTable VERIFY_QTE(string id,int qty)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = id;

            param[1] = new SqlParameter("@Qty_ENTERED", SqlDbType.Int);
            param[1].Value = qty;
            Dt = DAL.SelectData("VERIFY_QTE", param);
            DAL.close();
            return Dt;
        }





        public DataTable GET_LAST_ORDER_FOR_PRINT()
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_FOR_PRINT", null);
            DAL.close();
            return Dt;
        }


        public DataTable GET_ORDER_DETAILS(int id)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.VarChar, 30);
            param[0].Value = id;

            Dt = DAL.SelectData("GET_ORDER_DETAILS", param);
            DAL.close();
            return Dt;
        }


        public DataTable SEARCH_ORDERS(string Criterion)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 100);
            param[0].Value = Criterion;

            Dt = DAL.SelectData("SEARCH_ORDERS", param);
            DAL.close();
            return Dt;
        }

    }
}
