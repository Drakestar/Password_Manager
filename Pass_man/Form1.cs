using System;
using System.Windows.Forms;

namespace Pass_man
{
    public partial class MainForm : Form
    {
        private static string cur_website = "google";
        private static string cur_username;
        private static string cur_password;

        public MainForm()
        {
            InitializeComponent();
        }


            //textBox3.Text = Encryption.EncryptString(Master_Password.Text, textBox2.Text);

            //textBox3.Text = Encryption.DecryptString(Master_Password.Text, textBox2.Text);

        private void open_site(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www." + cur_website + ".com");
        }

        private void copy_username(object sender, EventArgs e)
        {
            Clipboard.SetText("Hello, clipboard");
        }

        private void copy_password(object sender, EventArgs e)
        {
            Clipboard.SetText("Hello, clipboard");
        }
    }
}
