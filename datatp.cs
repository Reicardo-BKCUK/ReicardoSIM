using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
namespace Project1
{
    public partial class datatp : System.Windows.Forms.Form
    {

        public datatp()
        {
            vb6Globals.datatp = this;
            InitializeComponent();
        }

        private void Command1_Click(System.Object _sender, System.EventArgs _e1) 
        {
            Adodc1.Recordset.Find("No_TP='" + Text1.Text + "'", nce.adodb.SearchDirection.adSearchForward, 1);
            if (!(Adodc1.Recordset.Eof))
            {
                MessageBox.Show("Kode TP sudah ada sebelumnya atau nomor urut telah ada sebelumnya", "Project1");
            }
            else
            {
                if (Text1.Text == "" || Text2.Text == "" || Text3.Text == "")
                {
                    MessageBox.Show("Data Kurang Lengkap", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text1.Focus();
                }
                else
                {
                    Adodc1.Recordset.AddNew();
                    Adodc1.Recordset.Fields["No_TP"].Value = Text1.Text;
                    Adodc1.Recordset.Fields["Nama_TP"].Value = Text2.Text;
                    Adodc1.Recordset.Fields["alamat"].Value = Text3.Text;
                    Adodc1.Recordset.Update();
                    Text1.Focus();
                    Text1.Text = "";
                    Text2.Text = "";
                    Text3.Text = "";
                    Command2.Enabled = false;
                    Command1.Enabled = true;
                }
            }
            Adodc1.Refresh();
            TDBGrid1.Refresh();
        }

        private void Command2_Click(System.Object _sender, System.EventArgs _e1) 
        {
            Adodc1.Recordset.Find("No_TP='" + Text1.Text + "'", nce.adodb.SearchDirection.adSearchForward, 1);
            if (!(Adodc1.Recordset.Eof))
            {
                MessageBox.Show("Kode TP sudah ada sebelumnya atau nomor urut telah ada sebelumnya", "Project1");
            }
            else
            {
                if (Text1.Text == "" || Text2.Text == "" || Text3.Text == "")
                {
                    MessageBox.Show("Data Kurang Lengkap", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text1.Focus();
                }
                else
                {
                    Adodc1.Recordset.Fields["No_TP"].Value = Text1.Text;
                    Adodc1.Recordset.Fields["Nama_TP"].Value = Text2.Text;
                    Adodc1.Recordset.Fields["alamat"].Value = Text3.Text;
                    Adodc1.Recordset.Update();
                    Adodc1.Refresh();
                    TDBGrid1.Refresh();
                    Text1.Text = "";
                    Text2.Text = "";
                    Text3.Text = "";
                    Command2.Enabled = false;
                    Command1.Enabled = true;
                }
            }
        }

        private void Command3_Click(System.Object _sender, System.EventArgs _e1) 
        {
            if (Adodc1.Recordset.RecordCount == 0)
            {
                MessageBox.Show("Data Tidak Ada", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Adodc1.Recordset.Delete();
                Adodc1.Recordset.Update();
                Adodc1.Refresh();
                TDBGrid1.Refresh();
                Text1.Focus();
            }
        }

        private void Command4_Click(System.Object _sender, System.EventArgs _e1) 
        {
            this.Close();
        }

        private void Form_Load(System.Object _sender, System.EventArgs _e1) 
        {
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Command2.Enabled = false;
        }

        private void TDBGrid1_Click(System.Object _sender, System.EventArgs _e1) 
        {
            if (Adodc1.Recordset.RecordCount == 0)
            {
                MessageBox.Show("Data Tidak Ada", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Text1.Text = Adodc1.Recordset.Fields["No_TP"].Value;
                Text2.Text = Adodc1.Recordset.Fields["Nama_TP"].Value;
                Text3.Text = Adodc1.Recordset.Fields["Alamat"].Value;
                Command1.Enabled = false;
                Command2.Enabled = true;
            }
        }


    }

}
