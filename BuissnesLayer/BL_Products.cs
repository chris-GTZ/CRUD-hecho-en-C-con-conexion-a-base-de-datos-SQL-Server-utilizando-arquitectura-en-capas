using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;

namespace BusinessLayer {
  public class BL_Products {
    private DL_Product OProducts = new DL_Product();

    public DataTable DataProducts() {
      DataTable ProductsTable = OProducts.ViewData();
      return ProductsTable;
    }

    public static void CreateProduct(
      string name
      , string SubCategory
      , string color
      , string standardCost
      , string ListPrice
      , string Size
      , string SellStartDate
      , string SellEndDate) {
      DL_Product NewProduct = new DL_Product();
      NewProduct.CreateProduct(
        name
      , SubCategory
      , color
      , standardCost != String.Empty ? Convert.ToDouble(standardCost) : 0
      , ListPrice != String.Empty ? Convert.ToDouble(ListPrice) : 0
      , Size
      , Convert.ToDateTime(SellStartDate)
      , SellEndDate == string.Empty ? Convert.ToDateTime(null) : Convert.ToDateTime(SellEndDate));
    }

    public static void UpdateProduct(
      string ID_Product
      , string name
      , string SubCategory
      , string color
      , string standardCost
      , string ListPrice
      , string Size
      , string SellStartDate
      , string SellEndDate) {
      DL_Product UpdatePR = new DL_Product();
      UpdatePR.UpdateProduct(
        int.Parse(ID_Product)
      , name
      , SubCategory
      , color
      , standardCost != String.Empty ? Convert.ToDouble(standardCost) : 0
      , ListPrice != String.Empty ? Convert.ToDouble(ListPrice) : 0
      , Size
      , Convert.ToDateTime(SellStartDate)
      , SellEndDate == string.Empty ? Convert.ToDateTime(null) : Convert.ToDateTime(SellEndDate));
    }

    public static void DeleteProduct(string ID_Product) {
      DL_Product DeletePR = new DL_Product();
      DeletePR.DeleteProduct(Convert.ToInt32(ID_Product));
    }

    public List<string> LST_Category() {
      List<string> lstCategory = new List<string>();
      foreach (DataRow row in OProducts.TableCategory().Rows) {
        lstCategory.Add(row["Name"].ToString());
      }

      return lstCategory;
    }

    public List<string> LST_Subcategory(string category) {
      List<string> lstSubcategory = new List<string>();
      foreach (DataRow row in OProducts.TableSubcategory(category).Rows) {
        lstSubcategory.Add(row["Name"].ToString());
      }
      return lstSubcategory;
    }
  }
}
