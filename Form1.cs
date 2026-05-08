/* Student Name: Chetna Tiwari
 * Student ID: 25253099
 * Date:18/12/2025
 * Assignment: 4
 * Assignment: Electronic Point of Sale (EPOS)
 */


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


namespace Final_Project
{


    public partial class MainForm : Form
    {

        private const string STOCK_FILE = "stock_open.txt";
        // ================= CART DATA =================


        private struct CartEntry
        {
            public int ProductIndex;
            public int SizeIndex;
            public int Qty;
            public decimal UnitPrice;
        }

        private List<CartEntry> Cart = new List<CartEntry>();

        // ---------- INVENTORY DATA ----------
        string[] ProductNames =
        {
          "Classic Hot Chocolate",
          "White Hot Chocolate",
          "Peppermint Hot Chocolate",
          "Gingerbread Latte",
          "Hot Chocolate with Marshmallows",
          "Salted Caramel Hot Chocolate",
          "Dark Chocolate Mocha",
          "Hazelnut Hot Chocolate",
          "Orange Spiced Hot Chocolate",
          "Chai Latte"
        };

        string[] Sizes = { "Small", "Medium", "Large", "Extra Large", "Family" };

        // Prices [product, size]
        decimal[,] Prices =
        {
          { 3.00m, 3.50m, 4.00m, 4.50m, 8.50m },
          { 3.20m, 3.70m, 4.20m, 4.70m, 8.80m },
          { 3.50m, 4.00m, 4.50m, 5.00m, 9.20m },
          { 3.60m, 4.10m, 4.60m, 5.10m, 9.50m },
          { 3.80m, 4.30m, 4.80m, 5.30m, 9.80m },
          { 3.90m, 4.40m, 4.90m, 5.40m, 10.00m },
          { 4.00m, 4.50m, 5.00m, 5.50m, 10.50m },
          { 3.85m, 4.35m, 4.85m, 5.35m, 9.90m },
          { 3.70m, 4.20m, 4.70m, 5.20m, 9.70m },
          { 3.60m, 4.10m, 4.60m, 5.10m, 9.60m }
        };

        int[,] Stock;

        // Running totals
        decimal CartTotal = 0m;
        int LoyaltyPoints = 0;

        // ===== Daily sales tracking (qty + value sold so far today) =====
        private int[,] SoldQty;              
        private decimal[,] SoldValue;
        private const int LOW_STOCK_THRESHOLD = 5;

        

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            MediumRadio.Checked = true;

            LoadStockFromFile();

            SoldQty = new int[ProductNames.Length, Sizes.Length];
            SoldValue = new decimal[ProductNames.Length, Sizes.Length];
            LoadInventory();

            

            QuantityTextBox.Text = "0";
            QuantityTextBox.Focus();
            QuantityTextBox.SelectAll();

            CartListBox.Items.Clear();
            UpdateTotalsUI();

            
         

        }

        private void LoadStockFromFile()
        {
            string path = Path.Combine(Application.StartupPath, STOCK_FILE);

            // Create empty stock array (so program never crashes)
            Stock = new int[ProductNames.Length, Sizes.Length];

            if (!File.Exists(path))
            {
                MessageBox.Show("Opening stock file not found:\n" + path,
                                "Stock File Missing",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(path);

            if (lines.Length < ProductNames.Length)
            {
                MessageBox.Show("Stock file does not contain enough rows.\nExpected: " + ProductNames.Length +
                                "\nFound: " + lines.Length,
                                "Stock File Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            for (int p = 0; p < ProductNames.Length; p++)
            {
                // Expected format:
               
                string[] parts = lines[p].Split('|');

                if (parts.Length != 1 + Sizes.Length)
                {
                    MessageBox.Show("Invalid stock line format:\n" + lines[p] +
                                    "\nExpected: ProductName plus " + Sizes.Length + " values.",
                                    "Stock File Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                
                string fileProductName = parts[0].Trim();
                if (!fileProductName.Equals(ProductNames[p], StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Product name mismatch in stock file on line " + (p + 1) + ":\n" +
                                    "Expected: " + ProductNames[p] + "\n" +
                                    "Found: " + fileProductName,
                                    "Stock File Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                for (int s = 0; s < Sizes.Length; s++)
                {
                    int val;
                    if (!int.TryParse(parts[s + 1], out val) || val < 0)
                    {
                        MessageBox.Show("Invalid stock number on line:\n" + lines[p],
                                        "Stock File Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    Stock[p, s] = val;
                }
            }
        }

        
      
        // -------------------- LOAD INVENTORY --------------------
        private void LoadInventory()
        {
            InventoryListView.Items.Clear();

            // Default size = Medium
            int sizeIndex = GetSelectedSizeIndex();

            for (int i = 0; i < ProductNames.Length; i++)
            {
                ListViewItem row = new ListViewItem(ProductNames[i]);  // Product
                row.SubItems.Add(Prices[i, sizeIndex].ToString("C2")); // Price for selected size

                // Store product index for later use
                row.Tag = i;

                InventoryListView.Items.Add(row);
            }

        }

        // -------------------- UPDATE TOTALS --------------------
        private void UpdateTotalsUI()
        {
            
            TotalAmountLabel.Text = CartTotal.ToString("C2");
            PointsLabel.Text = LoyaltyPoints.ToString();
        }
        private int GetSelectedSizeIndex()
        {
            if (SmallRadio.Checked) return 0;
            if (MediumRadio.Checked) return 1;
            if (LargeRadio.Checked) return 2;
            if (ExtraLargeRadio.Checked) return 3;
            return 4; // Family
        }

        private void SizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;

            // Only refresh when a button becomes CHECKED
            if (!rb.Checked) return;


            LoadInventory();
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            // 1) Must select a product
            if (InventoryListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product first.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Must select a size
            int SizeIndex = GetSelectedSizeIndex();

            // 3) Quantity must be valid
            int Qty;
            if (!int.TryParse(QuantityTextBox.Text.Trim(), out Qty) || Qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (greater than 0).", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();
                return;
            }

            // 4) Get selected product index 
            ListViewItem selectedRow = InventoryListView.SelectedItems[0];
            int ProductIndex = (int)selectedRow.Tag;

            // 5) Stock check 
            if (Stock[ProductIndex, SizeIndex] < Qty)
            {
                MessageBox.Show("Sorry, we do not have enough stock for that quantity.",
                    "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 6) Calculate unit price for selected size
            decimal unitPrice = Prices[ProductIndex, SizeIndex];
            decimal lineTotal = unitPrice * Qty;

            // 7) Deduct stock
            Stock[ProductIndex, SizeIndex] -= Qty;
            

            // 8) Add to cart list 
            CartEntry entry = new CartEntry
            {
                ProductIndex = ProductIndex,
                SizeIndex = SizeIndex,
                Qty = Qty,
                UnitPrice = unitPrice
            };
            Cart.Add(entry);

            // 9) Show in CartListBox (nice format)
            string cartLine =
                ProductNames[ProductIndex] + " | " +
                Sizes[SizeIndex] + " | Qty: " + Qty + " | " +
                unitPrice.ToString("C2") + " each | Line: " + lineTotal.ToString("C2");

            CartListBox.Items.Add(cartLine);

            // 10) Update totals + points
            CartTotal += lineTotal;

            // 1 point per €5 spent (rounded down)
            LoyaltyPoints = (int)(CartTotal / 5m);

            UpdateTotalsUI();

        }

        private void RemoveSelectionButton_Click(object sender, EventArgs e)
        {
            // Must select something in cart
            int selectedIndex = CartListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select an item in the cart to remove.",
                                "Nothing Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            // Get the cart entry
            CartEntry entry = Cart[selectedIndex];

            DialogResult res = MessageBox.Show("Remove selected item from cart?",
                                  "Confirm",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (res == DialogResult.No) return;


            // Calculate the amount to remove from totals
            decimal lineTotal = entry.UnitPrice * entry.Qty;

            // Restore stock
            Stock[entry.ProductIndex, entry.SizeIndex] += entry.Qty;
            // Remove from cart storage and UI
            Cart.RemoveAt(selectedIndex);
            CartListBox.Items.RemoveAt(selectedIndex);

            // Update totals
            CartTotal -= lineTotal;
            if (CartTotal < 0m) CartTotal = 0m;

            // Loyalty rule (must match your Add-to-cart rule)
            LoyaltyPoints = (int)(CartTotal / 5m);

            UpdateTotalsUI();

            // refresh inventory price display 
            LoadInventory();
        }

        private void ResetForNewSale()
        {
            // 1) Restore stock for all items currently in cart
            for (int i = 0; i < Cart.Count; i++)
            {
                CartEntry entry = Cart[i];
                Stock[entry.ProductIndex, entry.SizeIndex] += entry.Qty;
            }

            // 2) Clear cart storage + cart UI
            Cart.Clear();
            CartListBox.Items.Clear();

            // 3) Reset totals
            CartTotal = 0m;
            LoyaltyPoints = 0;
            UpdateTotalsUI();

            // 4) Reset selection controls
            InventoryListView.SelectedItems.Clear();

            // Default size = Medium (index 1)
            MediumRadio.Checked = true;

            QuantityTextBox.Text = "0";
            QuantityTextBox.Focus();
            QuantityTextBox.SelectAll();

            // 5) Refresh inventory display (price column depends on selected size)
            LoadInventory();
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
            if (Cart.Count == 0)
            {
                // Nothing to clear – still reset the UI
                ResetForNewSale();
                return;
            }
            DialogResult res = MessageBox.Show(
              "This will clear the cart and start a new sale. Continue?",
              "New Sale",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                ResetForNewSale();
            }
        }

        private string GenerateTxn()
        {
            // Example: TXN-20251218-143522-42
            string datePart = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            Random rnd = new Random();
            int suffix = rnd.Next(10, 99);

            return "TXN-" + datePart + "-" + suffix.ToString();
        }

        private void SaveTransactionToFile(string txnNumber, string txnDate)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, "transactions.txt");

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true))
            {
                sw.WriteLine("========== WINTER HOT CHOCOLATE TRANSACTION ==========");
                sw.WriteLine("Transaction #: " + txnNumber);
                sw.WriteLine("Date: " + txnDate);
                sw.WriteLine("--------------------------------------------");

                // Cart lines
                for (int i = 0; i < Cart.Count; i++)
                {
                    CartEntry entry = Cart[i];
                    decimal lineTotal = entry.UnitPrice * entry.Qty;

                    sw.WriteLine(
                        ProductNames[entry.ProductIndex] + " | " +
                        Sizes[entry.SizeIndex] + " | Qty: " + entry.Qty +
                        " | Unit: " + entry.UnitPrice.ToString("C2") +
                        " | Line: " + lineTotal.ToString("C2")
                    );
                }

                sw.WriteLine("--------------------------------------------");
                sw.WriteLine("Total: " + CartTotal.ToString("C2"));
                sw.WriteLine("Loyalty Points Earned: " + LoyaltyPoints.ToString());
                sw.WriteLine("============================================");
                sw.WriteLine();
            }
        }

        private void UpdateDailySalesFromCart()
        {
            for (int i = 0; i < Cart.Count; i++)
            {
                CartEntry e = Cart[i];
                SoldQty[e.ProductIndex, e.SizeIndex] += e.Qty;
                SoldValue[e.ProductIndex, e.SizeIndex] += (e.UnitPrice * e.Qty);
            }
        }

        private void SaveStockToFile()
        {
            string path = Path.Combine(Application.StartupPath, STOCK_FILE); // SAME FILE you loaded

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int p = 0; p < ProductNames.Length; p++)
                {
                    string line = ProductNames[p];
                    for (int s = 0; s < Sizes.Length; s++)
                        line += "|" + Stock[p, s].ToString();

                    sw.WriteLine(line);
                }
            }
        }





        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            // 1) Cart must have items
            if (Cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before checkout.",
                                "Checkout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2) Build a clean confirmation message
            string summary = "Confirm checkout?\n\n";

            for (int i = 0; i < Cart.Count; i++)
            {
                CartEntry entry = Cart[i];
                decimal lineTotal = entry.UnitPrice * entry.Qty;

                summary += ProductNames[entry.ProductIndex] +
                           " (" + Sizes[entry.SizeIndex] + ")" +
                           " x" + entry.Qty +
                           " = " + lineTotal.ToString("C2") + "\n";
            }

            summary += "\n----------------------------------\n";
            summary += "TOTAL: " + CartTotal.ToString("C2") + "\n";
            summary += "Loyalty Points: " + LoyaltyPoints.ToString() + "\n";

            DialogResult res = MessageBox.Show(summary,
                                              "Checkout Confirmation",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            
            


            // 3) If No, just return (cart remains)
            if (res == DialogResult.No)
                return;

            UpdateDailySalesFromCart();
            SaveStockToFile();

            // 4) Save transaction
            string txnNumber = GenerateTxn();
            string txnDate = DateTime.Today.ToShortDateString();

           

            try
            {
                SaveTransactionToFile(txnNumber, txnDate);

                MessageBox.Show("Checkout complete.\nTransaction #: " + txnNumber,
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

               

                // 5) Start a new sale:
                Cart.Clear();
                CartListBox.Items.Clear();
                CartTotal = 0m;
                LoyaltyPoints = 0;
                UpdateTotalsUI();

                QuantityTextBox.Text = "1";
                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();
                InventoryListView.SelectedItems.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Checkout failed. Transaction was not saved.\n\n" + ex.Message,
                                "File Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        




        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Report rpt = new Report(ProductNames, Sizes, Stock, SoldQty, SoldValue, LOW_STOCK_THRESHOLD);
            rpt.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (Search s = new Search())
            {
                s.ShowDialog(this);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
        "Are you sure you want to exit the application?\n\nClosing stock will be saved.",
        "Exit Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

    if (res == DialogResult.No)
        return;

            try
            {
                // Save closing stock before exit
                SaveStockToFile();

                MessageBox.Show("Closing stock saved successfully.",
                                "Exit",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving closing stock:\n" + ex.Message,
                                "File Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Exit application
            Application.Exit();
        }

        
    }

}
