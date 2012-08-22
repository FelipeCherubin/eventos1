using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("erro", "nao tem nada o textebox");
            }
            else
                MessageBox.Show("voce dejasa bacon", textBox1.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Label_clihuahuaa(object se, EventArgs avt)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox texto = (TextBox)sender;
                if (texto.BackColor == SystemColors.Window)
                {
                    texto.BackColor = SystemColors.Info;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox texto = (TextBox)sender;
                texto.BackColor = SystemColors.Window;
            }
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            button1.DoDragDrop(button1.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void button1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
        }

        private void button2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Move;
        }

        private void button2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            button2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
