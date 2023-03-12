using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school32
{
    public partial class FormMode : Form
    {
        public FormMode()
        {
            InitializeComponent();
        }

        private void buttonModeAdmin_Click(object sender, EventArgs e)
        {
            FormAuturize formAuturize = new FormAuturize();
            formAuturize.Show();
        }

        private void buttonModeUser_Click(object sender, EventArgs e)
        {
            FormService formService = new FormService("User");
            formService.Show();
        }
    }
}
