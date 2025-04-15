namespace View
{
    partial class Person
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
            btnAdd = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            personServiceBindingSource = new BindingSource(components);
            txtNationalId = new TextBox();
            lblNationalId = new Label();
            dgvPerson = new DataGridView();
            lblId = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)personServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(367, 139);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 25);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Lime;
            btnRefresh.Location = new Point(793, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 25);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(651, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 25);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 0);
            btnEdit.Location = new Point(509, 139);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 25);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(28, 493);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 47);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(28, 17);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name :";
            lblFirstName.Click += label1_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(28, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(69, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(104, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 23);
            txtFirstName.TabIndex = 8;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(182, 23);
            txtLastName.TabIndex = 9;
            // 
            // personServiceBindingSource
            // 
            personServiceBindingSource.DataSource = typeof(Service.PersonService);
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new Point(103, 98);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(182, 23);
            txtNationalId.TabIndex = 13;
            // 
            // lblNationalId
            // 
            lblNationalId.AutoSize = true;
            lblNationalId.Location = new Point(30, 101);
            lblNationalId.Name = "lblNationalId";
            lblNationalId.Size = new Size(68, 15);
            lblNationalId.TabIndex = 12;
            lblNationalId.Text = "NationalId :";
            // 
            // dgvPerson
            // 
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(367, 170);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.Size = new Size(562, 304);
            dgvPerson.TabIndex = 14;
            dgvPerson.CellContentClick += dgvPerson_CellContentClick;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(74, 142);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 15;
            lblId.Text = "Id :";
            lblId.Click += lblId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 139);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(181, 23);
            txtId.TabIndex = 16;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // Person
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(982, 552);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dgvPerson);
            Controls.Add(txtNationalId);
            Controls.Add(lblNationalId);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Name = "Person";
            Text = "Person";
            FormClosed += Person_FormClosed;
            ((System.ComponentModel.ISupportInitialize)personServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnBack;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNationalId;
        private Label lblNationalId;
        private BindingSource personServiceBindingSource;
        private DataGridView dgvPerson;
        private Label lblId;
        private TextBox txtId;
    }
}