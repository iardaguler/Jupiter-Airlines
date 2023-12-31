using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaveValue()
        {
            if (comboBoxFrom.Text.Length > 0 && comboBoxTo.Text.Length > 0 && dateTimePickerDate.Text.Length > 0 && maskedTextBoxTime.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxSurname.Text.Length > 0 && textBoxIdentifyNumber.Text.Length > 0 && textBoxPhoneNumber.Text.Length > 0)
            {
                buttonSave.Enabled = true;
            }

            else
            {
                buttonSave.Enabled = false;
            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int routeNumber = 1;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            listBoxDatas.Items.Add(routeNumber + " --> " + "From " + "[" + comboBoxFrom.Text + "]" + " To " + "[" + comboBoxTo.Text + "]");
            routeNumber ++;

                 
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            string selectedFrom = comboBoxFrom.Text;
            string selectedTo = comboBoxTo.Text;

            comboBoxFrom.Text = selectedTo;
            comboBoxTo.Text = selectedFrom;
        }

        private void listBoxDatas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void maskedTextBoxTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            buttonSaveValue();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void textBoxIdentifyNumber_TextChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            buttonSaveValue();
        }
    }
}
