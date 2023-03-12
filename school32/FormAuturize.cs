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
    public partial class FormAuturize : Form
    {
        public FormAuturize()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text=="0000")
            {
                FormService formService = new FormService("Admin");
                formService.Show();
                this.Hide();
            }
        }
    }
}
