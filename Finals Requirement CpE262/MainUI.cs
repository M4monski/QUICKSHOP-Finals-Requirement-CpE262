namespace Finals_Requirement_CpE262
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label_Welcome.BackColor = Color.Transparent;
        }

        private void But_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void But_Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void But_Admin_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkout cart = new Checkout();
            cart.Show();
            this.Hide();
        }
    }
}
