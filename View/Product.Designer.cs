namespace View
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtUnitPrice = new TextBox();
            txtCode = new TextBox();
            txtTitle = new TextBox();
            lblPrice = new Label();
            lblCode = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            productServiceBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(74, 59);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(181, 23);
            txtUnitPrice.TabIndex = 22;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(73, 99);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(182, 23);
            txtCode.TabIndex = 21;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(74, 19);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(181, 23);
            txtTitle.TabIndex = 20;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(29, 62);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 15);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Price :";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(23, 102);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(41, 15);
            lblCode.TabIndex = 18;
            lblCode.Text = "Code :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(29, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 15);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Title :";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(12, 489);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 47);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 0);
            btnEdit.Location = new Point(503, 144);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 25);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(645, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 25);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Lime;
            btnRefresh.Location = new Point(787, 144);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 25);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(361, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 25);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(361, 175);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.Size = new Size(562, 290);
            dgvProduct.TabIndex = 28;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // productServiceBindingSource
            // 
            productServiceBindingSource.DataSource = typeof(Service.ProductService);
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(981, 548);
            Controls.Add(dgvProduct);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCode);
            Controls.Add(txtTitle);
            Controls.Add(lblPrice);
            Controls.Add(lblCode);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Name = "Product";
            Text = "Form1";
            FormClosed += Product_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUnitPrice;
        private TextBox txtCode;
        private TextBox txtTitle;
        private Label lblPrice;
        private Label lblCode;
        private Label lblTitle;
        private Button btnBack;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private BindingSource productServiceBindingSource;
    }
}