namespace sunxi_fex_tools_gui4win
{
    partial class MainForm1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bin2fex = new System.Windows.Forms.TabPage();
            this.PathBin = new System.Windows.Forms.TextBox();
            this.TransFex = new System.Windows.Forms.Button();
            this.OpenBin = new System.Windows.Forms.Button();
            this.fex2bin = new System.Windows.Forms.TabPage();
            this.TransBin = new System.Windows.Forms.Button();
            this.PathFex = new System.Windows.Forms.TextBox();
            this.OpenFex = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.openBinDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFexDialog = new System.Windows.Forms.OpenFileDialog();
            this.LangBox1 = new System.Windows.Forms.ComboBox();
            this.LangLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.bin2fex.SuspendLayout();
            this.fex2bin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bin2fex);
            this.tabControl1.Controls.Add(this.fex2bin);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // bin2fex
            // 
            this.bin2fex.Controls.Add(this.PathBin);
            this.bin2fex.Controls.Add(this.TransFex);
            this.bin2fex.Controls.Add(this.OpenBin);
            resources.ApplyResources(this.bin2fex, "bin2fex");
            this.bin2fex.Name = "bin2fex";
            this.bin2fex.UseVisualStyleBackColor = true;
            // 
            // PathBin
            // 
            this.PathBin.AllowDrop = true;
            resources.ApplyResources(this.PathBin, "PathBin");
            this.PathBin.Name = "PathBin";
            this.PathBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathBin_DragDrop);
            this.PathBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathBin_DragEnter);
            // 
            // TransFex
            // 
            resources.ApplyResources(this.TransFex, "TransFex");
            this.TransFex.Name = "TransFex";
            this.TransFex.UseVisualStyleBackColor = true;
            this.TransFex.Click += new System.EventHandler(this.TransFex_Click);
            // 
            // OpenBin
            // 
            resources.ApplyResources(this.OpenBin, "OpenBin");
            this.OpenBin.Name = "OpenBin";
            this.OpenBin.UseVisualStyleBackColor = true;
            this.OpenBin.Click += new System.EventHandler(this.OpenBin_Click);
            // 
            // fex2bin
            // 
            this.fex2bin.Controls.Add(this.TransBin);
            this.fex2bin.Controls.Add(this.PathFex);
            this.fex2bin.Controls.Add(this.OpenFex);
            resources.ApplyResources(this.fex2bin, "fex2bin");
            this.fex2bin.Name = "fex2bin";
            this.fex2bin.UseVisualStyleBackColor = true;
            // 
            // TransBin
            // 
            resources.ApplyResources(this.TransBin, "TransBin");
            this.TransBin.Name = "TransBin";
            this.TransBin.UseVisualStyleBackColor = true;
            this.TransBin.Click += new System.EventHandler(this.TransBin_Click);
            // 
            // PathFex
            // 
            this.PathFex.AllowDrop = true;
            resources.ApplyResources(this.PathFex, "PathFex");
            this.PathFex.Name = "PathFex";
            this.PathFex.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathFex_DragDrop);
            this.PathFex.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathFex_DragEnter);
            // 
            // OpenFex
            // 
            resources.ApplyResources(this.OpenFex, "OpenFex");
            this.OpenFex.Name = "OpenFex";
            this.OpenFex.UseVisualStyleBackColor = true;
            this.OpenFex.Click += new System.EventHandler(this.OpenFex_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            resources.ApplyResources(this.About, "About");
            this.About.Name = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // openBinDialog
            // 
            this.openBinDialog.FileName = "script.bin";
            resources.ApplyResources(this.openBinDialog, "openBinDialog");
            // 
            // openFexDialog
            // 
            this.openFexDialog.FileName = "sys_config.fex";
            resources.ApplyResources(this.openFexDialog, "openFexDialog");
            // 
            // LangBox1
            // 
            this.LangBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangBox1.FormattingEnabled = true;
            this.LangBox1.Items.AddRange(new object[] {
            resources.GetString("LangBox1.Items"),
            resources.GetString("LangBox1.Items1")});
            resources.ApplyResources(this.LangBox1, "LangBox1");
            this.LangBox1.Name = "LangBox1";
            this.LangBox1.SelectedIndexChanged += new System.EventHandler(this.LangBox1_SelectedIndexChanged);
            // 
            // LangLabel
            // 
            resources.ApplyResources(this.LangLabel, "LangLabel");
            this.LangLabel.Name = "LangLabel";
            // 
            // MainForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LangBox1);
            this.Controls.Add(this.LangLabel);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm1";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.tabControl1.ResumeLayout(false);
            this.bin2fex.ResumeLayout(false);
            this.bin2fex.PerformLayout();
            this.fex2bin.ResumeLayout(false);
            this.fex2bin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bin2fex;
        private System.Windows.Forms.TabPage fex2bin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button TransFex;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.OpenFileDialog openBinDialog;
        private System.Windows.Forms.OpenFileDialog openFexDialog;
        private System.Windows.Forms.Button OpenBin;
        private System.Windows.Forms.Button OpenFex;
        private System.Windows.Forms.TextBox PathBin;
        private System.Windows.Forms.TextBox PathFex;
        private System.Windows.Forms.Button TransBin;
        private System.Windows.Forms.ComboBox LangBox1;
        private System.Windows.Forms.Label LangLabel;
    }
}

