using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Helper_2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewProject createNewProject = new CreateNewProject();
            this.Hide();
            createNewProject.Closed += (s, args) => this.Close();
            createNewProject.Show();
        }
    }
}
