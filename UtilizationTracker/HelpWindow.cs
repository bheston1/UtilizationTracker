namespace UtilizationTracker
{
    public partial class HelpWindow : Form
    {
        private Form _parentWindow;

        public HelpWindow(Form parentWindow)
        {
            _parentWindow = parentWindow;
            InitializeComponent();
            _parentWindow.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Enabled = true;
        }
    }
}
