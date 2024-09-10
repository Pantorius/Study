namespace HelloWorld
{
    partial class MainFormWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormWindow));
            HelloWorldButton = new Button();
            ButtonAnswer = new Button();
            SuspendLayout();
            // 
            // HelloWorldButton
            // 
            HelloWorldButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HelloWorldButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HelloWorldButton.Font = new Font("FirebugRUS", 62F, FontStyle.Underline, GraphicsUnit.Point);
            HelloWorldButton.ForeColor = SystemColors.HotTrack;
            HelloWorldButton.Location = new Point(188, 127);
            HelloWorldButton.MinimumSize = new Size(273, 185);
            HelloWorldButton.Name = "HelloWorldButton";
            HelloWorldButton.Size = new Size(273, 186);
            HelloWorldButton.TabIndex = 0;
            HelloWorldButton.Text = "Привет Мир!";
            HelloWorldButton.UseVisualStyleBackColor = true;
            HelloWorldButton.Click += HelloWorldButton_Click;
            // 
            // ButtonAnswer
            // 
            ButtonAnswer.BackColor = SystemColors.Control;
            ButtonAnswer.Dock = DockStyle.Fill;
            ButtonAnswer.FlatAppearance.BorderColor = Color.White;
            ButtonAnswer.FlatAppearance.BorderSize = 0;
            ButtonAnswer.FlatStyle = FlatStyle.Flat;
            ButtonAnswer.Font = new Font("Georgia", 63.75F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAnswer.ForeColor = Color.Black;
            ButtonAnswer.Location = new Point(0, 0);
            ButtonAnswer.Name = "ButtonAnswer";
            ButtonAnswer.Size = new Size(667, 437);
            ButtonAnswer.TabIndex = 1;
            ButtonAnswer.Text = "И мир ответил: \"Здравствуй!\"";
            ButtonAnswer.UseVisualStyleBackColor = false;
            ButtonAnswer.Visible = false;
            ButtonAnswer.Click += ButtonAnswer_Click;
            // 
            // MainFormWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 437);
            Controls.Add(ButtonAnswer);
            Controls.Add(HelloWorldButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(683, 476);
            Name = "MainFormWindow";
            Text = "Привет Мир!";
            Load += MainFormWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button HelloWorldButton;
        private Button ButtonAnswer;
    }
}
