using DunwoodyToolsInventoryManagementSystem.Models;
using DunwoodyToolsInventoryManagementSystem.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem
{
    public partial class AddInventoryForm : Form
    {
        private readonly InventoryRepository _inventoryRepository;
        public bool IsViewMode = false;
        private int? _inventoryID;
        public AddInventoryForm(bool isViewMode, int? inventoryID)
        {
            InitializeComponent();
            _inventoryRepository = new InventoryRepository();
            txtInventoryName.Focus();
            IsViewMode=isViewMode;
            _inventoryID=inventoryID;

            // view mode
            if (_inventoryID.HasValue && IsViewMode)
            {
                Inventory inventory = _inventoryRepository.GetInventoryItemById(_inventoryID.Value);
                LoadInventoryControls(inventory);
                DisableAllControls();
                btnSave.Text = "Save";
                btnSave.Enabled = false;
                btnSave.ForeColor = Color.White;
                btnBrowse.ForeColor = Color.White;
                btnBrowse.Enabled = false;
                panel1.BackColor = Color.LavenderBlush;
                lblHeading.Text = "View Inventory Item";
                this.Text = "View Inventory Form";
                

            }
            // edit mode
            else if (_inventoryID.HasValue)
            {
                _inventoryRepository.GetInventoryItemById(_inventoryID.Value);
                Inventory inventory = _inventoryRepository.GetInventoryItemById(_inventoryID.Value);
                LoadInventoryControls(inventory);
                EnableAllControls();
                btnSave.Text = "Update";
                btnSave.Enabled = true;
                btnBrowse.Enabled = true;
                panel1.BackColor = Color.Azure;
                lblHeading.Text = "Update Inventory Item";
                this.Text = "Update Inventory Form";
            }
            // add a new record
            else
            {
                EnableAllControls();
                ClearAllFields();
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                btnBrowse.Enabled = true;
                panel1.BackColor = Color.White;
                lblHeading.Text = "Add Inventory Item";
                this.Text = "Add Inventory Form";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxInventory.ImageLocation = openFileDialog.FileName;
                }
            }
        }
        public event Action<string> InventoryItemSaved;
        public event Action<string> InventoryItemAdded;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var inventoryItem = new Inventory
                {
                    InventoryId = _inventoryID.HasValue ? _inventoryID.Value : 0, // Set the ID for the update
                    InventoryName = txtInventoryName.Text,
                    CategoryName = comboBoxCategory.SelectedItem.ToString(),
                    Status = radioButtonInStock.Checked ? "In Stock" : "Out of Stock",
                    Description = rtbDescription.Text,
                    InventoryPicture = pictureBoxInventory.Image != null ? ImageToByteArray(pictureBoxInventory.Image) : null,
                    CreatedAt = DateTime.Now // You might want to avoid updating CreatedAt on update
                };

                if (_inventoryID.HasValue)
                {
                    // If in edit mode, update the item
                    bool updated = _inventoryRepository.UpdateInventoryItem(inventoryItem);

                    if (updated)
                    {
                        MessageBox.Show("Inventory item updated successfully.");
                        InventoryItemSaved?.Invoke(string.Empty); // Trigger the event
                    }
                    else
                    {
                        MessageBox.Show("Failed to update inventory item.");
                    }
                }
                else
                {
                    // If in add mode, insert the item
                    int? id = _inventoryRepository.AddInventoryItem(inventoryItem);

                    if (id != null)
                    {
                        _inventoryID = id.Value; // Save the ID for potential future updates
                        btnSave.Text = "Update"; // Change the button text to Update
                        btnSave.Enabled = true; // Enable the button for updates
                        btnBrowse.Enabled = true; // Enable browse button
                        MessageBox.Show("Inventory item saved successfully.");
                        InventoryItemAdded?.Invoke(string.Empty); // Notify that a new item was added
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInventoryControls(Inventory inventoryItem)
        {
            if (inventoryItem != null)
            {
                // Load the controls with the data from the inventory item
                txtInventoryName.Text = inventoryItem.InventoryName;
                comboBoxCategory.SelectedItem = inventoryItem.CategoryName; // Ensure this matches your ComboBox's data
                radioButtonInStock.Checked = inventoryItem.Status == "In Stock";
                radioButtonOutOfStock.Checked = inventoryItem.Status == "Out of Stock";
                rtbDescription.Text = inventoryItem.Description;

                // Load the image if it exists
                if (inventoryItem.InventoryPicture != null)
                {
                    using (var ms = new MemoryStream(inventoryItem.InventoryPicture))
                    {
                        pictureBoxInventory.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxInventory.Image = null;
                }
            }
            else
            {
                ClearAllFields();
            }
        }

        private bool ValidateInputs()
        {
            lblError.Text = ""; // Clear previous error messages

            if (string.IsNullOrWhiteSpace(txtInventoryName.Text))
            {
                lblError.Text = "Inventory name is required.";
                return false;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                lblError.Text = "Category is required.";
                return false;
            }

            if (!radioButtonInStock.Checked && !radioButtonOutOfStock.Checked)
            {
                lblError.Text = "Availability status is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                lblError.Text = "Description is required.";
                return false;
            }

            if (pictureBoxInventory.Image == null)
            {
                lblError.Text = "Inventory picture is required.";
                return false;
            }

            return true;
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


        private void ClearAllFields()
        {
            txtInventoryName.Text = string.Empty;

            // Reset the category combo box selection
            comboBoxCategory.SelectedIndex = -1; // Set to -1 to clear selection

            // Reset the status radio buttons (uncheck both)
            radioButtonInStock.Checked = false;
            radioButtonOutOfStock.Checked = false;

            // Clear the description rich text box
            rtbDescription.Text = string.Empty;

            // Clear the inventory picture from the picture box
            pictureBoxInventory.Image = null;

            // Reset any error label (if used for validation messages)
            lblError.Text = string.Empty;

            // Optionally, reset the save button text and state if necessary
            btnSave.Text = "Save"; // Reset to default text
            btnSave.Enabled = true;
        }

        // Method to enable all relevant form controls
        private void EnableAllControls()
        {
            txtInventoryName.Enabled = true;
            comboBoxCategory.Enabled = true;
            radioButtonInStock.Enabled = true;
            radioButtonOutOfStock.Enabled = true;
            rtbDescription.Enabled = true;
            pictureBoxInventory.Enabled = true;
            btnBrowse.Enabled = true; // Enable browse button if needed
            btnSave.Enabled = true;
        }

        // Method to disable all relevant form controls
        private void DisableAllControls()
        {
            txtInventoryName.Enabled = false;
            comboBoxCategory.Enabled = false;
            radioButtonInStock.Enabled = false;
            radioButtonOutOfStock.Enabled = false;
            rtbDescription.Enabled = false;
            pictureBoxInventory.Enabled = false;
            btnBrowse.Enabled = false; // Disable browse button if needed
            btnSave.Enabled = false;
        }





    }
}
