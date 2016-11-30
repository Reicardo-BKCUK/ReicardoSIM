namespace Project1
{
    partial class setupplafoniurantunas
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ToolTip toolTip1 = null;
        public AxTrueOleDBGrid60.AxTDBGrid TDBGrid1 = null;
        public AxMSAdodcLib.AxAdodc Adodc1 = null;
        public System.Windows.Forms.GroupBox Frame2 = null;
        public System.Windows.Forms.Button Command2 = null;
        public System.Windows.Forms.Button Command1 = null;
        public System.Windows.Forms.GroupBox Frame1 = null;
        public System.Windows.Forms.TextBox Text5 = null;
        public System.Windows.Forms.TextBox Text4 = null;
        public System.Windows.Forms.TextBox Text3 = null;
        public System.Windows.Forms.TextBox Text2 = null;
        public System.Windows.Forms.TextBox Text1 = null;
        public System.Windows.Forms.Label Label4 = null;
        public System.Windows.Forms.Label Label3_2 = null;
        public System.Windows.Forms.Label Label3_1 = null;
        public System.Windows.Forms.Label Label3_0 = null;
        public System.Windows.Forms.Label Label2 = null;
        public System.Windows.Forms.Label Label1 = null;
        public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Label3 = null;
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
            this.Label3 = new Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
            this.Location  = new System.Drawing.Point(3, 25);
            this.ClientSize  = new System.Drawing.Size(395, 280);
            this.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.AutoScaleBaseSize  = new System.Drawing.Size(725,1698);
            this.TDBGrid1 = new AxTrueOleDBGrid60.AxTDBGrid();
            this.Adodc1 = new AxMSAdodcLib.AxAdodc();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3_2 = new System.Windows.Forms.Label();
            this.Label3_1 = new System.Windows.Forms.Label();
            this.Label3_0 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Name = "setupplafoniurantunas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid1)).BeginInit();
            this.TDBGrid1.Size  = new System.Drawing.Size(273, 89);
            this.TDBGrid1.Location  = new System.Drawing.Point(648, 72);
            this.TDBGrid1.Visible = false;
            this.TDBGrid1.Name = "TDBGrid1";
            this.TDBGrid1.TabIndex = 14;
            this.TDBGrid1.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(this.Adodc1)).BeginInit();
            this.Adodc1.Size  = new System.Drawing.Size(80, 22);
            this.Adodc1.Location  = new System.Drawing.Point(664, 24);
            this.Adodc1.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Adodc1.ConnectionTimeout = 15;
            this.Adodc1.CommandTimeout = 30;
            this.Adodc1.OLEDBFile = "";
            this.Adodc1.Password = "";
            this.Adodc1.RecordSource = "plafoniurantunas";
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
            this.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            this.Adodc1.UserName = "";
            this.Adodc1.DataSourceName = "";
            this.Adodc1.Visible = false;
            this.Adodc1.CursorLocation = MSAdodcLib.CursorLocationEnum.adUseClient;
            this.Adodc1.OtherAttributes = "";
            this.Adodc1.CursorType = MSAdodcLib.CursorTypeEnum.adOpenStatic;
            this.Frame2.Size  = new System.Drawing.Size(193, 57);
            this.Frame2.Location  = new System.Drawing.Point(88, 216);
            this.Frame2.SuspendLayout();
            this.Frame2.Name = "Frame2";
            this.Frame2.TabIndex = 13;
            this.Frame2.Enabled = true;
            this.Command2.Size  = new System.Drawing.Size(73, 33);
            this.Command2.Location  = new System.Drawing.Point(104, 16);
            this.Command2.Text = "&Keluar";
            this.Command2.Name = "Command2";
            this.Command2.TabIndex = 7;
            this.Command2.Enabled = true;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            this.Command1.Size  = new System.Drawing.Size(73, 33);
            this.Command1.Location  = new System.Drawing.Point(8, 16);
            this.Command1.Text = "&Simpan";
            this.Command1.Name = "Command1";
            this.Command1.TabIndex = 6;
            this.Command1.Enabled = true;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            this.Frame1.Size  = new System.Drawing.Size(377, 209);
            this.Frame1.Location  = new System.Drawing.Point(8, 8);
            this.Frame1.SuspendLayout();
            this.Frame1.Name = "Frame1";
            this.Frame1.TabIndex = 0;
            this.Frame1.Enabled = true;
            this.Text5.Size  = new System.Drawing.Size(177, 26);
            this.Text5.Location  = new System.Drawing.Point(184, 160);
            this.Text5.Name = "Text5";
            this.Text5.Text = "Text5";
            this.Text5.TabIndex = 5;
            this.Text5.Enabled = true;
            this.Text5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text5_KeyPress);
            this.Text4.Size  = new System.Drawing.Size(177, 26);
            this.Text4.Location  = new System.Drawing.Point(184, 128);
            this.Text4.Name = "Text4";
            this.Text4.Text = "Text4";
            this.Text4.TabIndex = 4;
            this.Text4.Enabled = true;
            this.Text4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text4_KeyPress);
            this.Text3.Size  = new System.Drawing.Size(177, 26);
            this.Text3.Location  = new System.Drawing.Point(184, 96);
            this.Text3.Name = "Text3";
            this.Text3.Text = "Text3";
            this.Text3.TabIndex = 3;
            this.Text3.Enabled = true;
            this.Text3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text3_KeyPress);
            this.Text2.Size  = new System.Drawing.Size(177, 26);
            this.Text2.Location  = new System.Drawing.Point(184, 64);
            this.Text2.Name = "Text2";
            this.Text2.Text = "Text2";
            this.Text2.TabIndex = 2;
            this.Text2.Enabled = true;
            this.Text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text2_KeyPress);
            this.Text1.Size  = new System.Drawing.Size(49, 26);
            this.Text1.Location  = new System.Drawing.Point(184, 16);
            this.Text1.Name = "Text1";
            this.Text1.Text = "Text1";
            this.Text1.TabIndex = 1;
            this.Text1.Enabled = true;
            this.Text1.TextChanged += new System.EventHandler(this.Text1_Change);
            this.Label4.Size  = new System.Drawing.Size(41, 17);
            this.Label4.Location  = new System.Drawing.Point(240, 24);
            this.Label4.Text = "Sen";
            this.Label4.Name = "Label4";
            this.Label4.TabIndex = 15;
            this.Label4.Enabled = true;
            this.Label3_2.Size  = new System.Drawing.Size(169, 17);
            this.Label3_2.Location  = new System.Drawing.Point(8, 160);
            this.Label3_2.Text = "Plafon usia > 70 tahun";
            this.Label3_2.Name = "Label3_2";
            this.Label3_2.TabIndex = 12;
            this.Label3_2.Enabled = true;
            this.Label3_1.Size  = new System.Drawing.Size(169, 17);
            this.Label3_1.Location  = new System.Drawing.Point(8, 128);
            this.Label3_1.Text = "Plafon usia 60 s.d. 70 tahun";
            this.Label3_1.Name = "Label3_1";
            this.Label3_1.TabIndex = 11;
            this.Label3_1.Enabled = true;
            this.Label3_0.Size  = new System.Drawing.Size(169, 17);
            this.Label3_0.Location  = new System.Drawing.Point(8, 96);
            this.Label3_0.Text = "Plafon usia 2 s.d. 59 tahun";
            this.Label3_0.Name = "Label3_0";
            this.Label3_0.TabIndex = 10;
            this.Label3_0.Enabled = true;
            this.Label2.Size  = new System.Drawing.Size(161, 17);
            this.Label2.Location  = new System.Drawing.Point(8, 64);
            this.Label2.Text = "Plafon usia <= 1tahun";
            this.Label2.Name = "Label2";
            this.Label2.TabIndex = 9;
            this.Label2.Enabled = true;
            this.Label1.Size  = new System.Drawing.Size(65, 17);
            this.Label1.Location  = new System.Drawing.Point(8, 24);
            this.Label1.Text = "Pengali";
            this.Label1.Name = "Label1";
            this.Label1.TabIndex = 8;
            this.Label1.Enabled = true;
            this.Frame2.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Command2,
                        Command1,
                        });
            this.Frame2.ResumeLayout(false);
            this.Frame1.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Text5,
                        Text4,
                        Text3,
                        Text2,
                        Text1,
                        Label4,
                        Label3_2,
                        Label3_1,
                        Label3_0,
                        Label2,
                        Label1,
                        });
            this.Frame1.ResumeLayout(false);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                        TDBGrid1,
                        Adodc1,
                        Frame2,
                        Frame1,
                        });
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adodc1)).EndInit();
            this.Label3.SetIndex(Label3_2, 2);
            this.Label3.SetIndex(Label3_1, 1);
            this.Label3.SetIndex(Label3_0, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
            this.ResumeLayout(false);
        }
#endregion

    }
}
