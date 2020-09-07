using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Products_Management_System.Business_Layer
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.close();
            return Dt;
        }

        public void ADD_PRODUCTS(int ID_cat, string Label_Product, string ID_product,
            int Qte, string Price, byte[] img)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@LABEL", SqlDbType.NVarChar);
            param[2].Value = Label_Product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;


            DAL.ExcecuteCommand("ADD_PRODUCT", param);
            DAL.close();

        }


        public DataTable VERIFY_PRODUCT_ID(string id)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;
            Dt = DAL.SelectData("VERIFY_PRODUCT_ID", param);
            DAL.close();
            return Dt;
        }


        public DataTable GET_ALL_PRODUCTS()
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.close();
            return Dt;
        }


        public DataTable SEARCH_PRODUCT(string id)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            Dt = DAL.SelectData("SEARCH_PRODUCTS", param);
            DAL.close();
            return Dt;
        }



        public void DELETE_PRODUCT(string ID)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            param[0].Value = ID;

            DAL.ExcecuteCommand("DELETE_PRODUCT", param);
            DAL.close();

        }


        public DataTable GET_IMAGE_PRODUCT(string id)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            Dt = DAL.SelectData("GET_IMAGE_PRODUCT", param);
            DAL.close();
            return Dt;
        }



        public void UPDATE_PRODCUTS(int ID_cat, string Label_Product, string ID_product,
         int Qte, string Price, byte[] img)
        {
            Data_Access_Layer.Data_Access_Layer DAL = new Data_Access_Layer.Data_Access_Layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@LABEL", SqlDbType.NVarChar);
            param[2].Value = Label_Product;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = img;


            DAL.ExcecuteCommand("UPDATE_PRODCUTS", param);
            DAL.close();

        }

    }
}
