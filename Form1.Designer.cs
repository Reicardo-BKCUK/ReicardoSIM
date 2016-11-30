namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dBJALINAN2DataSet = new Project1.DBJALINAN2DataSet();
            this.tabelTPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelTPTableAdapter = new Project1.DBJALINAN2DataSetTableAdapters.tabelTPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJALINAN2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelTPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataSource = this.tabelTPBindingSource;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(75, 56);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(365, 131);
            this.c1TrueDBGrid1.TabIndex = 0;
            // 
            // dBJALINAN2DataSet
            // 
            this.dBJALINAN2DataSet.DataSetName = "DBJALINAN2DataSet";
            this.dBJALINAN2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelTPBindingSource
            // 
            this.tabelTPBindingSource.DataMember = "tabelTP";
            this.tabelTPBindingSource.DataSource = this.dBJALINAN2DataSet;
            // 
            // tabelTPTableAdapter
            // 
            this.tabelTPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 362);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJALINAN2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelTPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private DBJALINAN2DataSet dBJALINAN2DataSet;
        private System.Windows.Forms.BindingSource tabelTPBindingSource;
        private DBJALINAN2DataSetTableAdapters.tabelTPTableAdapter tabelTPTableAdapter;
    }
}