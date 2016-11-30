namespace Project1
{
    partial class lihatanggota
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ToolTip toolTip1 = null;
        public System.Windows.Forms.TabControl SSTab1 = null;
        public System.Windows.Forms.GroupBox Frame3 = null;
        public System.Windows.Forms.Button Command7 = null;
        public System.Windows.Forms.Button Command6 = null;
        public System.Windows.Forms.Button Command5 = null;
        public System.Windows.Forms.Button Command4 = null;
        public System.Windows.Forms.GroupBox Frame2 = null;
        public System.Windows.Forms.Button Command3 = null;
        public System.Windows.Forms.Button Command2 = null;
        public System.Windows.Forms.Button Command1 = null;
        public System.Windows.Forms.GroupBox Frame1 = null;
        public System.Windows.Forms.TextBox Text6 = null;
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
        public AxMSAdodcLib.AxAdodc Adodc1 = null;
        public AxTrueOleDBGrid60.AxTDBGrid TDBGrid1 = null;
        public System.Windows.Forms.TabPage SSTab1_0 = null;
        public System.Windows.Forms.TabPage SSTab1_1 = null;
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
            this.ClientSize  = new System.Drawing.Size(840, 523);
            this.Font  = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.AutoScaleBaseSize  = new System.Drawing.Size(628,1472);
            this.SSTab1 = new System.Windows.Forms.TabControl();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.Command7 = new System.Windows.Forms.Button();
            this.Command6 = new System.Windows.Forms.Button();
            this.Command5 = new System.Windows.Forms.Button();
            this.Command4 = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Command3 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Text6 = new System.Windows.Forms.TextBox();
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
            this.Adodc1 = new AxMSAdodcLib.AxAdodc();
            this.TDBGrid1 = new AxTrueOleDBGrid60.AxTDBGrid();
            this.Name = "lihatanggota";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.SSTab1.Size  = new System.Drawing.Size(793, 481);
            this.SSTab1.Location  = new System.Drawing.Point(0, 0);
            this.SSTab1.Font  = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.SSTab1.SuspendLayout();
            SSTab1_0 = new System.Windows.Forms.TabPage();
            this.SSTab1_0.Size  = new System.Drawing.Size(785, 445);
            this.SSTab1_0.Location  = new System.Drawing.Point(4, 33);
            this.SSTab1_0.Name = "SSTab1_0";
            this.SSTab1_0.Text = "Data Anggota";
            this.SSTab1_0.Controls.Add(this.Frame3);
            this.SSTab1_0.Controls.Add(this.Adodc1);
            this.SSTab1_0.Controls.Add(this.TDBGrid1);
            SSTab1_1 = new System.Windows.Forms.TabPage();
            this.SSTab1_1.Size  = new System.Drawing.Size(785, 445);
            this.SSTab1_1.Location  = new System.Drawing.Point(4, 33);
            this.SSTab1_1.Name = "SSTab1_1";
            this.SSTab1_1.Text = "Validasi Data Anggota";
            this.SSTab1_1.Controls.Add(this.Frame1);
            this.SSTab1_1.Controls.Add(this.Frame2);
            this.SSTab1.Name = "SSTab1";
            this.SSTab1.Enabled = true;
            this.SSTab1.TabIndex = 13;
            this.Frame3.Size  = new System.Drawing.Size(401, 65);
            this.Frame3.Location  = new System.Drawing.Point(8, 24);
            this.Frame3.SuspendLayout();
            this.Frame3.Name = "Frame3";
            this.Frame3.TabIndex = 23;
            this.Frame3.Enabled = true;
            this.Command7.Size  = new System.Drawing.Size(81, 33);
            this.Command7.Location  = new System.Drawing.Point(304, 16);
            this.Command7.Font  = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command7.Text = "&KELUAR";
            this.Command7.Name = "Command7";
            this.Command7.TabIndex = 12;
            this.Command7.Enabled = true;
            this.Command7.Click += new System.EventHandler(this.Command7_Click);
            this.Command6.Size  = new System.Drawing.Size(81, 33);
            this.Command6.Location  = new System.Drawing.Point(208, 16);
            this.Command6.Font  = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command6.Text = "&HAPUS";
            this.Command6.Name = "Command6";
            this.Command6.TabIndex = 11;
            this.Command6.Enabled = true;
            this.Command6.Click += new System.EventHandler(this.Command6_Click);
            this.Command5.Size  = new System.Drawing.Size(89, 33);
            this.Command5.Location  = new System.Drawing.Point(104, 16);
            this.Command5.Font  = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command5.Text = "&EDIT";
            this.Command5.Name = "Command5";
            this.Command5.TabIndex = 10;
            this.Command5.Enabled = true;
            this.Command5.Click += new System.EventHandler(this.Command5_Click);
            this.Command4.Size  = new System.Drawing.Size(81, 33);
            this.Command4.Location  = new System.Drawing.Point(8, 16);
            this.Command4.Font  = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command4.Text = "&TAMBAH";
            this.Command4.Name = "Command4";
            this.Command4.TabIndex = 9;
            this.Command4.Enabled = true;
            this.Command4.Click += new System.EventHandler(this.Command4_Click);
            this.Frame2.Size  = new System.Drawing.Size(337, 65);
            this.Frame2.Location  = new System.Drawing.Point(232, 384);
            this.Frame2.SuspendLayout();
            this.Frame2.Name = "Frame2";
            this.Frame2.TabIndex = 22;
            this.Frame2.Enabled = true;
            this.Command3.Size  = new System.Drawing.Size(89, 41);
            this.Command3.Location  = new System.Drawing.Point(232, 16);
            this.Command3.Font  = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command3.Text = "&KELUAR";
            this.Command3.Name = "Command3";
            this.Command3.TabIndex = 8;
            this.Command3.Enabled = true;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            this.Command2.Size  = new System.Drawing.Size(89, 41);
            this.Command2.Location  = new System.Drawing.Point(120, 16);
            this.Command2.Font  = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command2.Text = "&EDIT";
            this.Command2.Name = "Command2";
            this.Command2.TabIndex = 7;
            this.Command2.Enabled = true;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            this.Command1.Size  = new System.Drawing.Size(89, 41);
            this.Command1.Location  = new System.Drawing.Point(8, 16);
            this.Command1.Font  = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Command1.Text = "&SIMPAN";
            this.Command1.Name = "Command1";
            this.Command1.TabIndex = 6;
            this.Command1.Enabled = true;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            this.Frame1.Size  = new System.Drawing.Size(593, 337);
            this.Frame1.Location  = new System.Drawing.Point(88, 32);
            this.Frame1.SuspendLayout();
            this.Frame1.Text = "Frame1";
            this.Frame1.Name = "Frame1";
            this.Frame1.TabIndex = 15;
            this.Frame1.Enabled = true;
            this.Text6.Size  = new System.Drawing.Size(465, 35);
            this.Text6.Location  = new System.Drawing.Point(120, 288);
            this.Text6.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text6.Name = "Text6";
            this.Text6.Text = "Text6";
            this.Text6.TabIndex = 5;
            this.Text6.Enabled = true;
            this.Text5.Size  = new System.Drawing.Size(465, 35);
            this.Text5.Location  = new System.Drawing.Point(120, 248);
            this.Text5.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text5.Name = "Text5";
            this.Text5.Text = "Text5";
            this.Text5.TabIndex = 4;
            this.Text5.Enabled = true;
            this.Text4.Size  = new System.Drawing.Size(465, 34);
            this.Text4.Location  = new System.Drawing.Point(120, 208);
            this.Text4.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text4.Name = "Text4";
            this.Text4.Text = "Text4";
            this.Text4.TabIndex = 3;
            this.Text4.Enabled = true;
            this.Text3.Size  = new System.Drawing.Size(465, 96);
            this.Text3.Location  = new System.Drawing.Point(120, 104);
            this.Text3.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text3.Name = "Text3";
            this.Text3.Text = resources.GetString("Text3.Text");
            this.Text3.Multiline = true;
            this.Text3.TabIndex = 2;
            this.Text3.Enabled = true;
            this.Text2.Size  = new System.Drawing.Size(465, 33);
            this.Text2.Location  = new System.Drawing.Point(120, 64);
            this.Text2.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text2.Name = "Text2";
            this.Text2.Text = "Text2";
            this.Text2.TabIndex = 1;
            this.Text2.Enabled = true;
            this.Text1.Size  = new System.Drawing.Size(137, 33);
            this.Text1.Location  = new System.Drawing.Point(120, 24);
            this.Text1.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Text1.Name = "Text1";
            this.Text1.Text = "Text1";
            this.Text1.TabIndex = 0;
            this.Text1.Enabled = true;
            this.Label6.Size  = new System.Drawing.Size(57, 25);
            this.Label6.Location  = new System.Drawing.Point(16, 296);
            this.Label6.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label6.Text = "Email";
            this.Label6.Name = "Label6";
            this.Label6.TabIndex = 21;
            this.Label6.Enabled = true;
            this.Label5.Size  = new System.Drawing.Size(41, 25);
            this.Label5.Location  = new System.Drawing.Point(16, 256);
            this.Label5.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label5.Text = "HP";
            this.Label5.Name = "Label5";
            this.Label5.TabIndex = 20;
            this.Label5.Enabled = true;
            this.Label4.Size  = new System.Drawing.Size(81, 25);
            this.Label4.Location  = new System.Drawing.Point(16, 216);
            this.Label4.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label4.Text = "Telepon";
            this.Label4.Name = "Label4";
            this.Label4.TabIndex = 19;
            this.Label4.Enabled = true;
            this.Label3.Size  = new System.Drawing.Size(73, 25);
            this.Label3.Location  = new System.Drawing.Point(16, 120);
            this.Label3.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label3.Text = "Alamat";
            this.Label3.Name = "Label3";
            this.Label3.TabIndex = 18;
            this.Label3.Enabled = true;
            this.Label2.Size  = new System.Drawing.Size(89, 25);
            this.Label2.Location  = new System.Drawing.Point(16, 72);
            this.Label2.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label2.Text = "Nama CU";
            this.Label2.Name = "Label2";
            this.Label2.TabIndex = 17;
            this.Label2.Enabled = true;
            this.Label1.Size  = new System.Drawing.Size(65, 25);
            this.Label1.Location  = new System.Drawing.Point(16, 32);
            this.Label1.Font  = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Label1.Text = "No BA";
            this.Label1.Name = "Label1";
            this.Label1.TabIndex = 16;
            this.Label1.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(this.Adodc1)).BeginInit();
            this.Adodc1.Size  = new System.Drawing.Size(80, 25);
            this.Adodc1.Location  = new System.Drawing.Point(688, 48);
            this.Adodc1.Font  = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Adodc1.ConnectionTimeout = 15;
            this.Adodc1.CommandTimeout = 30;
            this.Adodc1.OLEDBFile = "";
            this.Adodc1.Password = "";
            this.Adodc1.RecordSource = "Anggota";
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
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid1)).BeginInit();
            this.TDBGrid1.Size  = new System.Drawing.Size(785, 377);
            this.TDBGrid1.Location  = new System.Drawing.Point(0, 96);
            this.TDBGrid1.Name = "TDBGrid1";
            this.TDBGrid1.TabIndex = 14;
            this.TDBGrid1.Enabled = true;
            this.Frame3.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Command7,
                        Command6,
                        Command5,
                        Command4,
                        });
            this.Frame3.ResumeLayout(false);
            this.Frame2.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Command3,
                        Command2,
                        Command1,
                        });
            this.Frame2.ResumeLayout(false);
            this.Frame1.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Text6,
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
            this.SSTab1.Controls.AddRange(new System.Windows.Forms.Control[] {
                        SSTab1_0,
                        SSTab1_1,
                        });
            this.SSTab1.ResumeLayout(false);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                        SSTab1,
                        });
            this.ResumeLayout(false);
        }
#endregion

    }
}
