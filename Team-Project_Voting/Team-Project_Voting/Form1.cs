using System.Windows.Forms;
using static Team_Project_Voting.TitleVoiting;
namespace Team_Project_Voting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Setting_Click(object sender, EventArgs e)
        {

        }

        private void VoteItems()
        {
            TitleVoiting[] votingItems = new TitleVoiting[7];
            for (int i = 0; i < votingItems.Length; i++)
            {
                votingItems[i] = new TitleVoiting();
                //votingItems[i].Background = Properties.Resources.Знімок_екрана_2026_02_18_172853;
                votingItems[i].title = "Voting Item " + (i + 1);
                votingItems[i].Voted = "0 votes";
                flowLayoutPanel2.Controls.Add(votingItems[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VoteItems();
        }
    }
}
