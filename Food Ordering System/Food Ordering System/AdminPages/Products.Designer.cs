namespace Food_Ordering_System.AdminPages
{
    partial class Products
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Unavailable = new System.Windows.Forms.CheckBox();
            this.outOfStock = new System.Windows.Forms.CheckBox();
            this.categoryFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.MainDish = new System.Windows.Forms.Button();
            this.Appetizer = new System.Windows.Forms.Button();
            this.Dessert = new System.Windows.Forms.Button();
            this.Drinks = new System.Windows.Forms.Button();
            this.Others = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.categoryfilterTimer = new System.Windows.Forms.Timer(this.components);
            this.FilterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.categoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(188, 157);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Padding = new System.Windows.Forms.Padding(20);
            this.flpProducts.Size = new System.Drawing.Size(1092, 634);
            this.flpProducts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 85);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lists of Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 20);
            this.panel3.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.flowLayoutPanel2.Controls.Add(this.checkBox1);
            this.flowLayoutPanel2.Controls.Add(this.Unavailable);
            this.flowLayoutPanel2.Controls.Add(this.outOfStock);
            this.flowLayoutPanel2.Controls.Add(this.categoryFilter);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 105);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 686);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(10, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(10, 30, 0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(10, 2, 21, 2);
            this.checkBox1.Size = new System.Drawing.Size(154, 35);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Available";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Unavailable
            // 
            this.Unavailable.AutoSize = true;
            this.Unavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.Unavailable.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unavailable.ForeColor = System.Drawing.Color.White;
            this.Unavailable.Location = new System.Drawing.Point(10, 75);
            this.Unavailable.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Unavailable.Name = "Unavailable";
            this.Unavailable.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Unavailable.Size = new System.Drawing.Size(156, 34);
            this.Unavailable.TabIndex = 27;
            this.Unavailable.Text = "Unavailable";
            this.Unavailable.UseVisualStyleBackColor = false;
            this.Unavailable.CheckedChanged += new System.EventHandler(this.Unavailable_CheckedChanged);
            // 
            // outOfStock
            // 
            this.outOfStock.AutoSize = true;
            this.outOfStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.outOfStock.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStock.ForeColor = System.Drawing.Color.White;
            this.outOfStock.Location = new System.Drawing.Point(10, 119);
            this.outOfStock.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.outOfStock.Name = "outOfStock";
            this.outOfStock.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.outOfStock.Size = new System.Drawing.Size(154, 30);
            this.outOfStock.TabIndex = 28;
            this.outOfStock.Text = "Out Of Stock";
            this.outOfStock.UseVisualStyleBackColor = false;
            this.outOfStock.CheckedChanged += new System.EventHandler(this.outOfStock_CheckedChanged);
            // 
            // categoryFilter
            // 
            this.categoryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.categoryFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryFilter.Controls.Add(this.FilterButton);
            this.categoryFilter.Controls.Add(this.MainDish);
            this.categoryFilter.Controls.Add(this.Appetizer);
            this.categoryFilter.Controls.Add(this.Dessert);
            this.categoryFilter.Controls.Add(this.Drinks);
            this.categoryFilter.Controls.Add(this.Others);
            this.categoryFilter.Controls.Add(this.all);
            this.categoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryFilter.Location = new System.Drawing.Point(10, 159);
            this.categoryFilter.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.categoryFilter.MaximumSize = new System.Drawing.Size(150, 240);
            this.categoryFilter.MinimumSize = new System.Drawing.Size(129, 36);
            this.categoryFilter.Name = "categoryFilter";
            this.categoryFilter.Size = new System.Drawing.Size(150, 36);
            this.categoryFilter.TabIndex = 26;
            // 
            // MainDish
            // 
            this.MainDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.MainDish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDish.ForeColor = System.Drawing.Color.White;
            this.MainDish.Location = new System.Drawing.Point(2, 36);
            this.MainDish.Margin = new System.Windows.Forms.Padding(2);
            this.MainDish.Name = "MainDish";
            this.MainDish.Size = new System.Drawing.Size(150, 30);
            this.MainDish.TabIndex = 1;
            this.MainDish.Text = "Main Dish";
            this.MainDish.UseVisualStyleBackColor = false;
            this.MainDish.Click += new System.EventHandler(this.MainDish_Click);
            // 
            // Appetizer
            // 
            this.Appetizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Appetizer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appetizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appetizer.ForeColor = System.Drawing.Color.White;
            this.Appetizer.Location = new System.Drawing.Point(2, 70);
            this.Appetizer.Margin = new System.Windows.Forms.Padding(2);
            this.Appetizer.Name = "Appetizer";
            this.Appetizer.Size = new System.Drawing.Size(150, 30);
            this.Appetizer.TabIndex = 2;
            this.Appetizer.Text = "Appetizer";
            this.Appetizer.UseVisualStyleBackColor = false;
            this.Appetizer.Click += new System.EventHandler(this.Appetizer_Click);
            // 
            // Dessert
            // 
            this.Dessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Dessert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dessert.ForeColor = System.Drawing.Color.White;
            this.Dessert.Location = new System.Drawing.Point(2, 104);
            this.Dessert.Margin = new System.Windows.Forms.Padding(2);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(150, 30);
            this.Dessert.TabIndex = 3;
            this.Dessert.Text = "Dessert";
            this.Dessert.UseVisualStyleBackColor = false;
            this.Dessert.Click += new System.EventHandler(this.Dessert_Click);
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.ForeColor = System.Drawing.Color.White;
            this.Drinks.Location = new System.Drawing.Point(2, 138);
            this.Drinks.Margin = new System.Windows.Forms.Padding(2);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(150, 30);
            this.Drinks.TabIndex = 4;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = false;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // Others
            // 
            this.Others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Others.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Others.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Others.ForeColor = System.Drawing.Color.White;
            this.Others.Location = new System.Drawing.Point(2, 172);
            this.Others.Margin = new System.Windows.Forms.Padding(2);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(150, 30);
            this.Others.TabIndex = 5;
            this.Others.Text = "Others";
            this.Others.UseVisualStyleBackColor = false;
            this.Others.Click += new System.EventHandler(this.Others_Click);
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.all.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.ForeColor = System.Drawing.Color.White;
            this.all.Location = new System.Drawing.Point(2, 206);
            this.all.Margin = new System.Windows.Forms.Padding(2);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(150, 30);
            this.all.TabIndex = 6;
            this.all.Text = "(ALL CATEGORY)";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // categoryfilterTimer
            // 
            this.categoryfilterTimer.Interval = 10;
            this.categoryfilterTimer.Tick += new System.EventHandler(this.categoryfilterTimer_Tick);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.Image = global::Food_Ordering_System.Resource1.panel;
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.Location = new System.Drawing.Point(2, 2);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(150, 30);
            this.FilterButton.TabIndex = 0;
            this.FilterButton.Text = "Category";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Food_Ordering_System.Resource1.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.BorderRadius = 15;
            this.txt_search.BorderThickness = 3;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.IconLeft = global::Food_Ordering_System.Resource1.search2;
            this.txt_search.IconLeftSize = new System.Drawing.Size(40, 35);
            this.txt_search.Location = new System.Drawing.Point(188, 105);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search menu";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(1092, 52);
            this.txt_search.TabIndex = 22;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(170, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 686);
            this.panel1.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(188, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 20);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1280, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 686);
            this.panel5.TabIndex = 28;
            // 
            // Products
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1298, 791);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.categoryFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel categoryFilter;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button MainDish;
        private System.Windows.Forms.Button Appetizer;
        private System.Windows.Forms.Button Dessert;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button Others;
        private System.Windows.Forms.Timer categoryfilterTimer;
        private System.Windows.Forms.CheckBox Unavailable;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.CheckBox outOfStock;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
