namespace QueueingForm
{
    public partial class Form1 : Form
    {
        CashierWindowQueueingForm qForm = new CashierWindowQueueingForm();
        
        private CashierClass cashier;
        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();
            qForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}