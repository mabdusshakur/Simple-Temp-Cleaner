using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Temp_Cleaner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void clear_temp_btn_Click(object sender, EventArgs e)
        {
            DirectoryInfo temp_1 = new DirectoryInfo(Path.GetTempPath());
            DirectoryInfo temp_2 = new DirectoryInfo("C:\\Windows\\Temp");
            try 
            { 
                if(temp_1.Exists)
                {
                    foreach (FileInfo file in temp_1.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch { }
                    }
                    foreach (DirectoryInfo folder in temp_1.GetDirectories())
                    {
                        try
                        {
                            folder.Delete();
                        }
                        catch { }
                    }
                }
                else
                {
                    MessageBox.Show("Temp Folder Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (temp_2.Exists)
                {
                    foreach (FileInfo file in temp_2.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch { }
                    }
                    foreach (DirectoryInfo folder in temp_2.GetDirectories())
                    {
                        try
                        {
                            folder.Delete();
                        }
                        catch { }
                    }
                }
                else
                {
                    MessageBox.Show("Temp Folder Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Cant Clear Temp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_prefetch_btn_Click(object sender, EventArgs e)
        {

            DirectoryInfo prefetch = new DirectoryInfo("C:\\Windows\\Prefetch");
            try
            {
                if (prefetch.Exists)
                {
                    foreach (FileInfo file in prefetch.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch {  }
                    }
                    foreach (DirectoryInfo folder in prefetch.GetDirectories())
                    {
                        try
                        {
                            folder.Delete();
                        }
                        catch { }
                    }
                }
                else
                {
                    MessageBox.Show("Prefetch Folder Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Cant Clear Prefetch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
