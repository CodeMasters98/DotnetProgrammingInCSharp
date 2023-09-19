using _23.WorkWithControls.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace _23.WorkWithControls.Forms.Member
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
            List<string> genderItems = new List<string>();
            genderItems.Add("خانم");
            genderItems.Add("آقا");
            genderComboBox.DataSource = genderItems;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            DateTime birthDate = birthDateTimePicker.Value;
        }
    }
}
