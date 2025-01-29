using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Food_Ordering_System.src.main.appl.facade.sales.impl;
using Food_Ordering_System.src.main.appl.facade.sales;
using Food_Ordering_System.src.main.appl.model;
using Food_Ordering_System.src.main.data.sales.dao.impl;
using Food_Ordering_System.src.main;
using System.Drawing.Printing;

namespace Food_Ordering_System
{
    public partial class Receipt : Form
    {
        private salesFacade salesFacade;

        private SalesInfoMgtApplication appl = new SalesInfoMgtApplication();

        public int ReceiveDataId { get; set; } 
        public bool IsDineIn { get; set; } 
        public string PaymentMethod { get; set; } 

        public int CashAmount { get; set; }
        public Cart cart { get; set; } 

        public Receipt()
        {
            InitializeComponent();

            salesFacade = appl.GetSalesFacade();
        }

        private void UpdateReceipt()
        {
            flp_Receipt.Controls.Clear();

            List<Item> items = cart.GetItems();

            int itemPanelHeight = 80;
            int summaryPanelHeight = 0;
            if (PaymentMethod == "Cash")
            {
                summaryPanelHeight = 130;
            }
            else
            {
                summaryPanelHeight = 45;
            }
            int alternateColor = 0;
            Color color1 = Color.FromArgb(245, 245, 245);
            Color color2 = Color.FromArgb(245, 245, 245);

            foreach (var item in items)
            {
                if (alternateColor == 0)
                {
                    color1 = Color.FromArgb(218, 218, 218);
                    color2 = Color.WhiteSmoke;
                    alternateColor = 1;
                }
                else
                {
                    color1 = Color.White;
                    color2 = Color.White;
                    alternateColor = 0;
                }

                var itemPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flp_Receipt.Width - 30, itemPanelHeight),
                    BackColor = color2,
                    BorderRadius = 8,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    BorderColor = color1,
                    BorderThickness = 2
                };

                var lblName = new Label
                {
                    Text = item.FoodName,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 3)
                };

                var lblPrice = new Label
                {
                    Text = string.Format(new CultureInfo("es-PH"), "{0:C}", item.Price * item.Quantity),
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Dock = DockStyle.Bottom,
                    Margin = new Padding(0, 0, 0, 0)
                };

                var lblQuantity = new Label
                {
                    Text = "(" + item.Quantity + "x)",
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Dock = DockStyle.Right,
                    Margin = new Padding(0, 0, 0, 0)
                };

                itemPanel.Controls.Add(lblQuantity);
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);

                flp_Receipt.Controls.Add(itemPanel);
            }

            var summaryPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(flp_Receipt.Width - 30, summaryPanelHeight),
                BackColor = Color.WhiteSmoke,
                BorderRadius = 8,
                Padding = new Padding(10),
                Margin = new Padding(5, 10, 5, 5),
                BorderColor = Color.FromArgb(218, 218, 218),
                BorderThickness = 2
            };

            var lblTotal = new Label
            {
                Text = string.Format(new CultureInfo("es-PH"), "TOTAL: {0:C}", cart.GetTotalPrice()),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Top,
                Margin = new Padding(0, 5, 0, 0)
            };

            if(PaymentMethod == "Cash")
            {
                var lblCashAmout = new Label
                {
                    Text = string.Format(new CultureInfo("es-PH"), "CASH: {0:C}", CashAmount),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 5, 0, 0)
                };

                var lblChangeAmount = new Label
                {
                    Text = string.Format(new CultureInfo("es-PH"), "TOTAL CHANGE: {0:C}", CashAmount - cart.GetTotalPrice()),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 5, 0, 0)
                };
                summaryPanel.Controls.Add(lblChangeAmount);
                summaryPanel.Controls.Add(lblCashAmout);
            }


            summaryPanel.Controls.Add(lblTotal);

            flp_Receipt.Controls.Add(summaryPanel);
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            UpdateReceipt();
            try
            {
                salesFacade.InsertSalesRecord(cart, ReceiveDataId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblisDineIn.Text = IsDineIn ? "Order Type: Dine In" : "Order Type: Take Out";
            lblPM.Text = "Payment Method: " + PaymentMethod;
            lbl_orderNumber.Text = salesFacade.GenerateOrderNumber().ToString();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 200, 600);
            printDocument.PrintPage += new PrintPageEventHandler(PrintReceipt);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            previewDialog.ShowDialog();
        }

        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font regularFont = new Font("Courier New", 8);
            Font boldFont = new Font("Courier New", 8, FontStyle.Bold);
            int leftMargin = 5;
            int rightMargin = 140;
            float yPos = 5;
            int lineHeight = 12;

            g.DrawString("Ejay & Ashley Bulalohan", boldFont, Brushes.Black, leftMargin + 20, yPos);
            yPos += lineHeight;
            g.DrawString("Sizzling Steakhouse", boldFont, Brushes.Black, leftMargin + 20, yPos);
            yPos += 20;

            g.DrawString("POS: POS 1", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString("--------------------------------", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString(IsDineIn ? "Dine In" : "Take Out", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString("--------------------------------", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            g.DrawString($"Payment Method: {PaymentMethod}", boldFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            g.DrawString("--------------------------------", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;


            foreach (var item in cart.GetItems())
            {
                g.DrawString(item.FoodName, regularFont, Brushes.Black, leftMargin, yPos);
                g.DrawString($"₱{item.Price * item.Quantity:0.00}", regularFont, Brushes.Black, rightMargin, yPos);
                yPos += lineHeight;
                g.DrawString($"{item.Quantity} x ₱{item.Price:0.00}", regularFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
            }

            g.DrawString("--------------------------------", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString("Total", boldFont, Brushes.Black, leftMargin, yPos);
            g.DrawString($"₱{cart.GetTotalPrice():0.00}", boldFont, Brushes.Black, rightMargin, yPos);
            yPos += lineHeight;

            if (PaymentMethod == "Cash")
            {
                decimal changeAmount = (decimal)(CashAmount - cart.GetTotalPrice());
                g.DrawString($"Cash: ₱{CashAmount:0.00}", regularFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                g.DrawString($"Change: ₱{changeAmount:0.00}", regularFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
            }

            e.HasMorePages = false;
        }
    


}
}
