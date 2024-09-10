namespace HelloWorld
{
    public partial class MainFormWindow : Form
    {
        public MainFormWindow()
        {
            InitializeComponent();
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
            ButtonAnswer.Visible = true;
        }

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormWindow_Load(object sender, EventArgs e)
        {
            List<String> Locale = new List<string>() { "Hello World!", "And the world answered: \"Hello!\"" };
            if (System.Globalization.CultureInfo.CurrentCulture.ToString() != "ru-RU")
            {
                this.Text = Locale[0];
                HelloWorldButton.Text = Locale[0];
                ButtonAnswer.Text = Locale[1];
            }
            
        }
    }
}
