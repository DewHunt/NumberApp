using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberApp
{
    public partial class NumberUI : Form
    {
        public NumberUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);
            numberListBox.Items.Clear();

            for (int i = 0; i <= number; i++)
            {
                numberListBox.Items.Add(i);
            }
        }

        private void numberListBox_Click(object sender, EventArgs e)
        {
            string show = numberListBox.SelectedItem.ToString();     
            MessageBox.Show(show);
        }
    }
}
