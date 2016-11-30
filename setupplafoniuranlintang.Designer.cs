namespace Project1
{
    partial class setupplafoniuranlintang
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ToolTip toolTip1 = null;
        public AxTrueOleDBGrid60.AxTDBGrid TDBGrid1 = null;
        public AxMSAdodcLib.AxAdodc Adodc1 = null;
        public System.Windows.Forms.GroupBox Frame1 = null;
        public System.Windows.Forms.Button Command2 = null;
        public System.Windows.Forms.Button Command1 = null;
        public System.Windows.Forms.TextBox Text5 = null;
        public System.Windows.Forms.TextBox Text4 = null;
        public System.Windows.Forms.TextBox Text3 = null;
        public System.Windows.Forms.TextBox Text2 = null;
        public System.Windows.Forms.TextBox Text1 = null;
        public System.Windows.Forms.Label Label6 = null;
        public System.Windows.Forms.Label Label5 = null;
        public System.Windows.Forms.Label Label4 = null;
        public System.Windows.Forms.Label Label3 = null;
        public System.Windows.Forms.Label Label2 = null;
        public System.Windows.Forms.Label Label1 = null;
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing);
        }

#region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(this.GetType());
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            this.Location  = new System.Drawing.Point(8, 30);
            this.ClientSize  = new System.Drawing.Size(582, 430);
            this.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.AutoScaleBaseSize  = new System.Drawing.Size(725,1698);
            this.TDBGrid1 = new AxTrueOleDBGrid60.AxTDBGrid();
            this.Adodc1 = new AxMSAdodcLib.AxAdodc();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Name = "setupplafoniuranlintang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid1)).BeginInit();
            this.TDBGrid1.Size  = new System.Drawing.Size(217, 73);
            this.TDBGrid1.Location  = new System.Drawing.Point(16, 336);
            this.TDBGrid1.Name = "TDBGrid1";
            this.TDBGrid1.TabIndex = 14;
            this.TDBGrid1.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(this.Adodc1)).BeginInit();
            this.Adodc1.Size  = new System.Drawing.Size(81, 22);
            this.Adodc1.Location  = new System.Drawing.Point(280, 336);
            this.Adodc1.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Adodc1.ConnectionTimeout = 15;
            this.Adodc1.CommandTimeout = 30;
            this.Adodc1.OLEDBFile = "";
            this.Adodc1.Password = "";
            this.Adodc1.RecordSource = "plafoniuranlintang";
            this.Adodc1.EOFAction = MSAdodcLib.EOFActionEnum.adDoMoveLast;
            this.Adodc1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Adodc1.Appearance = MSAdodcLib.AppearanceEnum.ad3DBevel;
            this.Adodc1.Name = "Adodc1";
            this.Adodc1.Text = "Adodc1";
            this.Adodc1.ConnectStringType = MSAdodcLib.ConnectStringTypeEnum.adConnectTypeOledb;
            this.Adodc1.OLEDBString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DBJALINAN\\DBJALINAN2.mdb;Persist Security Info=False";
            this.Adodc1.CommandType = MSAdodcLib.CommandTypeEnum.adCmdTable;
            this.Adodc1.BOFAction = MSAdodcLib.BOFActionEnum.adDoMoveFirst;
            this.Adodc1.CacheSize = 50;
            this.Adodc1.Orientation = MSAdodcLib.OrientationEnum.adHorizontal;
            this.Adodc1.Enabled = true;
            this.Adodc1.IsolationLevel = ADODB.IsolationLevelEnum.adXactUnspecified;
            this.Adodc1.MaxRecords = 0;
            this.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            this.Adodc1.UserName = "";
            this.Adodc1.DataSourceName = "";
            this.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Adodc1.CursorLocation = MSAdodcLib.CursorLocationEnum.adUseClient;
            this.Adodc1.OtherAttributes = "";
            this.Adodc1.CursorType = MSAdodcLib.CursorTypeEnum.adOpenStatic;
            this.Frame1.Size  = new System.Drawing.Size(433, 297);
            this.Frame1.Location  = new System.Drawing.Point(8, 8);
            this.Frame1.SuspendLayout();
            this.Frame1.Text = "Frame1";
            this.Frame1.Name = "Frame1";
            this.Frame1.TabIndex = 0;
            this.Frame1.Enabled = true;
            this.Command2.Size  = new System.Drawing.Size(81, 33);
            this.Command2.Location  = new System.Drawing.Point(216, 256);
            this.Command2.Text = "&Keluar";
            this.Command2.Name = "Command2";
            this.Command2.TabIndex = 13;
            this.Command2.Enabled = true;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            this.Command1.Size  = new System.Drawing.Size(81, 33);
            this.Command1.Location  = new System.Drawing.Point(128, 256);
            this.Command1.Text = "&Simpan";
            this.Command1.Name = "Command1";
            this.Command1.TabIndex = 12;
            this.Command1.Enabled = true;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            this.Text5.Size  = new System.Drawing.Size(177, 26);
            this.Text5.Location  = new System.Drawing.Point(216, 200);
            this.Text5.Name = "Text5";
            this.Text5.Text = "Text5";
            this.Text5.TabIndex = 10;
            this.Text5.Enabled = true;
            this.Text5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text5_KeyPress);
            this.Text4.Size  = new System.Drawing.Size(177, 26);
            this.Text4.Location  = new System.Drawing.Point(216, 152);
            this.Text4.Name = "Text4";
            this.Text4.Text = "Text4";
            this.Text4.TabIndex = 9;
            this.Text4.Enabled = true;
            this.Text4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text4_KeyPress);
            this.Text3.Size  = new System.Drawing.Size(177, 26);
            this.Text3.Location  = new System.Drawing.Point(216, 104);
            this.Text3.Name = "Text3";
            this.Text3.Text = "Text3";
            this.Text3.TabIndex = 8;
            this.Text3.Enabled = true;
            this.Text3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text3_KeyPress);
            this.Text2.Size  = new System.Drawing.Size(177, 26);
            this.Text2.Location  = new System.Drawing.Point(216, 56);
            this.Text2.Name = "Text2";
            this.Text2.Text = "Text2";
            this.Text2.TabIndex = 7;
            this.Text2.Enabled = true;
            this.Text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text2_KeyPress);
            this.Text1.Size  = new System.Drawing.Size(65, 26);
            this.Text1.Location  = new System.Drawing.Point(216, 16);
            this.Text1.Name = "Text1";
            this.Text1.Text = "Text1";
            this.Text1.TabIndex = 6;
            this.Text1.Enabled = true;
            this.Label6.Size  = new System.Drawing.Size(41, 17);
            this.Label6.Location  = new System.Drawing.Point(288, 24);
            this.Label6.Text = "Sen";
            this.Label6.Name = "Label6";
            this.Label6.TabIndex = 11;
            this.Label6.Enabled = true;
            this.Label5.Size  = new System.Drawing.Size(201, 57);
            this.Label5.Location  = new System.Drawing.Point(8, 184);
            this.Label5.Text = "Plafon Saldo Piutang Produktif dan Usia diatas 55 Tahun atau Pengembalian Diatas 36 Bulan";
            this.Label5.Name = "Label5";
            this.Label5.TabIndex = 5;
            this.Label5.Enabled = true;
            this.Label4.Size  = new System.Drawing.Size(201, 25);
            this.Label4.Location  = new System.Drawing.Point(8, 152);
            this.Label4.Text = "Plafon Saldo Piutang Kapitalisasi";
            this.Label4.Name = "Label4";
            this.Label4.TabIndex = 4;
            this.Label4.Enabled = true;
            this.Label3.Size  = new System.Drawing.Size(185, 41);
            this.Label3.Location  = new System.Drawing.Point(8, 104);
            this.Label3.Text = "Plafon Piutang Dicairkan yg Berusia diatas 60 s.d. 70 tahun";
            this.Label3.Name = "Label3";
            this.Label3.TabIndex = 3;
            this.Label3.Enabled = true;
            this.Label2.Size  = new System.Drawing.Size(169, 41);
            this.Label2.Location  = new System.Drawing.Point(8, 48);
            this.Label2.Text = "Plafon piutang Dicairkan yg Berusia s.d. 60 tahun";
            this.Label2.Name = "Label2";
            this.Label2.TabIndex = 2;
            this.Label2.Enabled = true;
            this.Label1.Size  = new System.Drawing.Size(81, 17);
            this.Label1.Location  = new System.Drawing.Point(8, 16);
            this.Label1.Text = "Pengali";
            this.Label1.Name = "Label1";
            this.Label1.TabIndex = 1;
            this.Label1.Enabled = true;
            this.Frame1.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Command2,
                        Command1,
                        Text5,
                        Text4,
                        Text3,
                        Text2,
                        Text1,
                        Label6,
                        Label5,
                        Label4,
                        Label3,
                        Label2,
                        Label1,
                        });
            this.Frame1.ResumeLayout(false);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                        TDBGrid1,
                        Adodc1,
                        Frame1,
                        });
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adodc1)).EndInit();
            this.ResumeLayout(false);
        }
#endregion

    }
}
