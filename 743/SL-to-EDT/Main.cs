using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL_to_EDT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            textBox.Text = dateTimePicker.Value.Subtract(new TimeSpan(9, 30, 0)).ToShortTimeString();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = dateTimePicker.Value.Subtract(new TimeSpan(9, 30, 0)).ToShortTimeString();
        }
    }
}
