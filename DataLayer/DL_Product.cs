using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer {
  public class DL_Product {
    private DL_ConectionSQL ConnectionDB = new DL_ConectionSQL();
    private SqlDataReader ReaderData;
    private SqlCommand CommandQuery = new SqlCommand();
    private DataTable SQLTable = new DataTable();

    public DataTable ViewData() {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "ViewAllProducts";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        ReaderData = CommandQuery.ExecuteReader();
        SQLTable.Load(ReaderData);
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
      }
      return SQLTable;
    }

    public void CreateProduct(
      string name
      , string SubCategory
      , string color
      , double standardCost
      , double ListPrice
      , string Size
      , DateTime SellStartDate
      , DateTime SellEndDate
      ) {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "CreateProduct";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        CommandQuery.Parameters.AddWithValue("@NameProduct", name);
        CommandQuery.Parameters.AddWithValue("@ProductSubcategory", SubCategory);
        CommandQuery.Parameters.AddWithValue("@Color", color);
        CommandQuery.Parameters.AddWithValue("@StandardCost", standardCost);
        CommandQuery.Parameters.AddWithValue("@ListPrice", ListPrice);
        CommandQuery.Parameters.AddWithValue("@Size", Size);
        CommandQuery.Parameters.AddWithValue("@SellStartDate", SellStartDate);
        CommandQuery.Parameters.AddWithValue("@SellEndDate",
          (SellEndDate == Convert.ToDateTime(null)
          ? System.Data.SqlTypes.SqlDateTime.Null
          : SellEndDate)
          );
        CommandQuery.ExecuteNonQuery();
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
        CommandQuery.Parameters.Clear();
      }
    }

    public void UpdateProduct(
      int ID_Product
      , string name
      , string SubCategory
      , string color
      , double standardCost
      , double ListPrice
      , string Size
      , DateTime SellStartDate
      , DateTime SellEndDate
      ) {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "UpdateProduct";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        CommandQuery.Parameters.AddWithValue("@ID_Product", ID_Product);
        CommandQuery.Parameters.AddWithValue("@NameProduct", name);
        CommandQuery.Parameters.AddWithValue("@ProductSubcategory", SubCategory);
        CommandQuery.Parameters.AddWithValue("@Color", color);
        CommandQuery.Parameters.AddWithValue("@StandardCost", standardCost);
        CommandQuery.Parameters.AddWithValue("@ListPrice", ListPrice);
        CommandQuery.Parameters.AddWithValue("@Size", Size);
        CommandQuery.Parameters.AddWithValue("@SellStartDate", SellStartDate);
        CommandQuery.Parameters.AddWithValue("@SellEndDate",
          SellEndDate == Convert.ToDateTime(null)
          ? System.Data.SqlTypes.SqlDateTime.Null
          : SellEndDate
          );
        CommandQuery.ExecuteNonQuery();
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
        CommandQuery.Parameters.Clear();
      }
    }

    public void DeleteProduct(int ID_Product) {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "DeleteProduct";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        CommandQuery.Parameters.AddWithValue("@ID_Product", ID_Product);
        CommandQuery.ExecuteNonQuery();
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
        CommandQuery.Parameters.Clear();
      }
    }

    public DataTable TableCategory() {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "LST_Category";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        ReaderData = CommandQuery.ExecuteReader();
        SQLTable.Load(ReaderData);
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
      }
      return SQLTable;
    }

    public DataTable TableSubcategory(string category) {
      try {
        CommandQuery.Connection = ConnectionDB.OpenConnection();
        CommandQuery.CommandText = "LST_Subcategory";
        CommandQuery.CommandType = CommandType.StoredProcedure;
        CommandQuery.Parameters.AddWithValue("@ID_ProductCategory", category);
        ReaderData = CommandQuery.ExecuteReader();
        SQLTable.Load(ReaderData);
        CommandQuery.ExecuteNonQuery();
      } catch (Exception) {
        throw;
      } finally {
        ConnectionDB.CloseConnection();
        CommandQuery.Parameters.Clear();
      }     
      return SQLTable;
    }
  }
}
