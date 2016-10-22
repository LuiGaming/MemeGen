using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        MessageBox.Show("This meme is a meme.", "Your Meme", MessageBoxButtons.OK);
        DialogResult result1 = MessageBox.Show("Now do you think that was a a good meme", "Feedback", MessageBoxButtons.YesNo);
        if (result1 == DialogResult.Yes)
            MessageBox.Show("Fawntasic!", "good job m8");
        else
            MessageBox.Show("Wow. Just Wow.", "u spuid.");
        MessageBox.Show("Thanks for using this program.", "THANNNNKSSSS!");
        MessageBox.Show("A new and legit working Meme Gen will be coming soon! not a troll like this", "IMPROVED NON-TROLL COMING SOONNNN!!!");

        }

        private void thememe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
