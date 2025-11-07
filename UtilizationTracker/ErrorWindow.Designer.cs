namespace UtilizationTracker
{
    partial class ErrorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
            label1 = new Label();
            textBoxErrorMsg = new TextBox();
            labelShowHide = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(126, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 65);
            label1.TabIndex = 0;
            label1.Text = "An unexpected error occured.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxErrorMsg
            // 
            textBoxErrorMsg.BorderStyle = BorderStyle.FixedSingle;
            textBoxErrorMsg.Enabled = false;
            textBoxErrorMsg.Location = new Point(12, 124);
            textBoxErrorMsg.Multiline = true;
            textBoxErrorMsg.Name = "textBoxErrorMsg";
            textBoxErrorMsg.ReadOnly = true;
            textBoxErrorMsg.ScrollBars = ScrollBars.Vertical;
            textBoxErrorMsg.Size = new Size(406, 82);
            textBoxErrorMsg.TabIndex = 2;
            textBoxErrorMsg.TabStop = false;
            textBoxErrorMsg.Visible = false;
            // 
            // labelShowHide
            // 
            labelShowHide.AutoSize = true;
            labelShowHide.Cursor = Cursors.Hand;
            labelShowHide.Font = new Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelShowHide.ForeColor = SystemColors.Highlight;
            labelShowHide.Location = new Point(12, 103);
            labelShowHide.Name = "labelShowHide";
            labelShowHide.Size = new Size(91, 19);
            labelShowHide.TabIndex = 3;
            labelShowHide.Text = "Show details";
            labelShowHide.MouseClick += labelShowHide_MouseClick;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(177, 65);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 27);
            buttonClose.TabIndex = 4;
            buttonClose.TabStop = false;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // ErrorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 131);
            Controls.Add(buttonClose);
            Controls.Add(labelShowHide);
            Controls.Add(label1);
            Controls.Add(textBoxErrorMsg);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            FormClosed += ErrorWindow_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxErrorMsg;
        private Label labelShowHide;
        private Button buttonClose;
    }
}