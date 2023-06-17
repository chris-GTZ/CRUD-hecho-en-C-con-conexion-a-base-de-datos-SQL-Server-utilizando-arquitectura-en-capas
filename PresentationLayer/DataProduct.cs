using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;

namespace PresentationLayer {
  public partial class DataProduct : Form {
    private bool create;
    public DataProduct(bool Create
                      , string IDProduct = ""
                      , string NameProduct = ""
                      , string Category = ""
                      , string Subcategory = ""
                      , string Color = ""
                      , string StandardCost = ""
                      , string ListPrice = ""
                      , string Size = ""
                      , string SellStartDate = ""
                      , string SellEndtDate = "") {
      InitializeComponent();
      this.create = Create;
      txtID.ReadOnly = IDProduct == "";
      txtID.Text = IDProduct;
      txtName.Text = NameProduct;
      cmbCategory.Text = Category;
      cmbSubcategory.Text = Subcategory;

      txtColor.Text = Color;
      txtStandardCost.Text = StandardCost;
      txtListPrice.Text = ListPrice;
      txtSize.Text = Size;
      txtSellStartDate.Text = SellStartDate;
      txtSellEndDate.Text = SellEndtDate;
      btnSave.Text = create ? "Create" : "Save";
      LoadCategory();
    }

    private void btnSave_Click(object sender, EventArgs e) {
      if (create) CreateProduct();
      else EditProduct();
    }

    private void btnClear_Click(object sender, EventArgs e) {
      ClearForm();
    }

    private void CreateProduct() {
      if (VerifyInformation(cmbSubcategory, txtName, txtSellStartDate)) {
        try {
          BL_Products.CreateProduct(
            txtName.Text
          , cmbSubcategory.Text
          , txtColor.Text
          , txtStandardCost.Text
          , txtListPrice.Text
          , txtSize.Text
          , txtSellStartDate.Text
          , txtSellEndDate.Text);
          MessageBox.Show("Product create");
          ClearForm();
        } catch (SqlException) {
          MessageBox.Show("Database connection error");
        } catch (Exception ex) {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    private void EditProduct() {
      if (VerifyInformation(cmbSubcategory, txtName, txtSellStartDate)) {
        try {
          BL_Products.UpdateProduct(
            txtID.Text
          , txtName.Text
          , cmbSubcategory.Text
          , txtColor.Text
          , txtStandardCost.Text
          , txtListPrice.Text
          , txtSize.Text
          , txtSellStartDate.Text
          , txtSellEndDate.Text);
          MessageBox.Show("Product updated");
          this.Close();
        } catch (SqlException) {
          MessageBox.Show("Database connection error");
        } catch (Exception ex) {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    private void ClearForm() {
      txtID.Text = "";
      txtName.Text = "";
      cmbCategory.Text = "";
      cmbSubcategory.Text = "";
      txtColor.Text = "";
      txtSize.Text = "";
      txtStandardCost.Text = "";
      txtListPrice.Text = "";
      txtSellEndDate.Text = "";
      txtSellStartDate.Text = "";
      cmbSubcategory.BackColor = Color.White;
      txtName.BackColor = Color.White;
      txtSellStartDate.BackColor = Color.White;
    }

    #region//------------------------------------------------------------------------Data control

    private void txtName_TextChanged(object sender, EventArgs e) {
      VerifyInformation(txtName);
    }

    private void cmbCategory_TextChanged(object sender, EventArgs e) {
      VerifyInformation(cmbCategory);
    }

    private void txtSellStartDate_TextChanged(object sender, EventArgs e) {
      if (VerifyInformation(txtSellStartDate)) {
        try {
          Convert.ToDateTime(txtSellStartDate.Text);
        } catch (Exception) {
          txtSellStartDate.BackColor = Color.Red;
        }
      }
    }

    private bool VerifyInformation(params Control[] lstForms) {
      bool flag = true;
      foreach (Control item in lstForms) {
        if (item.Text == "") {
          item.BackColor = Color.Red;
          flag = false;
        } else item.BackColor = Color.White;
      }
      return flag;
    }


    #endregion


    #region//------------------------------------------------------------------------Calendar control

    private void txtSellStartDate_Click(object sender, EventArgs e) {
      monthCalendar1.Visible = true;
    }

    private void txtSellEndDate_Click(object sender, EventArgs e) {
      monthCalendar2.Visible = true;
    }

    private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
      txtSellStartDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
      monthCalendar1.Visible = false;
    }

    private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e) {
      txtSellEndDate.Text = monthCalendar2.SelectionStart.ToShortDateString();
      monthCalendar2.Visible = false;
    }

    private void monthCalendar1_Leave(object sender, EventArgs e) {
      monthCalendar1.Visible = false;
    }

    private void monthCalendar2_Leave(object sender, EventArgs e) {
      monthCalendar2.Visible = false;
    }


    #endregion


    #region//------------------------------------------------------------------------Show information

    private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) {
      try {
        LoadSubcategory(cmbCategory.SelectedItem.ToString());
      } catch (SqlException) {
        MessageBox.Show("Database connection error");
      } catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void LoadCategory() {
      try {
        BL_Products OProducts = new BL_Products();
        cmbCategory.Items.Clear();
        cmbCategory.Items.AddRange(OProducts.LST_Category().ToArray());
      } catch (SqlException) {
        MessageBox.Show("Database connection error");
      } catch (Exception e) {
        MessageBox.Show(e.ToString());
      }
    }

    private void LoadSubcategory(string nameCategory) {
      try {
        BL_Products Oproducts = new BL_Products();
        cmbSubcategory.Items.Clear();
        cmbSubcategory.Items.AddRange(Oproducts.LST_Subcategory(nameCategory).ToArray());
      } catch (SqlException) {
        MessageBox.Show("Database connection error");
      } catch (Exception e) {
        MessageBox.Show(e.ToString());
      }
    }
    #endregion
  }
}
