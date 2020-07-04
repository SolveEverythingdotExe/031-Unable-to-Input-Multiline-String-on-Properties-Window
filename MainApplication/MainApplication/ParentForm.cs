using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class ParentForm : Form
    {
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string SQLCommandText { get; set; }

        public ParentForm()
        {
            InitializeComponent();
        }
        //lets build and test
    }
}
