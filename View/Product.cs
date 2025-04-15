using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Service.Dtos;

namespace View
{
    public partial class Product : Form
    {
        private readonly ProductService _productService;
        public Product()
        {
            _productService = new ProductService();
            InitializeComponent();
        }
        private void RefreshDataGrid()
        {
            var refreshList = _productService.GetAll();
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = refreshList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Switchboard switchboard = new Switchboard();
            switchboard.Show();

            this.Hide();
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                txtCode.Text = selectedRow.Cells["Code"].Value?.ToString();
                txtTitle.Text = selectedRow.Cells["Title"].Value?.ToString();
                txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value?.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productService.GetAll();
            MessageBox.Show("is done!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = new PostProductDto()
            {
                Title = txtTitle.Text,
                UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
               
            };
            _productService.Post(p);
            RefreshDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new EditProductDto()
                {
                    Code = Convert.ToInt32(txtCode.Text),
                    Title = txtTitle.Text,
                    UnitPrice = Convert.ToInt32(txtUnitPrice.Text)
                };
                _productService.Edit(p);
                RefreshDataGrid();

                MessageBox.Show("Is Done!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are your sure?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            {
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        var p = new DeleteProductDto()
                        {
                            Code = Convert.ToInt32(txtCode.Text)
                        };
                        _productService.Delete(p);
                        RefreshDataGrid();
                    }
                }
                catch (Exception exception)
                {
                    throw new AggregateException("Error");
                }


            }
        }
    }
}
