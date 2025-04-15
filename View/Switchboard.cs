namespace View
{
    public partial class Switchboard : Form
    {
        public Switchboard()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Show();

            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();

            this.Hide();
        }
    }
}
