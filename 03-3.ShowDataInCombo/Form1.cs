using _03_3.ShowDataInCombo.Enums;

namespace _03_3.ShowDataInCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            List<string> comboList = new List<string>();
            comboList.Add("");
            comboList.Add("Item1");
            comboList.Add("Item2");
            comboBox1.DataSource = comboList;

            comboBox2.DataSource = Enum.GetValues(typeof(Gender));
        }
    }
}