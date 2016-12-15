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
            this.tabControl1.SuspendLayout();
            this.bin2fex.SuspendLayout();
            this.fex2bin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bin2fex);
            this.tabControl1.Controls.Add(this.fex2bin);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 65);
            this.tabControl1.TabIndex = 0;
            // 
            // bin2fex
            // 
            this.bin2fex.Controls.Add(this.PathBin);
            this.bin2fex.Controls.Add(this.TransFex);
            this.bin2fex.Controls.Add(this.OpenBin);
            this.bin2fex.Location = new System.Drawing.Point(4, 22);
            this.bin2fex.Name = "bin2fex";
            this.bin2fex.Padding = new System.Windows.Forms.Padding(3);
            this.bin2fex.Size = new System.Drawing.Size(622, 39);
            this.bin2fex.TabIndex = 0;
            this.bin2fex.Text = "bin2fex";
            this.bin2fex.UseVisualStyleBackColor = true;
            // 
            // PathBin
            // 
            this.PathBin.AllowDrop = true;
            this.PathBin.Location = new System.Drawing.Point(11, 9);
            this.PathBin.Name = "PathBin";
            this.PathBin.Size = new System.Drawing.Size(460, 21);
            this.PathBin.TabIndex = 1;
            this.PathBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathBin_DragDrop);
            this.PathBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathBin_DragEnter);
            // 
            // TransFex
            // 
            this.TransFex.Location = new System.Drawing.Point(547, 4);
            this.TransFex.Name = "TransFex";
            this.TransFex.Size = new System.Drawing.Size(64, 32);
            this.TransFex.TabIndex = 2;
            this.TransFex.Text = "转换为FEX";
            this.TransFex.UseVisualStyleBackColor = true;
            this.TransFex.Click += new System.EventHandler(this.TransFex_Click);
            // 
            // OpenBin
            // 
            this.OpenBin.Location = new System.Drawing.Point(477, 4);
            this.OpenBin.Name = "OpenBin";
            this.OpenBin.Size = new System.Drawing.Size(64, 32);
            this.OpenBin.TabIndex = 0;
            this.OpenBin.Text = "打开";
            this.OpenBin.UseVisualStyleBackColor = true;
            this.OpenBin.Click += new System.EventHandler(this.OpenBin_Click);
            // 
            // fex2bin
            // 
            this.fex2bin.Controls.Add(this.TransBin);
            this.fex2bin.Controls.Add(this.PathFex);
            this.fex2bin.Controls.Add(this.OpenFex);
            this.fex2bin.Location = new System.Drawing.Point(4, 22);
            this.fex2bin.Name = "fex2bin";
            this.fex2bin.Padding = new System.Windows.Forms.Padding(3);
            this.fex2bin.Size = new System.Drawing.Size(622, 39);
            this.fex2bin.TabIndex = 1;
            this.fex2bin.Text = "fex2bin";
            this.fex2bin.UseVisualStyleBackColor = true;
            // 
            // TransBin
            // 
            this.TransBin.Location = new System.Drawing.Point(547, 4);
            this.TransBin.Name = "TransBin";
            this.TransBin.Size = new System.Drawing.Size(64, 32);
            this.TransBin.TabIndex = 2;
            this.TransBin.Text = "转换为BIN";
            this.TransBin.UseVisualStyleBackColor = true;
            this.TransBin.Click += new System.EventHandler(this.TransBin_Click);
            // 
            // PathFex
            // 
            this.PathFex.AllowDrop = true;
            this.PathFex.Location = new System.Drawing.Point(11, 9);
            this.PathFex.Name = "PathFex";
            this.PathFex.Size = new System.Drawing.Size(460, 21);
            this.PathFex.TabIndex = 1;
            this.PathFex.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathFex_DragDrop);
            this.PathFex.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathFex_DragEnter);
            // 
            // OpenFex
            // 
            this.OpenFex.Location = new System.Drawing.Point(477, 4);
            this.OpenFex.Name = "OpenFex";
            this.OpenFex.Size = new System.Drawing.Size(64, 32);
            this.OpenFex.TabIndex = 0;
            this.OpenFex.Text = "打开";
            this.OpenFex.UseVisualStyleBackColor = true;
            this.OpenFex.Click += new System.EventHandler(this.OpenFex_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(553, 73);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(64, 32);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(17, 73);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(64, 32);
            this.About.TabIndex = 3;
            this.About.Text = "关于";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // openBinDialog
            // 
            this.openBinDialog.FileName = "script.bin";
            this.openBinDialog.Filter = "BIN (*.bin)|*.bin";
            this.openBinDialog.Title = "打开BIN";
            // 
            // openFexDialog
            // 
            this.openFexDialog.FileName = "sys_config.fex";
            this.openFexDialog.Filter = "FEX (*.fex)|*.fex";
            this.openFexDialog.Title = "打开FEX";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 111);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm1";
            this.Text = "Allwinner 配置档转换工具";
            this.tabControl1.ResumeLayout(false);
            this.bin2fex.ResumeLayout(false);
            this.bin2fex.PerformLayout();
            this.fex2bin.ResumeLayout(false);
            this.fex2bin.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

