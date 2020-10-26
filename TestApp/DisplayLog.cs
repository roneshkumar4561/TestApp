using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestApp
{
    public partial class DisplayLog : Form
    {
        public DisplayLog()
        {
            InitializeComponent();
            LoadLogFile();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLogFile()
        {
            string path = @"DrugIncrementTest.log";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                richTextLog.Text = sr.ReadToEnd();
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                MessageBox.Show(fileNotFoundEx.Message,"File not found");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                this.Close();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
