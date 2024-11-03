namespace DunwoodyToolsInventoryManagementSystem
{
    partial class AddInventoryForm
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
            lblStatus = new Label();
            radioButtonInStock = new RadioButton();
            radioButtonOutOfStock = new RadioButton();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblPicture = new Label();
            pictureBoxInventory = new PictureBox();
            btnBrowse = new Button();
            lblError = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            comboBoxCategory = new ComboBox();
            loginMessageLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            txtInventoryName = new TextBox();
            lblHeading = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInventory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(124, 248);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // radioButtonInStock
            // 
            radioButtonInStock.AutoSize = true;
            radioButtonInStock.Location = new Point(124, 269);
            radioButtonInStock.Margin = new Padding(4, 5, 4, 5);
            radioButtonInStock.Name = "radioButtonInStock";
            radioButtonInStock.Size = new Size(90, 24);
            radioButtonInStock.TabIndex = 3;
            radioButtonInStock.TabStop = true;
            radioButtonInStock.Text = "In Stock";
            radioButtonInStock.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutOfStock
            // 
            radioButtonOutOfStock.AutoSize = true;
            radioButtonOutOfStock.Location = new Point(124, 294);
            radioButtonOutOfStock.Margin = new Padding(4, 5, 4, 5);
            radioButtonOutOfStock.Name = "radioButtonOutOfStock";
            radioButtonOutOfStock.Size = new Size(123, 24);
            radioButtonOutOfStock.TabIndex = 4;
            radioButtonOutOfStock.TabStop = true;
            radioButtonOutOfStock.Text = "Out of Stock";
            radioButtonOutOfStock.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(124, 342);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 20);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(124, 367);
            rtbDescription.Margin = new Padding(4, 5, 4, 5);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(317, 90);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Location = new Point(124, 480);
            lblPicture.Margin = new Padding(4, 0, 4, 0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(139, 20);
            lblPicture.TabIndex = 9;
            lblPicture.Text = "Inventory Picture:";
            // 
            // pictureBoxInventory
            // 
            pictureBoxInventory.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory.Location = new Point(124, 505);
            pictureBoxInventory.Margin = new Padding(4, 5, 4, 5);
            pictureBoxInventory.Name = "pictureBoxInventory";
            pictureBoxInventory.Size = new Size(177, 103);
            pictureBoxInventory.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInventory.TabIndex = 10;
            pictureBoxInventory.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.IndianRed;
            btnBrowse.FlatAppearance.BorderColor = Color.IndianRed;
            btnBrowse.ForeColor = SystemColors.ButtonHighlight;
            btnBrowse.Location = new Point(321, 522);
            btnBrowse.Margin = new Padding(4, 5, 4, 5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(120, 35);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(124, 613);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(40, 659);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(273, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(321, 659);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(273, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxCategory);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(loginMessageLabel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBrowse);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBoxInventory);
            panel1.Controls.Add(txtInventoryName);
            panel1.Controls.Add(lblPicture);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(rtbDescription);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(radioButtonInStock);
            panel1.Controls.Add(radioButtonOutOfStock);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(58, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 758);
            panel1.TabIndex = 15;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(255, 192, 192);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FlatStyle = FlatStyle.Flat;
            comboBoxCategory.ForeColor = SystemColors.ControlText;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Hand Tools", "Power Tools", "Safety Gear" });
            comboBoxCategory.Location = new Point(124, 201);
            comboBoxCategory.Margin = new Padding(4, 5, 4, 5);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(317, 28);
            comboBoxCategory.TabIndex = 2;
            // 
            // loginMessageLabel
            // 
            loginMessageLabel.AutoSize = true;
            loginMessageLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginMessageLabel.ForeColor = Color.Red;
            loginMessageLabel.Location = new Point(197, 251);
            loginMessageLabel.Margin = new Padding(4, 0, 4, 0);
            loginMessageLabel.Name = "loginMessageLabel";
            loginMessageLabel.Size = new Size(0, 17);
            loginMessageLabel.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 0;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 0;
            label2.Text = "Inventory Name:";
            // 
            // txtInventoryName
            // 
            txtInventoryName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventoryName.Location = new Point(124, 131);
            txtInventoryName.Margin = new Padding(4, 5, 4, 5);
            txtInventoryName.Name = "txtInventoryName";
            txtInventoryName.Size = new Size(317, 30);
            txtInventoryName.TabIndex = 1;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.Font = new Font("Comic Sans MS", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Black;
            lblHeading.Location = new Point(27, 37);
            lblHeading.Margin = new Padding(13, 0, 13, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(224, 42);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Add Inventory";
            // 
            // AddInventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(786, 786);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddInventoryForm";
            Text = "Add Inventory Item";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInventory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radioButtonInStock;
        private System.Windows.Forms.RadioButton radioButtonOutOfStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.PictureBox pictureBoxInventory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Panel panel1;
        private Label loginMessageLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label lblInventoryName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblHeading;
    }
}