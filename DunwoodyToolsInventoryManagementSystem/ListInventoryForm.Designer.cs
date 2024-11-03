namespace DunwoodyToolsInventoryManagementSystem
{
    partial class ListInventoryForm
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
        /// 

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddInventory = new Button();
            btnLoadAll = new Button();
            SearchBtn = new PictureBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gridInventory = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddInventory);
            panel1.Controls.Add(btnLoadAll);
            panel1.Controls.Add(SearchBtn);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(gridInventory);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(53, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 873);
            panel1.TabIndex = 16;
            // 
            // btnAddInventory
            // 
            btnAddInventory.BackColor = Color.IndianRed;
            btnAddInventory.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAddInventory.ForeColor = SystemColors.ButtonHighlight;
            btnAddInventory.Location = new Point(42, 23);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(327, 40);
            btnAddInventory.TabIndex = 6;
            btnAddInventory.Text = "Add Inventory";
            btnAddInventory.UseVisualStyleBackColor = false;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.BackColor = Color.IndianRed;
            btnLoadAll.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLoadAll.ForeColor = SystemColors.ButtonHighlight;
            btnLoadAll.Location = new Point(379, 23);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(327, 40);
            btnLoadAll.TabIndex = 5;
            btnLoadAll.Text = "Reload All";
            btnLoadAll.UseVisualStyleBackColor = false;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Image = Properties.Resources.search;
            SearchBtn.Location = new Point(668, 119);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(38, 35);
            SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchBtn.TabIndex = 4;
            SearchBtn.TabStop = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(182, 128);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(480, 26);
            txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(42, 131);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(134, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Inventory";
            // 
            // gridInventory
            // 
            gridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridInventory.BackgroundColor = SystemColors.ButtonHighlight;
            gridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridInventory.Location = new Point(-1, 188);
            gridInventory.Name = "gridInventory";
            gridInventory.RowHeadersWidth = 51;
            gridInventory.Size = new Size(778, 594);
            gridInventory.TabIndex = 1;
            gridInventory.CellContentClick += gridInventory_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(42, 83);
            label1.Margin = new Padding(13, 0, 13, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 42);
            label1.TabIndex = 0;
            label1.Text = "Inventory List";
            // 
            // ListInventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(880, 910);
            Controls.Add(panel1);
            Name = "ListInventoryForm";
            Text = "List Inventory Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView gridInventory;
        private TextBox txtSearch;
        private Label lblSearch;
        private PictureBox SearchBtn;
        private Button btnLoadAll;
        private Button button1;
        private Button btnAddInventory;
    }
}