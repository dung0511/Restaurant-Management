namespace Project_PRN211
{
    partial class frmTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txtTotalPrice = new TextBox();
            nudDiscount = new NumericUpDown();
            btnCheckOut = new Button();
            panel4 = new Panel();
            btnAddFood = new Button();
            nudFoodCount = new NumericUpDown();
            cbxFood = new ComboBox();
            cbxCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1080, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(87, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(220, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(220, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(554, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 415);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(517, 409);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 150;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(nudDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(554, 579);
            panel3.Name = "panel3";
            panel3.Size = new Size(517, 101);
            panel3.TabIndex = 0;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = Color.Black;
            txtTotalPrice.Location = new Point(271, 39);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(125, 34);
            txtTotalPrice.TabIndex = 9;
            txtTotalPrice.Text = "0";
            // 
            // nudDiscount
            // 
            nudDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudDiscount.Location = new Point(129, 39);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(129, 34);
            nudDiscount.TabIndex = 6;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(402, 16);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(97, 73);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(nudFoodCount);
            panel4.Controls.Add(cbxFood);
            panel4.Controls.Add(cbxCategory);
            panel4.Location = new Point(551, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(517, 98);
            panel4.TabIndex = 3;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(405, 12);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(97, 73);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // nudFoodCount
            // 
            nudFoodCount.Location = new Point(313, 36);
            nudFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudFoodCount.Name = "nudFoodCount";
            nudFoodCount.Size = new Size(76, 27);
            nudFoodCount.TabIndex = 2;
            nudFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxFood
            // 
            cbxFood.FormattingEnabled = true;
            cbxFood.Location = new Point(17, 57);
            cbxFood.Name = "cbxFood";
            cbxFood.Size = new Size(279, 28);
            cbxFood.TabIndex = 1;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(17, 12);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(279, 28);
            cbxCategory.TabIndex = 0;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 54);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(524, 626);
            flpTable.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 10;
            label1.Text = "Giảm giá:";
            // 
            // frmTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 705);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTable";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private NumericUpDown nudFoodCount;
        private ComboBox cbxFood;
        private ComboBox cbxCategory;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nudDiscount;
        private Button btnCheckOut;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
        private Label label1;
    }
}