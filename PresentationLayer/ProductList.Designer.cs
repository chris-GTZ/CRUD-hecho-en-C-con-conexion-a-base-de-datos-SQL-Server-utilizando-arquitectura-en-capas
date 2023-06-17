namespace PresentationLayer {
  partial class ProductList {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.DGVProducts = new System.Windows.Forms.DataGridView();
      this.label10 = new System.Windows.Forms.Label();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
      this.SuspendLayout();
      // 
      // DGVProducts
      // 
      this.DGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGVProducts.Location = new System.Drawing.Point(12, 119);
      this.DGVProducts.Name = "DGVProducts";
      this.DGVProducts.ReadOnly = true;
      this.DGVProducts.RowTemplate.Height = 24;
      this.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DGVProducts.Size = new System.Drawing.Size(1061, 463);
      this.DGVProducts.TabIndex = 0;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(398, 30);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(289, 55);
      this.label10.TabIndex = 1;
      this.label10.Text = "Product List";
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.Location = new System.Drawing.Point(595, 625);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(92, 33);
      this.btnEdit.TabIndex = 3;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnCreate
      // 
      this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCreate.Location = new System.Drawing.Point(328, 625);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(92, 33);
      this.btnCreate.TabIndex = 3;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(447, 625);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(128, 33);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // ProductList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1115, 702);
      this.Controls.Add(this.DGVProducts);
      this.Controls.Add(this.btnCreate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.label10);
      this.Name = "ProductList";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView DGVProducts;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnDelete;
  }
}

