using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class InputForm : Form
    {
        //properties
        private string OldValue;
        private bool ResetValue = true;
        public string Value { get; set; } //return value of this form

        public InputForm(string currentValue)
        {
            InitializeComponent();

            //set the values
            OldValue = currentValue;
            txtInput.Text = currentValue;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //set the "Value" based on text of txtInput
            Value = txtInput.Text;
            ResetValue = false;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //reset the value
            Value = OldValue;
            Close();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BUGFIX ========> Manually closing the form should reset to OldValue if "OK" button is not clicked
            if (ResetValue)
                Value = OldValue;
        }
    }
}
