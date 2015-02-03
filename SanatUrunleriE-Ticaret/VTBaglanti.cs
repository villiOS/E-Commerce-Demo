using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SanatUrunleriE_Ticaret
{
    public class VTBaglanti
    {
  

        public static SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=E-TicaretVT; Integrated Security=True");
            return baglanti;
        }

        //public static SqlConnection GetConnection()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=eticarettaki;Integrated Security=true;");
        //    return con;
        //}

        public static DataTable DataTableGetir(string sorgu, SqlParameter[] parameters)//birden çok sonuç döndürür
        {
            SqlConnection baglanti = baglan();
            baglanti.Open();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            baglanti.Close();
            command.Dispose();
            baglanti.Dispose();
            return dt;
        }

        public static int CommandGetir(string sorgu, SqlParameter[] parametre)//işlemler için
        {
            SqlConnection baglanti = baglan();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            if (parametre != null)
            {
                command.Parameters.AddRange(parametre);
            }
            int sonuc = command.ExecuteNonQuery();
            baglanti.Close();
            command.Dispose();
            baglanti.Dispose();
            return sonuc;
        }

        public static DataRow DataRowGetir(string sorgu, SqlParameter[] parametre)//tek satır döndürme
        {
            DataRow dr = null;
            DataTable dt = DataTableGetir(sorgu, parametre);
            if (dt.Rows.Count > 0)
            {
                dr = dt.Rows[0];
            }
            return dr;
        }
        //con: baglanti
        //getconnection: bglan
    }
}