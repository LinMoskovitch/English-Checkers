using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class FormWelcome : Form
    {
        private readonly FormProperties r_FormProperties;
        private readonly FormRules r_FormRules;
        public FormWelcome()
        {
            InitializeComponent();
            r_FormProperties = new FormProperties();
            r_FormRules = new FormRules();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            r_FormRules.ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            r_FormProperties.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}