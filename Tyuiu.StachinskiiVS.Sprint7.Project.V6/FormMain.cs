namespace Tyuiu.StachinskiiVS.Sprint7.Project.V6
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_SVS_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonInfoRazrab_SVS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonPatients_SVS_Click(object sender, EventArgs e)
        {
            FormPacient formPacient = new FormPacient();
            formPacient.ShowDialog();
        }


    }
}