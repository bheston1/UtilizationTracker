namespace UtilizationTracker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            textBoxTimeInput = new TextBox();
            listBoxTimes = new ListBox();
            buttonAddTime = new Button();
            groupBox1 = new GroupBox();
            numInputShift = new NumericUpDown();
            buttonDelete = new Button();
            buttonClear = new Button();
            labelShift = new Label();
            checkBoxLunch = new CheckBox();
            panel1 = new Panel();
            labelInvalidTime = new Label();
            labelPercent = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonHelp = new Button();
            labelOverDiff = new Label();
            labelResult = new Label();
            labelTotal = new Label();
            labelGoal = new Label();
            labelVersion = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInputShift).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTimeInput
            // 
            textBoxTimeInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxTimeInput.Location = new Point(160, 26);
            textBoxTimeInput.Margin = new Padding(4);
            textBoxTimeInput.MaxLength = 4;
            textBoxTimeInput.Name = "textBoxTimeInput";
            textBoxTimeInput.Size = new Size(135, 27);
            textBoxTimeInput.TabIndex = 0;
            textBoxTimeInput.TabStop = false;
            textBoxTimeInput.TextAlign = HorizontalAlignment.Center;
            textBoxTimeInput.KeyDown += textBoxTimeInput_KeyDown;
            // 
            // listBoxTimes
            // 
            listBoxTimes.BorderStyle = BorderStyle.FixedSingle;
            listBoxTimes.Dock = DockStyle.Fill;
            listBoxTimes.FormattingEnabled = true;
            listBoxTimes.ItemHeight = 19;
            listBoxTimes.Location = new Point(3, 23);
            listBoxTimes.Margin = new Padding(4);
            listBoxTimes.Name = "listBoxTimes";
            listBoxTimes.Size = new Size(144, 174);
            listBoxTimes.TabIndex = 1;
            listBoxTimes.TabStop = false;
            // 
            // buttonAddTime
            // 
            buttonAddTime.Cursor = Cursors.Hand;
            buttonAddTime.Location = new Point(160, 60);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new Size(135, 27);
            buttonAddTime.TabIndex = 2;
            buttonAddTime.TabStop = false;
            buttonAddTime.Text = "Add time";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += buttonAddTime_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxTimes);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 200);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Times";
            // 
            // numInputShift
            // 
            numInputShift.BorderStyle = BorderStyle.FixedSingle;
            numInputShift.Location = new Point(3, 3);
            numInputShift.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numInputShift.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInputShift.Name = "numInputShift";
            numInputShift.Size = new Size(50, 27);
            numInputShift.TabIndex = 4;
            numInputShift.TabStop = false;
            numInputShift.TextAlign = HorizontalAlignment.Center;
            numInputShift.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numInputShift.ValueChanged += numInputShift_ValueChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Location = new Point(160, 140);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 27);
            buttonDelete.TabIndex = 5;
            buttonDelete.TabStop = false;
            buttonDelete.Text = "Delete selected";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.Location = new Point(160, 173);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(135, 27);
            buttonClear.TabIndex = 6;
            buttonClear.TabStop = false;
            buttonClear.Text = "Clear times";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelShift
            // 
            labelShift.AutoSize = true;
            labelShift.Location = new Point(59, 5);
            labelShift.Name = "labelShift";
            labelShift.Size = new Size(100, 19);
            labelShift.TabIndex = 7;
            labelShift.Text = "<- Shift length";
            // 
            // checkBoxLunch
            // 
            checkBoxLunch.AutoSize = true;
            checkBoxLunch.Checked = true;
            checkBoxLunch.CheckState = CheckState.Checked;
            checkBoxLunch.Cursor = Cursors.Hand;
            checkBoxLunch.Location = new Point(3, 36);
            checkBoxLunch.Name = "checkBoxLunch";
            checkBoxLunch.Size = new Size(105, 23);
            checkBoxLunch.TabIndex = 8;
            checkBoxLunch.TabStop = false;
            checkBoxLunch.Text = "Lunch taken";
            checkBoxLunch.UseVisualStyleBackColor = true;
            checkBoxLunch.CheckedChanged += checkBoxLunch_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelInvalidTime);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBoxTimeInput);
            panel1.Controls.Add(buttonAddTime);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonDelete);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 208);
            panel1.TabIndex = 9;
            // 
            // labelInvalidTime
            // 
            labelInvalidTime.AutoSize = true;
            labelInvalidTime.ForeColor = Color.Red;
            labelInvalidTime.Location = new Point(160, 3);
            labelInvalidTime.Name = "labelInvalidTime";
            labelInvalidTime.Size = new Size(85, 19);
            labelInvalidTime.TabIndex = 7;
            labelInvalidTime.Text = "Invalid time";
            labelInvalidTime.Visible = false;
            // 
            // labelPercent
            // 
            labelPercent.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPercent.ForeColor = Color.Red;
            labelPercent.Location = new Point(3, 180);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(70, 23);
            labelPercent.TabIndex = 13;
            labelPercent.Text = "XX%";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelPercent);
            panel2.Controls.Add(buttonHelp);
            panel2.Controls.Add(labelOverDiff);
            panel2.Controls.Add(labelResult);
            panel2.Controls.Add(labelTotal);
            panel2.Controls.Add(labelGoal);
            panel2.Controls.Add(numInputShift);
            panel2.Controls.Add(labelShift);
            panel2.Controls.Add(checkBoxLunch);
            panel2.Location = new Point(321, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 208);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 157);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 14;
            label1.Text = "Utilization %:";
            // 
            // buttonHelp
            // 
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Location = new Point(144, 176);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(30, 27);
            buttonHelp.TabIndex = 7;
            buttonHelp.TabStop = false;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelOverDiff
            // 
            labelOverDiff.AutoSize = true;
            labelOverDiff.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOverDiff.ForeColor = Color.Green;
            labelOverDiff.Location = new Point(3, 125);
            labelOverDiff.Name = "labelOverDiff";
            labelOverDiff.Size = new Size(45, 19);
            labelOverDiff.TabIndex = 12;
            labelOverDiff.Text = "+0.00";
            labelOverDiff.Visible = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(3, 106);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(151, 19);
            labelResult.TabIndex = 11;
            labelResult.Text = "Time remaining: 0.00";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(3, 87);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(127, 19);
            labelTotal.TabIndex = 10;
            labelTotal.Text = "Current total: 0.00";
            // 
            // labelGoal
            // 
            labelGoal.AutoSize = true;
            labelGoal.Location = new Point(3, 68);
            labelGoal.Name = "labelGoal";
            labelGoal.Size = new Size(75, 19);
            labelGoal.TabIndex = 9;
            labelGoal.Text = "Goal: 0.00";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVersion.Location = new Point(456, 223);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(43, 17);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "v1.1.0";
            labelVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 245);
            Controls.Add(labelVersion);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilization Tracker";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numInputShift).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTimeInput;
        private ListBox listBoxTimes;
        private Button buttonAddTime;
        private GroupBox groupBox1;
        private NumericUpDown numInputShift;
        private Button buttonDelete;
        private Button buttonClear;
        private Label labelShift;
        private CheckBox checkBoxLunch;
        private Panel panel1;
        private Panel panel2;
        private Label labelGoal;
        private Label labelTotal;
        private Label labelOverDiff;
        private Label labelResult;
        private Button buttonHelp;
        private Label labelInvalidTime;
        private Label labelVersion;
        private Label labelPercent;
        private Label label1;
    }
}
