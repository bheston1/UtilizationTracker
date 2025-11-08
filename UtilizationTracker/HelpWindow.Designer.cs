namespace UtilizationTracker
{
    partial class HelpWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            labelInformation = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelInformation
            // 
            labelInformation.Location = new Point(0, -10);
            labelInformation.Name = "labelInformation";
            labelInformation.Padding = new Padding(24);
            labelInformation.Size = new Size(505, 174);
            labelInformation.TabIndex = 0;
            labelInformation.Text = resources.GetString("labelInformation.Text");
            labelInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.Location = new Point(215, 132);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 27);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "OK";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 174);
            Controls.Add(buttonClose);
            Controls.Add(labelInformation);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            FormClosed += HelpWindow_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label labelInformation;
        private Button buttonClose;
    }
}