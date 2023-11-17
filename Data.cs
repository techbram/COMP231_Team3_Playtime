using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoCode
{
    public class Data
    {
        readonly string ConnStr = "Server=localhost;Database=TempDb;Trusted_Connection=True;";


        public List<Product> GetProducts()
        {
            List<Product> objlist = new List<Product>();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("GetProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            Product p = new Product();
                            if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                            {
                                p.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                            }
                            objlist.Add(p);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    ds.Dispose();
                    con.Close();
                    con.Dispose();
                }
                return objlist;
            }
        }
    }


}