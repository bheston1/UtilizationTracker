namespace UtilizationTracker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            int shiftLength = GetShiftLength();

            if (!checkBoxLunch.Checked)
            {
                shiftLength += 1;
            }

            double goal = Math.Round((shiftLength - 0.5) * 0.75, 1);
            double total = 0;

            foreach (double time in listBoxTimes.Items)
            {
                total += time;
            }

            labelGoal.Text = $"Goal: {goal}";
            labelTotal.Text = $"Current total: {Math.Round(total, 2)}";

            if (total >= goal)
            {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Utilization goal met";
                labelOverDiff.Visible = true;
                labelOverDiff.Text = $"+{Math.Round(total - goal, 2)}";
            }
            else
            {
                labelResult.ForeColor = Color.Black;
                labelOverDiff.Visible = false;
                labelResult.Text = $"Time remaining: {Math.Round(goal - total, 2)}";
            }

            if (listBoxTimes.Items.Count > 0)
            {
                buttonDelete.Enabled = true;
                buttonClear.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
                buttonClear.Enabled = false;
            }
        }

        private int GetShiftLength()
        {
            return (int)numInputShift.Value;
        }

        private void AddTime()
        {
            labelInvalidTime.Visible = false;

            try
            {
                listBoxTimes.Items.Add(Math.Round(Convert.ToDouble(textBoxTimeInput.Text), 2));
            }
            catch (FormatException)
            {
                labelInvalidTime.Visible = true;
            }
            catch (Exception e)
            {
                ErrorWindow errorWindow = new(this, e.Message);
                errorWindow.ShowDialog();
            }

            textBoxTimeInput.Clear();
            UpdateUI();
        }

        private void textBoxTimeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTime();
            }
        }

        private void numInputShift_ValueChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void checkBoxLunch_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonAddTime_Click(object sender, EventArgs e)
        {
            AddTime();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTime();
        }

        private void DeleteTime()
        {
            if (listBoxTimes.SelectedItem != null)
            {
                listBoxTimes.Items.Remove(listBoxTimes.SelectedItem);
            }

            UpdateUI();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxTimes.Items.Clear();
            UpdateUI();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new(this);
            helpWindow.ShowDialog();
        }
    }
}
