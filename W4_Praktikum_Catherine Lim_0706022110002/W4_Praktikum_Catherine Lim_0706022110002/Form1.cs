using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_Praktikum_Catherine_Lim_0706022110002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxKoleksi.Items.Contains (textBoxData.Text))
            {
                MessageBox.Show("Sudah ada Data yang Diinput");
            }
            else
            {
                listBoxKoleksi.Items.Add(textBoxData.Text);
            }
            textBoxData.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        { 
            radioButtonBiru.Checked = false;
            radioButtonMerah.Checked = false;
            checkBoxAktif.Checked = false;
            labelHasilOutput.ForeColor = Color.Black;
            labelHasilOutput.Text = "";
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBiru.Enabled = true;
            radioButtonMerah.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonBiru.Enabled = false;
            radioButtonMerah.Enabled = false;
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            labelHasilOutput.ForeColor = Color.Red;
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            labelHasilOutput.ForeColor = Color.Blue;
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasilOutput.Text = listBoxKoleksi.Text;
        }
    }
}
