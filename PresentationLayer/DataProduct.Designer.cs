namespace PresentationLayer {
  partial class DataProduct {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.cmbCategory = new System.Windows.Forms.ComboBox();
      this.cmbSubcategory = new System.Windows.Forms.ComboBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtSellEndDate = new System.Windows.Forms.TextBox();
      this.txtStandardCost = new System.Windows.Forms.TextBox();
      this.txtSize = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSellStartDate = new System.Windows.Forms.TextBox();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtListPrice = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // monthCalendar2
      // 
      this.monthCalendar2.Location = new System.Drawing.Point(245, 298);
      this.monthCalendar2.Name = "monthCalendar2";
      this.monthCalendar2.TabIndex = 30;
      this.monthCalendar2.Visible = false;
      this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
      this.monthCalendar2.MouseLeave += new System.EventHandler(this.monthCalendar2_Leave);
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(265, 298);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 29;
      this.monthCalendar1.Visible = false;
      this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
      this.monthCalendar1.MouseLeave += new System.EventHandler(this.monthCalendar1_Leave);
      // 
      // cmbCategory
      // 
      this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCategory.FormattingEnabled = true;
      this.cmbCategory.Location = new System.Drawing.Point(245, 265);
      this.cmbCategory.Name = "cmbCategory";
      this.cmbCategory.Size = new System.Drawing.Size(310, 30);
      this.cmbCategory.TabIndex = 28;
      this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
      this.cmbCategory.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
      this.cmbCategory.Leave += new System.EventHandler(this.cmbCategory_TextChanged);
      // 
      // cmbSubcategory
      // 
      this.cmbSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbSubcategory.FormattingEnabled = true;
      this.cmbSubcategory.Location = new System.Drawing.Point(245, 335);
      this.cmbSubcategory.Name = "cmbSubcategory";
      this.cmbSubcategory.Size = new System.Drawing.Size(310, 30);
      this.cmbSubcategory.TabIndex = 27;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(415, 597);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(80, 33);
      this.btnClear.TabIndex = 26;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtSellEndDate
      // 
      this.txtSellEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSellEndDate.Location = new System.Drawing.Point(415, 547);
      this.txtSellEndDate.Name = "txtSellEndDate";
      this.txtSellEndDate.Size = new System.Drawing.Size(140, 28);
      this.txtSellEndDate.TabIndex = 20;
      this.txtSellEndDate.Click += new System.EventHandler(this.txtSellEndDate_Click);
      // 
      // txtStandardCost
      // 
      this.txtStandardCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtStandardCost.Location = new System.Drawing.Point(245, 477);
      this.txtStandardCost.Name = "txtStandardCost";
      this.txtStandardCost.Size = new System.Drawing.Size(140, 28);
      this.txtStandardCost.TabIndex = 19;
      // 
      // txtSize
      // 
      this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSize.Location = new System.Drawing.Point(415, 407);
      this.txtSize.Name = "txtSize";
      this.txtSize.Size = new System.Drawing.Size(140, 28);
      this.txtSize.TabIndex = 18;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(411, 522);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(120, 24);
      this.label8.TabIndex = 17;
      this.label8.Text = "Sell end date";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(241, 452);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 24);
      this.label4.TabIndex = 15;
      this.label4.Text = "Standard cost";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(241, 242);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(85, 24);
      this.label9.TabIndex = 14;
      this.label9.Text = "Category";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(411, 382);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 24);
      this.label7.TabIndex = 7;
      this.label7.Text = "Size";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(241, 312);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(116, 24);
      this.label2.TabIndex = 12;
      this.label2.Text = "Subcategory";
      // 
      // txtSellStartDate
      // 
      this.txtSellStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSellStartDate.Location = new System.Drawing.Point(245, 547);
      this.txtSellStartDate.Name = "txtSellStartDate";
      this.txtSellStartDate.Size = new System.Drawing.Size(140, 28);
      this.txtSellStartDate.TabIndex = 21;
      this.txtSellStartDate.Click += new System.EventHandler(this.txtSellStartDate_Click);
      this.txtSellStartDate.TextChanged += new System.EventHandler(this.txtSellStartDate_TextChanged);
      this.txtSellStartDate.Leave += new System.EventHandler(this.txtSellStartDate_TextChanged);
      // 
      // txtColor
      // 
      this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtColor.Location = new System.Drawing.Point(245, 407);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(140, 28);
      this.txtColor.TabIndex = 22;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(241, 522);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(120, 24);
      this.label6.TabIndex = 11;
      this.label6.Text = "Sell start date";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(241, 382);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 24);
      this.label3.TabIndex = 10;
      this.label3.Text = "Color";
      // 
      // txtListPrice
      // 
      this.txtListPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtListPrice.Location = new System.Drawing.Point(415, 477);
      this.txtListPrice.Name = "txtListPrice";
      this.txtListPrice.Size = new System.Drawing.Size(140, 28);
      this.txtListPrice.TabIndex = 23;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(411, 452);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(84, 24);
      this.label5.TabIndex = 9;
      this.label5.Text = "List price";
      // 
      // txtID
      // 
      this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtID.Location = new System.Drawing.Point(245, 141);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(310, 28);
      this.txtID.TabIndex = 24;
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(245, 197);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(310, 28);
      this.txtName.TabIndex = 25;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      this.txtName.Leave += new System.EventHandler(this.txtName_TextChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(169, 21);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(462, 55);
      this.label11.TabIndex = 8;
      this.label11.Text = "Product Information";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(241, 116);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(27, 24);
      this.label12.TabIndex = 13;
      this.label12.Text = "ID";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(241, 172);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 24);
      this.label1.TabIndex = 16;
      this.label1.Text = "Name";
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(305, 597);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(80, 33);
      this.btnSave.TabIndex = 26;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // DataProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 671);
      this.Controls.Add(this.monthCalendar2);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.cmbCategory);
      this.Controls.Add(this.cmbSubcategory);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.txtSellEndDate);
      this.Controls.Add(this.txtStandardCost);
      this.Controls.Add(this.txtSize);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtSellStartDate);
      this.Controls.Add(this.txtColor);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtListPrice);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label1);
      this.Name = "DataProduct";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MonthCalendar monthCalendar2;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.ComboBox cmbCategory;
    private System.Windows.Forms.ComboBox cmbSubcategory;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox txtSellEndDate;
    private System.Windows.Forms.TextBox txtStandardCost;
    private System.Windows.Forms.TextBox txtSize;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSellStartDate;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtListPrice;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSave;
  }
}