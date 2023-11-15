namespace BetterWinFormsDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            sayHelloButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.ForeColor = SystemColors.ButtonFace;
            firstNameLabel.Location = new Point(43, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(138, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "License Key";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // firstNameText
            // 
            firstNameText.BackColor = SystemColors.HighlightText;
            firstNameText.ForeColor = SystemColors.ActiveCaptionText;
            firstNameText.Location = new Point(43, 92);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(203, 39);
            firstNameText.TabIndex = 1;
            firstNameText.TextChanged += firstNameText_TextChanged;
            // 
            // sayHelloButton
            // 
            sayHelloButton.BackColor = Color.White;
            sayHelloButton.ForeColor = SystemColors.ActiveCaptionText;
            sayHelloButton.ImageAlign = ContentAlignment.TopLeft;
            sayHelloButton.Location = new Point(63, 202);
            sayHelloButton.Name = "sayHelloButton";
            sayHelloButton.RightToLeft = RightToLeft.Yes;
            sayHelloButton.Size = new Size(154, 49);
            sayHelloButton.TabIndex = 3;
            sayHelloButton.Text = "Login";
            sayHelloButton.UseVisualStyleBackColor = false;
            sayHelloButton.Click += sayHelloButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._68747470733a2f2f692e6962622e636f2f67467752426b642f6c6f6c68756d616e2e706e67;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(281, 292);
            Controls.Add(sayHelloButton);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Bloo Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Button sayHelloButton;
    }
}