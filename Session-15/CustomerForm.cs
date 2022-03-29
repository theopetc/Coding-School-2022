using CarServiceCenter.EF.Repositories;
using CarServiceCenterLibrary;

namespace Session_15
{
    public partial class CustomerForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        private List<Customer> _customers = new List<Customer>();
        private bool pressedEdit = false;
        public CustomerForm(IEntityRepo<Customer> customerRepo)
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

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(tin))
            {
                MessageBox.Show("Empty Textboxes!");
                return;
            }
                

            var customer = new Customer() { Name = name , Surname = surname, Phone = phone, TIN = tin};
            _customerRepo.Create(customer);

            EmptyTextBoxes();

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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            pressedEdit = true;
            if (grvCustomers.Rows.Count > 0)
            {
                var selectedRow = grvCustomers.CurrentRow;
                var selectedCustomer = selectedRow.DataBoundItem as Customer;

                if (selectedCustomer is not null)
                {
                    txtCustomerName.Text = selectedCustomer.Name;
                    txtCustomerSurname.Text = selectedCustomer.Surname;
                    txtCustomerPhone.Text = selectedCustomer.Phone;
                    txtCustomerTIN.Text = selectedCustomer.TIN;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!pressedEdit)
                return;
            
            if (grvCustomers.Rows.Count > 0)
            {
                var selectedRow = grvCustomers.CurrentRow;
                var selectedCustomer = selectedRow.DataBoundItem as Customer;

                if (selectedCustomer is not null)
                {
                    selectedCustomer.Name = txtCustomerName.Text;
                    selectedCustomer.Surname = txtCustomerSurname.Text;
                    selectedCustomer.Phone = txtCustomerPhone.Text;
                    selectedCustomer.TIN = txtCustomerTIN.Text;
                }
                _customerRepo.Update(selectedCustomer.ID, selectedCustomer);
                RefreshCustomers();
            }
            EmptyTextBoxes();
            pressedEdit = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();
        }

        private void EmptyTextBoxes()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerSurname.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerTIN.Text = string.Empty;
        }

        
    }
}