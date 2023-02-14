using Habits.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Habits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1 && listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if (listBox1.Items.Count == 1 && listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Congrats! You have completed all your daily tasks.");
            }
            else if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0)
            {
                MessageBox.Show("Use the textbox and 'Add' button below to add new activies.");
            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Congrats! You have completed all your daily tasks.");
            }

        }
        private void UndoneButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {   
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem); 
            }
        }
        private void ResButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }  
        
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CompleteButton_Click(sender, e);
            }
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                CompleteButton_Click(sender, e);
            }
        }
        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                UndoneButton_Click(sender, e);   
            }
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                UndoneButton_Click(sender, e);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (!(listBox1.Items.Contains(textBox1.Text)))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = null;
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("This activity is already included in the list.");
                    textBox1.Text = null;
                    textBox1.Select();
                }
            }
            else
            {
                MessageBox.Show("Type an activity in the textbox above.");
                textBox1.Select();
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton_Click(sender, e);
                e.SuppressKeyPress= true;
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var newList = new ArrayList();
            foreach (object item in listBox1.Items)
            {
                newList.Add(item);
            }
            Properties.Settings1.Default.listboxItems = newList;
            Properties.Settings1.Default.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Properties.Settings1.Default.listboxItems.ToArray());
        }
    }
}
