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
            if (string.IsNullOrEmpty(name))
                return;
            var customer = new Customer() { Name = name };
            _customerRepo.Create(customer);
            txtCustomerName.Text = string.Empty;
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
    }
}