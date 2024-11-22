using _31.ShowDataInDataGrid.Models;

namespace _31.ShowDataInDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                // Get the current row
                var row = dataGridView1.Rows[e.RowIndex];

                // Access the ID from the row's data
                var id = row.Cells["Id"].Value;

                // Display or use the ID
                MessageBox.Show($"Row ID: {id}");
            }
        }

        private void FillData()
        {
            List<Person> people = new List<Person>();
            people.Add( new Person() { Id = 1, FirstName = "F_Test1", LastName ="L_Test1" });
            people.Add( new Person() { Id = 2, FirstName = "F_Test2", LastName ="L_Test2" });
            people.Add( new Person() { Id = 3, FirstName = "F_Test3", LastName ="L_Test3" });

            dataGridView1.DataSource = people;
            dataGridView1.Refresh();
        }
    }
}
