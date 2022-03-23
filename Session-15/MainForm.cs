using CarServiceCenter.EF.Repositories;
using CarServiceCenterLibrary;

namespace Session_15
{
    public partial class MainForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        private List<Customer> _customers = new List<Customer>();
        public MainForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var name = txtCustomerName.Text;
            var surname = txtCustomerSurname.Text;
            var phone = txtCustomerPhone.Text;
            var tin = txtCustomerTIN.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(tin))
                return;

            var customer = new Customer() { Name = name , Surname = surname, Phone = phone, TIN = tin};
            _customerRepo.Create(customer);

            txtCustomerName.Text = string.Empty;
            txtCustomerSurname.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerTIN.Text = string.Empty;

            RefreshCustomers();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void RefreshCustomers()
        {
            _customers = _customerRepo.GetAll();
            grvCustomers.DataSource = null;
            grvCustomers.DataSource = _customers;
            //grvCustomers.Refresh();
            //grvCustomers.Update();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            
            if (grvCustomers.Rows.Count > 0)
            {
                var selectedRow = grvCustomers.CurrentRow;
                var selectedCustomer = selectedRow.DataBoundItem as Customer;

                if (selectedCustomer is not null)
                {
                    _customerRepo.Delete(selectedCustomer.ID);
                    RefreshCustomers();
                }
            }
        }
    }
}