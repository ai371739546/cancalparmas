namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnSevenParams = new System.Windows.Forms.RadioButton();
            this.rdbtnFourParams = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSrcElipse = new System.Windows.Forms.ComboBox();
            this.cmbDesElipse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstParams = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnSevenParams);
            this.groupBox1.Controls.Add(this.rdbtnFourParams);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数类型";
            // 
            // rdbtnSevenParams
            // 
            this.rdbtnSevenParams.AutoSize = true;
            this.rdbtnSevenParams.Location = new System.Drawing.Point(273, 20);
            this.rdbtnSevenParams.Name = "rdbtnSevenParams";
            this.rdbtnSevenParams.Size = new System.Drawing.Size(167, 16);
            this.rdbtnSevenParams.TabIndex = 1;
            this.rdbtnSevenParams.TabStop = true;
            this.rdbtnSevenParams.Text = "计算七参数（布尔沙模型）";
            this.rdbtnSevenParams.UseVisualStyleBackColor = true;
            // 
            // rdbtnFourParams
            // 
            this.rdbtnFourParams.AutoSize = true;
            this.rdbtnFourParams.Location = new System.Drawing.Point(28, 21);
            this.rdbtnFourParams.Name = "rdbtnFourParams";
            this.rdbtnFourParams.Size = new System.Drawing.Size(143, 16);
            this.rdbtnFourParams.TabIndex = 0;
            this.rdbtnFourParams.TabStop = true;
            this.rdbtnFourParams.Text = "计算四参数(平面坐标)";
            this.rdbtnFourParams.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbDesElipse);
            this.groupBox2.Controls.Add(this.cmbSrcElipse);
            this.groupBox2.Location = new System.Drawing.Point(4, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "椭球基准";
            // 
            // cmbSrcElipse
            // 
            this.cmbSrcElipse.FormattingEnabled = true;
            this.cmbSrcElipse.Items.AddRange(new object[] {
            "北京54",
            "西安80",
            "国家2000",
            "WGS84"});
            this.cmbSrcElipse.Location = new System.Drawing.Point(103, 21);
            this.cmbSrcElipse.Name = "cmbSrcElipse";
            this.cmbSrcElipse.Size = new System.Drawing.Size(121, 20);
            this.cmbSrcElipse.TabIndex = 0;
            // 
            // cmbDesElipse
            // 
            this.cmbDesElipse.FormattingEnabled = true;
            this.cmbDesElipse.Items.AddRange(new object[] {
            "北京54",
            "西安80",
            "国家2000",
            "WGS84"});
            this.cmbDesElipse.Location = new System.Drawing.Point(367, 21);
            this.cmbDesElipse.Name = "cmbDesElipse";
            this.cmbDesElipse.Size = new System.Drawing.Size(121, 20);
            this.cmbDesElipse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "源椭球基准：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标椭球基准：";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 110);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 200);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加控制点";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除控制点";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "计算参数";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstParams
            // 
            this.lstParams.FormattingEnabled = true;
            this.lstParams.ItemHeight = 12;
            this.lstParams.Location = new System.Drawing.Point(17, 351);
            this.lstParams.Name = "lstParams";
            this.lstParams.Size = new System.Drawing.Size(505, 88);
            this.lstParams.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 443);
            this.Controls.Add(this.lstParams);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算转换参数工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnSevenParams;
        private System.Windows.Forms.RadioButton rdbtnFourParams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDesElipse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSrcElipse;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstParams;


    }
}

