using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNoticeTimer
{
    public partial class Edycja : Form
    {
        
        public Edycja()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.Item0;
            textBox2.Text = Properties.Settings.Default.Item1;
            textBox3.Text = Properties.Settings.Default.Item2;
            textBox4.Text = Properties.Settings.Default.Item3;
            textBox5.Text = Properties.Settings.Default.Item4;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Properties.Settings.Default.Item0 = textBox1.Text;   
                Properties.Settings.Default.Item1 = textBox2.Text;       
                Properties.Settings.Default.Item2 = textBox3.Text;          
                Properties.Settings.Default.Item3 = textBox4.Text; 
                Properties.Settings.Default.Item4 = textBox5.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
