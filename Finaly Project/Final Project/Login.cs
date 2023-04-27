using System.Data.SqlClient;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\13142\\OneDrive\\Documents\\GitHubClass\\WinForm2023FinalProject\\Finaly Project\\Final Project\\bin\\Debug\\LoginDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\13142\\OneDrive\\Documents\\GitHubClass\\WinForm2023FinalProject\\Finaly Project\\Final Project\\bin\\Debug\\LoginDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Register f2 = new Register();
                f2.Show();
            }
                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Register register = new Register();
            register.Show();

        }
    }
}