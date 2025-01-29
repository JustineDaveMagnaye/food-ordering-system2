using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Ordering_System.src.main.appl.model;

namespace Food_Ordering_System.views.modal
{
    public partial class CashAmount : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners(Control control, int radius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }
        public CashAmount()
        {
            InitializeComponent();
            HookEvents();
            ApplyRoundedCorners(this, 50);
        }
        public int Amount { get; set; }

        public int totalAmount { get; set; }


        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }
        private void HookEvents()
        {
            txt_amount.GotFocus += (s, e) =>
            {
                txt_amount.FillColor = System.Drawing.Color.White;
                txt_amount.PlaceholderForeColor = System.Drawing.Color.FromArgb(255, 65, 51);
                txt_amount.ForeColor = System.Drawing.Color.FromArgb(255, 65, 51);
            };
            txt_amount.LostFocus += (s, e) =>
            {
                txt_amount.FillColor = System.Drawing.Color.FromArgb(255, 65, 51);
                txt_amount.PlaceholderForeColor = Color.White;
                txt_amount.ForeColor = Color.White;
            };
        }

        private void done_Click(object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(txt_amount.Text, out amount))
            {
                if(amount - totalAmount < 0)
                {
                    errorUser.Text = "Not enough money, the total is: " + totalAmount.ToString();
                } else
                {
                    Amount = amount;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                errorUser.Text = "Please input a valid number";
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
