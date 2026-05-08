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

namespace Final_Project
{
    public partial class Report : Form
    {
        // data passed in from MainForm
        private string[] ProductNames;
        private string[] Sizes;
        private int[,] Stock;
        private int[,] SoldQty;
        private decimal[,] SoldValue;
        private int LowStockThreshold;

        public Report(string[] productNames, string[] sizes, int[,] stock, int[,] soldQty, decimal[,] soldValue, int lowStockThreshold)
        {
            InitializeComponent();

            ProductNames = productNames;
            Sizes = sizes;
            Stock = stock;
            SoldQty = soldQty;
            SoldValue = soldValue;
            LowStockThreshold = lowStockThreshold;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // Build both reports once
            BuildSalesReport();
            BuildStockReport();

            // Default view = Sales
            SalesReportButton.Checked = true;
            ShowSalesReport();
        }

        // ------------------- RADIO BUTTON SWITCHING -------------------
        private void SalesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SalesReportButton.Checked)
                ShowSalesReport();
        }

        private void StockRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StockReportButton.Checked)
                ShowStockReport();
        }

        private void ShowSalesReport()
        {
            SalesGroupBox.Visible = true;
            StockGroupBox.Visible = false;
        }

        private void ShowStockReport()
        {
            SalesGroupBox.Visible = false;
            StockGroupBox.Visible = true;
        }


        // ------------------- SALES REPORT -------------------
        private void BuildSalesReport()
        {
            SalesTextBox.Clear();

            decimal grandTotal = 0m;

            SalesTextBox.AppendText("DAILY SALES REPORT (so far)\r\n");
            SalesTextBox.AppendText("=====================================\r\n\r\n");

            for (int p = 0; p < ProductNames.Length; p++)
            {
                bool productPrinted = false;

                for (int s = 0; s < Sizes.Length; s++)
                {
                    if (SoldQty[p, s] > 0)
                    {
                        if (!productPrinted)
                        {
                            SalesTextBox.AppendText(ProductNames[p] + "\r\n");
                            productPrinted = true;
                        }

                        SalesTextBox.AppendText(
                            "  " + Sizes[s] +
                            " | Qty: " + SoldQty[p, s] +
                            " | Value: " + SoldValue[p, s].ToString("C2") +
                            "\r\n"
                        );

                        grandTotal += SoldValue[p, s];
                    }
                }

                if (productPrinted)
                {
                    SalesTextBox.AppendText("\r\n");
                }
            }

            SalesTextBox.AppendText("=====================================\r\n");
            SalesTextBox.AppendText("TOTAL SALES VALUE: " + grandTotal.ToString("C2") + "\r\n");
            SalesTextBox.AppendText("=====================================\r\n");
        }


        // ------------------- STOCK REPORT -------------------
        private void BuildStockReport()
        {
            string report = "STOCK REPORT (Remaining)\r\n";
            report += "=========================================\r\n\r\n";
            // -------- LOW STOCK SUMMARY --------
            report += "LOW STOCK SUMMARY (Below " + LowStockThreshold + " units)\r\n";
            report += "-----------------------------------------\r\n";

            bool anyLow = false;

            for (int p = 0; p < ProductNames.Length; p++)
            {
                for (int s = 0; s < Sizes.Length; s++)
                {
                    if (Stock[p, s] <= LowStockThreshold)
                    {
                        anyLow = true;
                        report += ProductNames[p] +
                                  " (" + Sizes[s] + ") : Remaining " +
                                  Stock[p, s] + "\r\n";
                    }
                }
            }

            if (!anyLow)
            {
                report += "None\r\n";
            }

            report += "\r\n=========================================\r\n\r\n";


            for (int p = 0; p < ProductNames.Length; p++)
            {
                report += ProductNames[p] + "\r\n";

                for (int s = 0; s < Sizes.Length; s++)
                {
                    int remaining = Stock[p, s];

                    string warning = "";
                    if (remaining <= LowStockThreshold)
                        warning = "   *** LOW STOCK ***";

                    report += "  " + Sizes[s].PadRight(12) +
                              " Remaining: " + remaining.ToString().PadLeft(3) +
                              warning + "\r\n";
                }

                report += "\r\n";
            }

            StockTextBox.Text = report;

            // Save persistently to text file in debug folder
            string path = Path.Combine(Application.StartupPath, "stock_report.txt");
            File.WriteAllText(path, report);
        }


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

        
    
