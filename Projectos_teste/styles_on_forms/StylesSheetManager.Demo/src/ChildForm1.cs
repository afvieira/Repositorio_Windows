using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class ChildForm1 : Form
    {
        public ChildForm1()
        {
            InitializeComponent();
            stylesSheetManager.ApplyStyles();
        }
    }
}