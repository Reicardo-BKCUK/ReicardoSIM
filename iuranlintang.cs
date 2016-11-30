using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
namespace Project1
{
    public partial class iuranlintang : System.Windows.Forms.Form
    {

        public iuranlintang()
        {
            vb6Globals.iuranlintang = this;
            InitializeComponent();
        }

        // ==============================================
        // validasi plafon
        // ==============================================
        private void plafon1760() 
        {
            dynamic Text27 = null;
            dynamic Text12 = null;
            dynamic Adodc1 = null;
            dynamic Text13 = null;
            dynamic Text14 = null;
            dynamic Text21 = null;
            if (Text27.Text > 16 && Text27.Text < 61)
            {
                // ISSUE: Unknown object type: Adodc1
                Text12.Text = Adodc1.Recordset.Fields("plafonlintang1");
                Text13.Text = "0";
                Text14.Text = "0";
                Text21.Text = "0";
            }
            else
            {
                if (Text27.Text > 60 && Text27.Text < 71)
                {
                    Text12.Text = "0";
                    // ISSUE: Unknown object type: Adodc1
                    Text13.Text = Adodc1.Recordset.Fields("plafonlintang2");
                    Text14.Text = "0";
                    Text21.Text = "0";
                }
                else
                {
                    if (Text27.Text > 71)
                    {
                        Text12.Text = "0";
                        Text13.Text = "0";
                        // ISSUE: Unknown object type: Adodc1
                        Text14.Text = Adodc1.Recordset.Fields("plafonlintang3");
                        Text21.Text = "0";
                    }
                    else
                    {
                        Text12.Text = "0";
                        Text13.Text = "0";
                        Text14.Text = "0";
                        Text21.Text = "0";
                    }
                }
            }
        }

        // ==============================================
        // ==============================================
        // ==============================================
        // validasi tanggal
        // ==============================================
        private void tanggalbergabung() 
        {
            string X = String.Empty;
            dynamic DTPicker1 = null;
            dynamic DTPicker2 = null;
            dynamic Text8 = null;
            X = Convert.ToString(DateAndTime.DateDiff("d", DTPicker1.Value, DTPicker2.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Bergabung Harus Lebih Besar Dari Tanggal Lahir", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker2.Value = DTPicker1.Value;
            }
            else
            {
                Text8.Text = DateAndTime.DateDiff("yyyy", DTPicker1.Value, DTPicker2.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System);
            }
        }

        private void tanggalpencairanpinjaman() 
        {
            string X = String.Empty;
            dynamic DTPicker1 = null;
            dynamic DTPicker3 = null;
            dynamic DTPicker2 = null;
            X = Convert.ToString(DateAndTime.DateDiff("d", DTPicker1.Value, DTPicker3.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Pencairan Harus Lebih Besar Dari Tanggal Lahir", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker3.Value = DTPicker2.Value;
            }
            else
            {
                // Text8.Text = DateDiff("yyyy", DTPicker1.Value, DTPicker2.Value)
            }
        }

        private void tanggalpencairanpinjaman1() 
        {
            string X = String.Empty;
            dynamic DTPicker2 = null;
            dynamic DTPicker3 = null;
            X = Convert.ToString(DateAndTime.DateDiff("d", DTPicker2.Value, DTPicker3.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Pencairan Harus Lebih Besar Dari Tanggal Bergabung", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker3.Value = DTPicker2.Value;
            }
            else
            {
                // Text8.Text = DateDiff("yyyy", DTPicker1.Value, DTPicker2.Value)
            }
        }

        private void tanggallalai() 
        {
            string X = String.Empty;
            dynamic DTPicker3 = null;
            dynamic DTPicker4 = null;
            dynamic Text22 = null;
            X = Convert.ToString(DateAndTime.DateDiff("m", DTPicker3.Value, DTPicker4.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Angsuran terakhir Harus Lebih Besar Dari Tanggal Pencairan Pinjaman Anggota", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker4.Value = DTPicker3.Value;
            }
            else
            {
                Text22.Text = DateAndTime.DateDiff("M", DTPicker3.Value, DTPicker4.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System);
            }
        }

        private void usiaanggota() 
        {
            string X = String.Empty;
            dynamic DTPicker1 = null;
            dynamic DTPicker5 = null;
            dynamic DTPicker2 = null;
            dynamic Text7 = null;
            X = Convert.ToString(DateAndTime.DateDiff("d", DTPicker1.Value, DTPicker5.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Klaim Harus Lebih Besar Dari Tanggal Lahir", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker5.Value = DTPicker2.Value;
            }
            else
            {
                Text7.Text = DateAndTime.DateDiff("yyyy", DTPicker1.Value, DTPicker5.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System);
            }
        }

        private void lamaanggota() 
        {
            string X = String.Empty;
            dynamic DTPicker2 = null;
            dynamic DTPicker5 = null;
            dynamic Text9 = null;
            X = Convert.ToString(DateAndTime.DateDiff("d", DTPicker2.Value, DTPicker5.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Klaim Harus Lebih Besar Dari Tanggal Bergabung", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker5.Value = DTPicker2.Value;
            }
            else
            {
                Text9.Text = DateAndTime.DateDiff("yyyy", DTPicker2.Value, DTPicker5.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System);
            }
        }

        private void usiapencairan() 
        {
            string X = String.Empty;
            dynamic DTPicker1 = null;
            dynamic DTPicker3 = null;
            dynamic DTPicker2 = null;
            dynamic Text27 = null;
            X = Convert.ToString(DateAndTime.DateDiff("yyyy", DTPicker1.Value, DTPicker3.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System));
            if (String.Compare(X, "0") < 0)
            {
                MessageBox.Show("Tanggal Pencairan Pinjaman Harus Lebih Besar Dari Tanggal Lahir", "Project1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker3.Value = DTPicker2.Value;
            }
            else
            {
                Text27.Text = DateAndTime.DateDiff("yyyy", DTPicker1.Value, DTPicker3.Value, Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.System);
            }
        }

        // ==============================================
        // ==============================================
        // ================
        // validasi form kosong
        // ================
        private void mulai() 
        {
            dynamic Text1 = null;
            dynamic Text2 = null;
            dynamic Text3 = null;
            dynamic Text4 = null;
            dynamic Text5 = null;
            dynamic Text6 = null;
            dynamic Text7 = null;
            dynamic Text8 = null;
            dynamic Text9 = null;
            dynamic Text10 = null;
            dynamic Text11 = null;
            dynamic Text12 = null;
            dynamic Text13 = null;
            dynamic Text14 = null;
            dynamic Text15 = null;
            dynamic Text16 = null;
            dynamic Text17 = null;
            dynamic Text18 = null;
            dynamic Text19 = null;
            dynamic Text20 = null;
            dynamic Text21 = null;
            dynamic Text22 = null;
            dynamic Text23 = null;
            dynamic Text24 = null;
            dynamic Text25 = null;
            dynamic Text26 = null;
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            Text5.Text = "";
            Text6.Text = "0";
            Text7.Text = "0";
            Text8.Text = "0";
            Text9.Text = "0";
            Text10.Text = "0";
            Text11.Text = "0";
            Text12.Text = "0";
            Text13.Text = "0";
            Text14.Text = "0";
            Text15.Text = "0";
            Text16.Text = "0";
            Text17.Text = "0";
            Text18.Text = "0";
            Text19.Text = "0";
            Text20.Text = "0";
            Text21.Text = "0";
            Text22.Text = "0";
            Text23.Text = "0";
            Text24.Text = "0";
            Text25.Text = "0";
            Text26.Text = "0";
        }

        private void DTPicker2_Change() 
        {
            tanggalbergabung();
        }

        private void DTPicker3_Change() 
        {
            usiapencairan();
            tanggalpencairanpinjaman();
            tanggalpencairanpinjaman1();
        }

        private void DTPicker4_Change() 
        {
            tanggallalai();
        }

        private void DTPicker5_Change() 
        {
            usiaanggota();
            lamaanggota();
        }

        // =====================
        // =====================
        private void Form_Load(System.Object _sender, System.EventArgs _e1) 
        {
            mulai();
        }


    }

}
