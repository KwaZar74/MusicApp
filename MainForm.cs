using MusicApp.Forms;

namespace MusicApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Код загрузки формы
            FirstMeet firstMeet = new FirstMeet();
            firstMeet.TopLevel = false;
            firstMeet.AutoScroll = true;
            this.panel1.Controls.Add(firstMeet);
            firstMeet.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}