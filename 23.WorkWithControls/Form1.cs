using _23.WorkWithControls.Forms.Member;

namespace _23.WorkWithControls
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember member = new AddMember();
            member.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showCurrentListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void showCurrentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}