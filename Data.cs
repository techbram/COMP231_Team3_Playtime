using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DemoCode
{
    public class Data
    {
        readonly string ConnStr = "Server=localhost\\SQLEXPRESS;Database=PlayTimeToy;Trusted_Connection=True;";
        
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
                            if (ds.Tables[0].Rows[i]["Id"] != null && ds.Tables[0].Rows[i]["Id"].ToString() != "")
                            {
                                p.Id = int.Parse(ds.Tables[0].Rows[i]["Id"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Name"] != null && ds.Tables[0].Rows[i]["Name"].ToString() != "")
                            {
                                p.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["CategoryId"] != null && ds.Tables[0].Rows[i]["CategoryId"].ToString() != "")
                            {
                                p.CategoryId = int.Parse(ds.Tables[0].Rows[i]["CategoryId"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Desc"] != null && ds.Tables[0].Rows[i]["Desc"].ToString() != "")
                            {
                                p.Desc = ds.Tables[0].Rows[i]["Desc"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["Price"] != null && ds.Tables[0].Rows[i]["Price"].ToString() != "")
                            {
                                p.Price = double.Parse(ds.Tables[0].Rows[i]["Price"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Imagelg"] != null && ds.Tables[0].Rows[i]["Imagelg"].ToString() != "")
                            {
                                p.Imagelg = ds.Tables[0].Rows[i]["Imagelg"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["ImageSm"] != null && ds.Tables[0].Rows[i]["ImageSm"].ToString() != "")
                            {
                                p.ImageSm = ds.Tables[0].Rows[i]["ImageSm"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["AgeGroup"] != null && ds.Tables[0].Rows[i]["AgeGroup"].ToString() != "")
                            {
                                p.AgeGroup = ds.Tables[0].Rows[i]["AgeGroup"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["IsActive"] != null && ds.Tables[0].Rows[i]["IsActive"].ToString() != "")
                            {
                                p.IsActive = bool.Parse(ds.Tables[0].Rows[i]["IsActive"].ToString());
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

        public List<Product> GetProductsByCategory(int CategoryId)
        {
            List<Product> objlist = new List<Product>();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select top 3 * from Product where CategoryId = " + CategoryId, con);
                    
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            Product p = new Product();
                            if (ds.Tables[0].Rows[i]["Id"] != null && ds.Tables[0].Rows[i]["Id"].ToString() != "")
                            {
                                p.Id = int.Parse(ds.Tables[0].Rows[i]["Id"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Name"] != null && ds.Tables[0].Rows[i]["Name"].ToString() != "")
                            {
                                p.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["CategoryId"] != null && ds.Tables[0].Rows[i]["CategoryId"].ToString() != "")
                            {
                                p.CategoryId = int.Parse(ds.Tables[0].Rows[i]["CategoryId"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Desc"] != null && ds.Tables[0].Rows[i]["Desc"].ToString() != "")
                            {
                                p.Desc = ds.Tables[0].Rows[i]["Desc"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["Price"] != null && ds.Tables[0].Rows[i]["Price"].ToString() != "")
                            {
                                p.Price = double.Parse(ds.Tables[0].Rows[i]["Price"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Imagelg"] != null && ds.Tables[0].Rows[i]["Imagelg"].ToString() != "")
                            {
                                p.Imagelg = ds.Tables[0].Rows[i]["Imagelg"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["ImageSm"] != null && ds.Tables[0].Rows[i]["ImageSm"].ToString() != "")
                            {
                                p.ImageSm = ds.Tables[0].Rows[i]["ImageSm"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["AgeGroup"] != null && ds.Tables[0].Rows[i]["AgeGroup"].ToString() != "")
                            {
                                p.AgeGroup = ds.Tables[0].Rows[i]["AgeGroup"].ToString();
                            }

                            if (ds.Tables[0].Rows[i]["IsActive"] != null && ds.Tables[0].Rows[i]["IsActive"].ToString() != "")
                            {
                                p.IsActive = bool.Parse(ds.Tables[0].Rows[i]["IsActive"].ToString());
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


        public Product GetProductsById(int id)
        {
            Product p = new Product();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Product where id = " + id, con);
                    
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        
                        if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                        {
                            p.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                        }

                        if (ds.Tables[0].Rows[0]["Name"] != null && ds.Tables[0].Rows[0]["Name"].ToString() != "")
                        {
                            p.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["CategoryId"] != null && ds.Tables[0].Rows[0]["CategoryId"].ToString() != "")
                        {
                            p.CategoryId = int.Parse(ds.Tables[0].Rows[0]["CategoryId"].ToString());
                        }

                        if (ds.Tables[0].Rows[0]["Desc"] != null && ds.Tables[0].Rows[0]["Desc"].ToString() != "")
                        {
                            p.Desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                        {
                            p.Price = double.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                        }

                        if (ds.Tables[0].Rows[0]["Imagelg"] != null && ds.Tables[0].Rows[0]["Imagelg"].ToString() != "")
                        {
                            p.Imagelg = ds.Tables[0].Rows[0]["Imagelg"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["ImageSm"] != null && ds.Tables[0].Rows[0]["ImageSm"].ToString() != "")
                        {
                            p.ImageSm = ds.Tables[0].Rows[0]["ImageSm"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["AgeGroup"] != null && ds.Tables[0].Rows[0]["AgeGroup"].ToString() != "")
                        {
                            p.AgeGroup = ds.Tables[0].Rows[0]["AgeGroup"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["IsActive"] != null && ds.Tables[0].Rows[0]["IsActive"].ToString() != "")
                        {
                            p.IsActive = bool.Parse(ds.Tables[0].Rows[0]["IsActive"].ToString());
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
                return p;
            }
        }

        public Category GetCategoryById(int id)
        {
            Category c = new Category();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Category where id = " + id, con);
                    

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                        {
                            c.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                        }

                        if (ds.Tables[0].Rows[0]["Name"] != null && ds.Tables[0].Rows[0]["Name"].ToString() != "")
                        {
                            c.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                        }

                        if (ds.Tables[0].Rows[0]["IsActive"] != null && ds.Tables[0].Rows[0]["IsActive"].ToString() != "")
                        {
                            c.IsActive = bool.Parse(ds.Tables[0].Rows[0]["IsActive"].ToString());
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
                return c;
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> objlist = new List<Category>();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("GetCategories", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            Category c = new Category();
                            if (ds.Tables[0].Rows[i]["Id"] != null && ds.Tables[0].Rows[i]["Id"].ToString() != "")
                            {
                                c.Id = int.Parse(ds.Tables[0].Rows[i]["Id"].ToString());
                            }

                            if (ds.Tables[0].Rows[i]["Name"] != null && ds.Tables[0].Rows[i]["Name"].ToString() != "")
                            {
                                c.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                            }                            

                            if (ds.Tables[0].Rows[i]["IsActive"] != null && ds.Tables[0].Rows[i]["IsActive"].ToString() != "")
                            {
                                c.IsActive = bool.Parse(ds.Tables[0].Rows[i]["IsActive"].ToString());
                            }
                            objlist.Add(c);
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

        public int DeleteProduct(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                // DELETE SQL command
                using (SqlCommand cmd = new SqlCommand("delete from Product where Id = " + id, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }


        public int DeleteCategory(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                // DELETE SQL command
                using (SqlCommand cmd = new SqlCommand("delete from Category where Id = " + id, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }




        public int AddProduct(string product_name,int CategoryId, string product_description, double price, string imagelarge, string imagesmall, string AgeGroup, int active_status)
        {
            string query = "INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive) " +
                "VALUES ('" + product_name + "', " + CategoryId + ", '" + product_description + "', " + price + ", '" + imagelarge + "' , '" + imagesmall + "', '" + AgeGroup + "', " + active_status + ");";

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }

        }


        public int AddCategory(Category obj)
        {

            int isactive = Convert.ToInt32(obj.IsActive);

            string query = "insert into Category ([Name], IsActive ) values('"+ obj.Name +"', "+ isactive + ")";

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }

        }





        public int EditProduct(int ProductId, string product_name, int CategoryId, string product_description, double price, string imagelarge, string imagesmall, string AgeGroup, int active_status)
        {
            string query = "Update Product set [Name] = '"+ product_name + "', CategoryId =" + CategoryId + ", [Desc] = '"+ 
                product_description + "', Price = "+ price + ", Imagelg= '"+ imagelarge + "', ImageSm = '"+ imagesmall + "', AgeGroup = '"+ AgeGroup + "', IsActive = "+ active_status + " where Id = " + ProductId;

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }


        public Product EditProductImage(int ProductId, string imagelarge)
        {
            string query = "Update Product set Imagelg= '" + imagelarge + "' where Id = " + ProductId;

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return GetProductsById(ProductId);
        }




        public int EditCategory(int Id, string category_name, int active_status)
        {
            string query = "Update Category set [Name] = '" + category_name + "', IsActive = "+ active_status + " where Id = " + Id;

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i;
                }
            }
        }

        public bool ValidateAdmin(string username, string password)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                DataSet ds = new DataSet();
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from [Admin]  where Username = '"+ username+"' and [Password] = '" + password+ "' ", con);

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Username"] != null && ds.Tables[0].Rows[0]["Username"].ToString() != "")
                        {
                            if (ds.Tables[0].Rows[0]["Password"] != null && ds.Tables[0].Rows[0]["Password"].ToString() != "")
                            {
                                string uname = ds.Tables[0].Rows[0]["Username"].ToString();
                                string pass = ds.Tables[0].Rows[0]["Password"].ToString();
                                if(uname == username && pass == password)
                                {
                                    result = true; 
                                    return result;
                                }
                            }
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
                return result;
            }
        }
        


    }


}