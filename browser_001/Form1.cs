using System;
using System.Windows.Forms;


namespace browser_001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.google.com/");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                this.webBrowser1.Navigate(textBox1.Text);
            }
        }
    }
}
