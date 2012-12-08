using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class ChildForm2 : Form
    {
        public ChildForm2()
        {
            InitializeComponent();
            stylesSheetManager.ApplyStyles();
        }
    }
}