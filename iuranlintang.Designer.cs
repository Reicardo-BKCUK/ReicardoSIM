namespace Project1
{
    partial class iuranlintang
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ToolTip toolTip1 = null;
        public System.Windows.Forms.GroupBox Frame52 = null;
        public AxTrueOleDBGrid60.AxTDBGrid TDBGrid122 = null;
        public AxMSAdodcLib.AxAdodc Adodc122 = null;
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
            this.Location  = new System.Drawing.Point(8, 54);
            this.ClientSize  = new System.Drawing.Size(1350, 638);
            this.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.AutoScaleBaseSize  = new System.Drawing.Size(725,1698);
            this.Frame52 = new System.Windows.Forms.GroupBox();
            this.TDBGrid122 = new AxTrueOleDBGrid60.AxTDBGrid();
            this.Adodc122 = new AxMSAdodcLib.AxAdodc();
            this.Name = "iuranlintang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Frame52.Size  = new System.Drawing.Size(361, 177);
            this.Frame52.Location  = new System.Drawing.Point(968, 24);
            this.Frame52.SuspendLayout();
            this.Frame52.Text = "Frame5";
            this.Frame52.Name = "Frame52";
            this.Frame52.TabIndex = 0;
            this.Frame52.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid122)).BeginInit();
            this.TDBGrid122.Size  = new System.Drawing.Size(337, 105);
            this.TDBGrid122.Location  = new System.Drawing.Point(8, 64);
            this.TDBGrid122.Name = "TDBGrid122";
            this.TDBGrid122.TabIndex = 1;
            this.TDBGrid122.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(this.Adodc122)).BeginInit();
            this.Adodc122.Size  = new System.Drawing.Size(129, 22);
            this.Adodc122.Location  = new System.Drawing.Point(24, 24);
            this.Adodc122.Font  = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((System.Byte)(0)));
            this.Adodc122.ConnectionTimeout = 15;
            this.Adodc122.CommandTimeout = 30;
            this.Adodc122.OLEDBFile = "";
            this.Adodc122.Password = "";
            this.Adodc122.RecordSource = "plafoniuranlintang";
            this.Adodc122.EOFAction = MSAdodcLib.EOFActionEnum.adDoMoveLast;
            this.Adodc122.BackColor = System.Drawing.SystemColors.WindowText;
            this.Adodc122.Appearance = MSAdodcLib.AppearanceEnum.ad3DBevel;
            this.Adodc122.Name = "Adodc122";
            this.Adodc122.Text = "Adodc1";
            this.Adodc122.ConnectStringType = MSAdodcLib.ConnectStringTypeEnum.adConnectTypeOledb;
            this.Adodc122.OLEDBString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DBJALINAN\\DBJALINAN2.mdb;Persist Security Info=False";
            this.Adodc122.CommandType = MSAdodcLib.CommandTypeEnum.adCmdTable;
            this.Adodc122.BOFAction = MSAdodcLib.BOFActionEnum.adDoMoveFirst;
            this.Adodc122.CacheSize = 50;
            this.Adodc122.Orientation = MSAdodcLib.OrientationEnum.adHorizontal;
            this.Adodc122.Enabled = true;
            this.Adodc122.IsolationLevel = ADODB.IsolationLevelEnum.adXactUnspecified;
            this.Adodc122.MaxRecords = 0;
            this.Adodc122.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            this.Adodc122.UserName = "";
            this.Adodc122.DataSourceName = "";
            this.Adodc122.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Adodc122.CursorLocation = MSAdodcLib.CursorLocationEnum.adUseClient;
            this.Adodc122.OtherAttributes = "";
            this.Adodc122.CursorType = MSAdodcLib.CursorTypeEnum.adOpenStatic;
            this.Frame52.Controls.AddRange(new System.Windows.Forms.Control[] {
                        TDBGrid122,
                        Adodc122,
                        });
            ((System.ComponentModel.ISupportInitialize)(this.TDBGrid122)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adodc122)).EndInit();
            this.Frame52.ResumeLayout(false);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                        Frame52,
                        });
            this.ResumeLayout(false);
        }
#endregion

    }
}
