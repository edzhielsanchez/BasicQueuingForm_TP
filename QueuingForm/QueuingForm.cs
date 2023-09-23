using QueuingForm;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        private CustomerView customerView;

        public QueuingForm()
        {
            InitializeComponent();

            customerView = new CustomerView();
            customerView.Show();

            CashierWindowQueue csh = new CashierWindowQueue(customerView);
            csh.Show();
        }

        private void btnCashier_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}