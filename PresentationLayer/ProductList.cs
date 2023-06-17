using System;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;

namespace PresentationLayer {
  public partial class ProductList : Form {

    public ProductList() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      LoadTable();
    }

    private void btnCreate_Click(object sender, EventArgs e) {
      DataProduct DP = new DataProduct(true);
      DP.ShowDialog();
      LoadTable();
    }

    private void btnEdit_Click(object sender, EventArgs e) {
      if (DGVProducts.SelectedRows.Count == 1) { 
        DataProduct DP = new DataProduct(false
          , DGVProducts.CurrentRow.Cells["ID_Product"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Name product"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Category"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Subcategory"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Color"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Standard cost"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["List price"].Value.ToString()
          , DGVProducts.CurrentRow.Cells["Size"].Value.ToString()
          , (DGVProducts.CurrentRow.Cells["Sell start date"].Value.ToString() == string.Empty) ? ""
            : Convert.ToDateTime(DGVProducts.CurrentRow.Cells["Sell start date"].Value.ToString()).ToShortDateString()
          , (DGVProducts.CurrentRow.Cells["Sell end date"].Value.ToString() == string.Empty) ? ""
            : Convert.ToDateTime(DGVProducts.CurrentRow.Cells["Sell end date"].Value.ToString()).ToShortDateString());
        DP.ShowDialog();
      } else MessageBox.Show("Only select one row");
      LoadTable(); 
    }


    private void LoadTable() {
      try {
        BL_Products OProducts = new BL_Products();
        DGVProducts.DataSource = OProducts.DataProducts();
      } catch (SqlException) {
        MessageBox.Show("Database connection error");
      } catch (Exception e) {
        MessageBox.Show(e.ToString());
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      if (DGVProducts.SelectedRows.Count == 1) {
        try {
          BL_Products.DeleteProduct(DGVProducts.CurrentRow.Cells["ID_Product"].Value.ToString());
          LoadTable();
        } catch (SqlException) {
          MessageBox.Show("Database connection error");
        } catch (Exception ex) {
          MessageBox.Show(ex.ToString());
        }
      } else MessageBox.Show("Only select one row");
    }
  }
}
