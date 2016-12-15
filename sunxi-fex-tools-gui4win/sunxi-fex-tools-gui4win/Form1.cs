using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//ADD
using System.IO;


namespace sunxi_fex_tools_gui4win
{
    public partial class MainForm1 : Form
    {
        String Fexc = "bin\\sunxi-fexc.exe";
        String Bin2fex = "-I bin -O fex ";
        String Fex2bin = "-I fex -O bin ";
        String Fex2binCmd;
        String Bin2fexCmd;

        public MainForm1()
        {
            InitializeComponent();
        }

        private void TransFex_Click(object sender, EventArgs e)
        {
            if (File.Exists(PathBin.Text))
            {
                Bin2fexCmd = Bin2fex + PathBin.Text + " " + Path.GetDirectoryName(PathBin.Text) + "\\" + Path.GetFileNameWithoutExtension(PathBin.Text) + ".fex";
                try
                {
                    Process proc = Process.Start(Fexc, Bin2fexCmd);
                    if (proc != null)
                    {
                        proc.WaitForExit();
                        MessageBox.Show(String.Format("bin2fex转换成功！", this.Fexc), this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("bin文件不存在！");
            }
        }

        private void TransBin_Click(object sender, EventArgs e)
        {
            if (File.Exists(PathBin.Text))
            {
                Fex2binCmd = Fex2bin + PathFex.Text + " " + Path.GetDirectoryName(PathFex.Text) + "\\" + Path.GetFileNameWithoutExtension(PathFex.Text) + ".bin";
                try
                {
                    Process proc = Process.Start(Fexc, Fex2binCmd);
                    if (proc != null)
                    {
                        proc.WaitForExit();
                        MessageBox.Show(String.Format("fex2bin转换成功！", this.Fexc), this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("fex文件不存在！");
            }
        }

        private void OpenBin_Click(object sender, EventArgs e)
        {
            if (openBinDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openBinDialog.FileName);
                sr.Close();
                PathBin.Text = openBinDialog.FileName;
            }
        }

        private void OpenFex_Click(object sender, EventArgs e)
        {
            if (openFexDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFexDialog.FileName);
                sr.Close();
                PathFex.Text = openFexDialog.FileName;
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("关于 Allwinner 配置档转换工具\n\n版本 v1.001\n\nLicense:\nGPLv2\n\nGithub:\nhttps://github.com/OtakuNekoP/sunxi-fex-tools-gui4win\n\nOpen Source Components:\nsunxi-tools (https://github.com/linux-sunxi/sunxi-tools)\nCygwin (https://www.cygwin.com/)\n");
        }

        private void PathFex_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PathFex_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.PathFex.Text = path;
        }

        private void PathBin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PathBin_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.PathBin.Text = path;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
