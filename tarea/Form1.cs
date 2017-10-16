using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textbox.Text == string.Empty)
                MessageBox.Show("cadena vacia", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                this.label1.Text = this.textbox.Text;
                this.textbox.Text = string.Empty;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Strikeout);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Underline);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 12, label1.Font.Style);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 14, label1.Font.Style);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 16, label1.Font.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea salir de la aplicacion?", "salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 18, label1.Font.Style);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 20, label1.Font.Style);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 22, label1.Font.Style);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
        }

    }
}