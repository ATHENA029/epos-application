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
    public partial class Search : Form
    {
        private const string TRANSACTION_FILENAME = "transactions.txt";

        private string GetTransactionFilePath()
        {
            return Path.Combine(Application.StartupPath, TRANSACTION_FILENAME);
        }

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            SearchDisplayTextBox.Clear();
            SearchTextBox.Focus();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchDisplayTextBox.Clear();

            if (!File.Exists(TRANSACTION_FILENAME))
            {
                MessageBox.Show("No transactions file found in Debug folder.\n\n" + TRANSACTION_FILENAME,
                                "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = SearchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a Transaction ID or a Date.",
                                "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchTextBox.Focus();
                return;
            }

            if (TransactionButton.Checked)
            {
                string block = FindTransactionById(query);

                if (block == null)
                {
                    SearchDisplayTextBox.Text = "No transaction found for ID: " + query;
                }
                else
                {
                    SearchDisplayTextBox.Text = block;
                }
            }
            else if (DateButton.Checked)
            {
                // Accept dd/MM/yyyy or anything DateTime can parse
                DateTime date;
                if (!DateTime.TryParse(query, out date))
                {
                    MessageBox.Show("Please enter a valid date (e.g., 14/11/2025).",
                                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SearchTextBox.Focus();
                    return;
                }

                List<string> blocks = FindTransactionsByDate(date.ToShortDateString());

                if (blocks.Count == 0)
                {
                    SearchDisplayTextBox.Text = "No transactions found for date: " + date.ToShortDateString();
                }
                else
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Transactions on " + date.ToShortDateString());
                    sb.AppendLine("====================================");
                    sb.AppendLine();

                    foreach (string b in blocks)
                    {
                        sb.AppendLine(b);
                        sb.AppendLine();
                    }

                    SearchDisplayTextBox.Text = sb.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select Transaction ID or Date search.",
                                "Select Search Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------------- SEARCH HELPERS ----------------

        private string FindTransactionById(string txnId)
        {
            string[] lines = File.ReadAllLines(TRANSACTION_FILENAME);

            StringBuilder block = null;
            bool inBlock = false;
            bool match = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("========== WINTER HOT CHOCOLATE TRANSACTION"))
                {
                    // Start a new block
                    block = new StringBuilder();
                    inBlock = true;
                    match = false;
                }

                if (inBlock && block != null)
                    block.AppendLine(line);

                if (inBlock && line.StartsWith("Transaction #:"))
                {
                    string fileId = line.Substring("Transaction #:".Length).Trim();
                    if (fileId.Equals(txnId, StringComparison.OrdinalIgnoreCase))
                        match = true;
                }

                if (inBlock && line.StartsWith("============================================"))
                {
                    // End of block
                    if (match && block != null)
                        return block.ToString();

                    inBlock = false;
                    block = null;
                }
            }

            return null;
        }

        private List<string> FindTransactionsByDate(string dateText)
        {
            string[] lines = File.ReadAllLines(TRANSACTION_FILENAME);

            List<string> results = new List<string>();

            StringBuilder block = null;
            bool inBlock = false;
            bool match = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("========== WINTER HOT CHOCOLATE TRANSACTION"))
                {
                    block = new StringBuilder();
                    inBlock = true;
                    match = false;
                }

                if (inBlock && block != null)
                    block.AppendLine(line);

                if (inBlock && line.StartsWith("Date:"))
                {
                    string fileDate = line.Substring("Date:".Length).Trim();
                    if (fileDate.Equals(dateText, StringComparison.OrdinalIgnoreCase))
                        match = true;
                }

                if (inBlock && line.StartsWith("============================================"))
                {
                    if (match && block != null)
                        results.Add(block.ToString());

                    inBlock = false;
                    block = null;
                }
            }

            return results;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear input and output
            SearchTextBox.Clear();
            SearchDisplayTextBox.Clear();

            // Reset radio buttons
            TransactionButton.Checked = true;
            DateButton.Checked = false;

            // Set focus back to input
            SearchTextBox.Focus();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
   

