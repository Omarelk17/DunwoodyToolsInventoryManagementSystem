namespace DunwoodyToolsInventoryManagementSystem
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            InventoryToolStripMenuItem = new ToolStripMenuItem();
            ItemViewInventoryToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            pictureBox1 = new PictureBox();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { InventoryToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(946, 32);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // InventoryToolStripMenuItem
            // 
            InventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ItemViewInventoryToolStripMenuItem });
            InventoryToolStripMenuItem.Image = Properties.Resources.Item;
            InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem";
            InventoryToolStripMenuItem.Size = new Size(108, 28);
            InventoryToolStripMenuItem.Text = "Inventory";
            // 
            // ItemViewInventoryToolStripMenuItem
            // 
            ItemViewInventoryToolStripMenuItem.Name = "ItemViewInventoryToolStripMenuItem";
            ItemViewInventoryToolStripMenuItem.Size = new Size(224, 26);
            ItemViewInventoryToolStripMenuItem.Text = "View Inventory";
            ItemViewInventoryToolStripMenuItem.Click += ItemViewInventoryToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 532);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 19, 0);
            statusStrip.Size = new Size(946, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(381, 20);
            toolStripStatusLabel.Text = "Dunwoody Tools Inventory Management System © 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.Location = new Point(0, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(946, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 558);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardForm";
            Text = "Home";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem InventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemViewInventoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
