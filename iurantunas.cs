using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
namespace Project1
{
    public partial class iurantunas : System.Windows.Forms.Form
    {

        public iurantunas()
        {
            vb6Globals.iurantunas = this;
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new iurantunas());
        }

// VB6TOCS evaluation version can only convert the VB6 file whose lines are less than 500 lines, the lines of this VB file is 2382 lines. please purchse the final version to avoid the limitation.
    }

}
