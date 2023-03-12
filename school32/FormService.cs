using school32.Model;
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
    public partial class FormService : Form
    {
        private List<Service> services;
        private bool Sort = true;
        private List<Service> temp=new List<Service>();
        public FormService(string role)
        {
            InitializeComponent();
            using (ModelDB db=new ModelDB())
            {
                services=db.Service.ToList();          
            }
            temp.AddRange(services);
            labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
            dataGridViewServices.DataSource = temp;
            dataGridViewServices.Columns[3].Visible = false;
            dataGridViewServices.Columns[5].Visible = false;
            if(role=="User")
            {
                buttonAdd.Visible = false;
                buttonDel.Visible = false;
                buttonRecordService.Visible = false;
            }
            comboBoxDiscont.SelectedIndex = 5;
        }

        private void dataGridViewServices_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sort = !Sort;
            if(e.ColumnIndex==1)
            {
                dataGridViewServices.DataSource = null;
                if (Sort)
                {
                    temp = temp.OrderBy(p => p.Cost).ToList();
                    dataGridViewServices.DataSource = temp;
                }
                else
                    temp = temp.OrderByDescending(p => p.Cost).ToList();
                    dataGridViewServices.DataSource = temp;
            }

        }

        private void comboBoxDiscont_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewServices.DataSource = null;
            switch (comboBoxDiscont.SelectedIndex) 
            {
                case 0:
                    temp = services.Where(p => p.Discount >= 0 && p.Discount < 0.05).ToList();
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
                case 1:
                    temp=services.Where(p => p.Discount >= 0.05 && p.Discount < 0.15).ToList();
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
                case 2:
                    temp = services.Where(p => p.Discount >= 0.15 && p.Discount < 0.3).ToList();
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
                case 3:
                    temp = services.Where(p => p.Discount >= 0.3 && p.Discount < 0.7).ToList();
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
                case 4:
                    temp = services.Where(p => p.Discount >= 0.7 && p.Discount < 1).ToList();
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
                default:
                    temp = services;
                    labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
                    dataGridViewServices.DataSource = temp;
                    break;
            }
            dataGridViewServices.Columns[3].Visible = false;
            dataGridViewServices.Columns[5].Visible = false;
        }

        private void textBoxSearchTitle_TextChanged(object sender, EventArgs e)
        {
            dataGridViewServices.DataSource = null;
            temp = services.Where(p => p.Title.StartsWith(textBoxSearchTitle.Text)).ToList();
            labelRecords.Text = "Записей " + temp.Count + " из " + services.Count;
            dataGridViewServices.DataSource = temp;
            dataGridViewServices.Columns[3].Visible = false;
            dataGridViewServices.Columns[5].Visible = false;
        }

        private void textBoxSearchDesc_TextChanged(object sender, EventArgs e)
        {
            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = services.Where(p => p.Description.StartsWith(textBoxSearchDesc.Text)).ToList();
            dataGridViewServices.Columns[3].Visible = false;
            dataGridViewServices.Columns[5].Visible = false;
        }
    }
}
