using _03_2.ShowCollectionInWindowsFormApplication.Models;

namespace _03_2.ShowCollectionInWindowsFormApplication
{
    public partial class Form1 : Form
    {
        List<PersonData> people;

        public Form1()
        {
            InitializeComponent();

            people = new List<PersonData>
            {
                new PersonData { FirstName = "Parham",LastName = "Darvishi", Age = 26 },
                new PersonData { FirstName = "Hamid",LastName = "Fathi", Age = 25 },
                new PersonData { FirstName = "Pari",LastName = "Mohamadi", Age = 35 }
            };
            PeopleGridView.DataSource = people;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonData data = new PersonData()
            {
                FirstName = FisrtNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text),
            };
            people.Add(data);
            PeopleGridView.DataSource = null;
            PeopleGridView.DataSource = people;
            PeopleGridView.Refresh();
        }
    }
}