using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNoticeTimer
{
    public partial class Form1 : Form
    {
        private Mechanizm mechanizm;

        private void Odswierz_Liste_Przedmiotow()
        {
            comboBox_item_list.Items.Clear();            
            comboBox_item_list.Items.Add(Properties.Settings.Default.Item0);
            comboBox_item_list.Items.Add(Properties.Settings.Default.Item1);
            comboBox_item_list.Items.Add(Properties.Settings.Default.Item2);
            comboBox_item_list.Items.Add(Properties.Settings.Default.Item3);
            comboBox_item_list.Items.Add(Properties.Settings.Default.Item4);
            comboBox_item_list.SelectedIndex = 0;

        }

        public Form1()
        {
            InitializeComponent();                      
            timer1.Start();
            mechanizm = new Mechanizm();
            Odswierz_Liste_Przedmiotow();
            numericUpDown_time.Value = 14;         
        }


        private void Form1_Load(object sender, EventArgs e)        { Odswierz_Liste_Przedmiotow();   }



        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = mechanizm.Tick(checkBox_msgBox.Checked,checkBox_wycisz.Checked);     
        }

        private void button_notice_Click(object sender, EventArgs e)
        {
            string enchant = null;
            if(checkBox_enchant.Checked)
            {
                foreach(object item in checkedListBox_enchant_lvl.CheckedItems)
                {
                    enchant = item.ToString()+" ";
                }
            }
            listBox1.DataSource = null;
            listBox1.DataSource= mechanizm.DodajPrzedmiot(enchant+comboBox_item_list.SelectedItem.ToString() , (int)numericUpDown_time.Value);
            if(!checkBox_lock.Checked)
            numericUpDown_time.Value = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edycja okno_edycji = new Edycja();
            okno_edycji.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Odswierz_Liste_Przedmiotow();
        }

        private string _selectedMenuItem;

        int index;
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = listBox1.Items[index].ToString();
                contextMenuStrip1.Show(Cursor.Position);
                contextMenuStrip1.Visible = true;
            }
            else
            {
                contextMenuStrip1.Visible = false;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource= mechanizm.usun(index);
        }

        private void checkBox_enchant_CheckedChanged(object sender, EventArgs e)
        {
            zmiana_szerokosci();
            checkedListBox_enchant_lvl.SetItemChecked(0, true);
        }
        private void zmiana_szerokosci()
        {
            if (checkBox_enchant.Checked)
            {
                Form1.ActiveForm.Width = 325;
            }
            else
                Form1.ActiveForm.Width = 225;
        }

        private void checkedListBox_enchant_lvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_enchant_lvl_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue != CheckState.Checked)
            {                
                return;
            }
            if (e.NewValue == CheckState.Checked)                
                for (int ix = 0; ix < checkedListBox_enchant_lvl.Items.Count; ++ix)
                    if (e.Index != ix) checkedListBox_enchant_lvl.SetItemChecked(ix, false);

        }

        private void checkedListBox_enchant_lvl_Click(object sender, EventArgs e)
        {
            checkedListBox_enchant_lvl.SetItemChecked(checkedListBox_enchant_lvl.SelectedIndex, false);
        }
    }
}
