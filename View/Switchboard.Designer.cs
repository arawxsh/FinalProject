namespace View
{
    partial class Switchboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProduct = new Button();
            btnPerson = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.ButtonFace;
            btnProduct.Location = new Point(521, 195);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(183, 103);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Prudoct";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnPerson
            // 
            btnPerson.BackColor = SystemColors.ButtonFace;
            btnPerson.Location = new Point(245, 195);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(183, 103);
            btnPerson.TabIndex = 2;
            btnPerson.Text = "Person";
            btnPerson.UseVisualStyleBackColor = false;
            btnPerson.Click += btnPerson_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(396, 80);
            label1.Name = "label1";
            label1.Size = new Size(172, 47);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            // 
            // Switchboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(949, 554);
            Controls.Add(label1);
            Controls.Add(btnPerson);
            Controls.Add(btnProduct);
            Name = "Switchboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProduct;
        private Button btnPerson;
        private Label label1;
    }
}
