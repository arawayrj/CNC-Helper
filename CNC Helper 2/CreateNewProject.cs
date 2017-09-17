using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Helper_2
{
    public partial class CreateNewProject : Form
    {
        public CreateNewProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, "[ ^ 0-9]"))
            {
                WorkForm wf = new WorkForm();
                //TODO: Add code to set attributes to user's name and program number
                this.Hide();
                wf.Closed += (s, args) => this.Close();
                wf.Show();
            } else
            {
                MessageBox.Show("Please make sure the program number is only numbers.");
            }
        }
    }
}
