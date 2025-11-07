namespace UtilizationTracker
{
    public partial class ErrorWindow : Form
    {
        private Form _parentWindow;
        private string _errorMsg;

        public ErrorWindow(Form parentWindow, string errorMsg)
        {
            _parentWindow = parentWindow;
            _errorMsg = errorMsg;
            InitializeComponent();
            _parentWindow.Enabled = false;
            textBoxErrorMsg.Text = _errorMsg;
        }

        private void ErrorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Enabled = true;
        }

        private void labelShowHide_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (textBoxErrorMsg.Enabled)
                {
                    case true:
                        labelShowHide.Text = "Show details";
                        textBoxErrorMsg.Enabled = false;
                        textBoxErrorMsg.Visible = false;
                        Height = 170;
                        break;

                    case false:
                        labelShowHide.Text = "Hide";
                        textBoxErrorMsg.Enabled = true;
                        textBoxErrorMsg.Visible = true;
                        Height = 255;
                        break;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
