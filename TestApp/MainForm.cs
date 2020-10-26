using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;

namespace TestApp
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, int> drugs;
        public int resetCount;
        private static NLog.ILogger _logger;

        public MainForm()
        {
            InitializeComponent();
            InitializeDrugs();
            resetCount = 0;
            _logger = LogManager.GetCurrentClassLogger();
        }   

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                drugs["Acetaminophen"] = resetCount;
                drugs["Oxycotin"] = resetCount;
                drugs["Ibuprofen"] = resetCount;

                lblDrugQuantity1.Text = resetCount.ToString();
                lblDrugQuantity2.Text = resetCount.ToString();
                lblDrugQuantity3.Text = resetCount.ToString();
                
                _logger.Info($"{DateTime.Now:MM/dd/yy HH:mm:ss}: RESET");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void InitializeDrugs()
        {
            drugs = new Dictionary<string, int>
            {
                { "Acetaminophen", 0 },
                { "Oxycotin", 0 },
                { "Ibuprofen", 0 }
            };
        }

        private void btnCounter1_Click(object sender, EventArgs e)
        {
            try
            {
                if (drugs.TryGetValue("Acetaminophen", out int counter1))
                {
                    _logger.Info($"{DateTime.Now:MM/dd/yy HH:mm:ss}: Name: Acetaminophen | Previous Count: {counter1} | New Count: {++counter1}");
                    drugs["Acetaminophen"] = counter1;
                    lblDrugQuantity1.Text = counter1.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCounter2_Click(object sender, EventArgs e)
        {
            try
            {
                if (drugs.TryGetValue("Oxycotin", out int counter2))
                {
                    _logger.Info($"{DateTime.Now:MM/dd/yy HH:mm:ss}: Name: Oxycotin | Previous Count: {counter2} | New Count: {++counter2}");
                    drugs["Oxycotin"] = counter2;
                    lblDrugQuantity2.Text = counter2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCounter3_Click(object sender, EventArgs e)
        {
            try
            {
                if (drugs.TryGetValue("Ibuprofen", out int counter3))
                {
                    _logger.Info($"{DateTime.Now:MM/dd/yy HH:mm:ss}: Name: Ibuprofen | Previous Count: {counter3} | New Count: {++counter3}");
                    drugs["Ibuprofen"] = counter3;
                    lblDrugQuantity3.Text = counter3.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            DisplayLog frmDisplayLog = new DisplayLog();
            frmDisplayLog.ShowDialog(this);
        }
    }
}
