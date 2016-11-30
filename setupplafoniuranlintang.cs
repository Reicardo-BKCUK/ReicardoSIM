using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
namespace Project1
{
    public partial class setupplafoniuranlintang : System.Windows.Forms.Form
    {

        public setupplafoniuranlintang()
        {
            vb6Globals.setupplafoniuranlintang = this;
            InitializeComponent();
        }

        private void tampil() 
        {
            Text1.Text = Adodc1.Recordset.Fields["pengali"].Value;
            Text2.Text = Adodc1.Recordset.Fields["plafonlintang1"].Value;
            Text3.Text = Adodc1.Recordset.Fields["plafonlintang2"].Value;
            Text4.Text = Adodc1.Recordset.Fields["plafonlintang3"].Value;
            Text5.Text = Adodc1.Recordset.Fields["plafonlintang4"].Value;
        }

        private void Command1_Click(System.Object _sender, System.EventArgs _e1) 
        {
            if (Text1.Text == "" || Text2.Text == "" || Text3.Text == "" || Text4.Text == "" || Text5.Text == "" || Text1.Text == "0" || Text2.Text == "0" || Text3.Text == "0" || Text4.Text == "0" || Text5.Text == "0")
            {
                MessageBox.Show("Data Belum Lengkap", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Adodc1.Recordset.Fields["pengali"].Value = Text1.Text;
                Adodc1.Recordset.Fields["plafonlintang1"].Value = Text2.Text;
                Adodc1.Recordset.Fields["plafonlintang2"].Value = Text3.Text;
                Adodc1.Recordset.Fields["plafonlintang3"].Value = Text4.Text;
                Adodc1.Recordset.Fields["plafonlintang4"].Value = Text5.Text;
                Adodc1.Recordset.Update();
                Adodc1.Refresh();
                TDBGrid1.Refresh();
            }
            tampil();
        }

        private void Command2_Click(System.Object _sender, System.EventArgs _e1) 
        {
            this.Close();
        }

        private void Form_Load(System.Object _sender, System.EventArgs _e1) 
        {
            tampil();
        }

        private void Text2_KeyPress(System.Object _sender, System.Windows.Forms.KeyPressEventArgs _e1) 
        {
            int KeyAscii = (short)(_e1.KeyChar);
            if (!((KeyAscii >= (short)("0"[0]) && KeyAscii <= (short)("9"[0]) || KeyAscii == Keys.Back || KeyAscii == Keys.KeyDelete || KeyAscii == Keys.Space || KeyAscii == Keys.Return)))
            {
                MessageBox.Show("Maaf Hanya Boleh Diisi Angka Saja", "Perhatian",  MessageBoxButtons.OK, MessageBoxIcon.Information );
                KeyAscii = 0;
                Text2.Focus();
            }
        }

        private void Text3_KeyPress(System.Object _sender, System.Windows.Forms.KeyPressEventArgs _e1) 
        {
            int KeyAscii = (short)(_e1.KeyChar);
            if (!((KeyAscii >= (short)("0"[0]) && KeyAscii <= (short)("9"[0]) || KeyAscii == Keys.Back || KeyAscii == Keys.KeyDelete || KeyAscii == Keys.Space || KeyAscii == Keys.Return)))
            {
                MessageBox.Show("Maaf Hanya Boleh Diisi Angka Saja", "Perhatian",  MessageBoxButtons.OK, MessageBoxIcon.Information );
                KeyAscii = 0;
                Text3.Focus();
            }
        }

        private void Text4_KeyPress(System.Object _sender, System.Windows.Forms.KeyPressEventArgs _e1) 
        {
            int KeyAscii = (short)(_e1.KeyChar);
            if (!((KeyAscii >= (short)("0"[0]) && KeyAscii <= (short)("9"[0]) || KeyAscii == Keys.Back || KeyAscii == Keys.KeyDelete || KeyAscii == Keys.Space || KeyAscii == Keys.Return)))
            {
                MessageBox.Show("Maaf Hanya Boleh Diisi Angka Saja", "Perhatian",  MessageBoxButtons.OK, MessageBoxIcon.Information );
                KeyAscii = 0;
                Text4.Focus();
            }
        }

        private void Text5_KeyPress(System.Object _sender, System.Windows.Forms.KeyPressEventArgs _e1) 
        {
            int KeyAscii = (short)(_e1.KeyChar);
            if (!((KeyAscii >= (short)("0"[0]) && KeyAscii <= (short)("9"[0]) || KeyAscii == Keys.Back || KeyAscii == Keys.KeyDelete || KeyAscii == Keys.Space || KeyAscii == Keys.Return)))
            {
                MessageBox.Show("Maaf Hanya Boleh Diisi Angka Saja", "Perhatian",  MessageBoxButtons.OK, MessageBoxIcon.Information );
                KeyAscii = 0;
                Text5.Focus();
            }
        }


    }

}
