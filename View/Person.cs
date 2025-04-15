using Service;
using Service.Dtos;

namespace View
{
    public partial class Person : Form
    {
        private readonly PersonService _personService;
        public Person()
        {
            InitializeComponent();
            _personService = new PersonService();
        }

        private void RefreshDataGrid()
        {
            var refreshList = _personService.GetAll();
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = refreshList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Switchboard switchboard = new Switchboard();
            switchboard.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personService.GetAll();
            MessageBox.Show("is done!");

        }

        private void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPerson.Rows[e.RowIndex];

                txtId.Text = selectedRow.Cells["Id"].Value?.ToString();
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value?.ToString();
                txtNationalId.Text = selectedRow.Cells["NationalId"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = new PostPersonDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                NationalId = Convert.ToInt32(txtNationalId.Text)
            };
            _personService.Post(p);
            RefreshDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new EditPersonDto()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    NationalId = Convert.ToInt32(txtNationalId.Text)
                };
                _personService.Edit(p);
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
                        var p = new DeletePersonDto()
                        {
                            Id = Convert.ToInt32(txtId.Text)
                        };
                        _personService.Delete(p);
                        RefreshDataGrid();
                    }
                }
                catch (Exception exception)
                {
                    throw new AggregateException("Error");
                }


            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblId_Click(object sender, EventArgs e)
        {
        }
    }
}
