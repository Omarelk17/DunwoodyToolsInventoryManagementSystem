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
    public partial class ListInventoryForm : Form
    {
        private InventoryRepository _inventoryRepository;
        public ListInventoryForm()
        {
            _inventoryRepository = new InventoryRepository();
            InitializeComponent();
            LoadInventoryData(string.Empty);
        }


        private void LoadInventoryData(string searchTxt = null)
        {

            // Fetch inventory items from the repository
            List<Inventory> inventoryItems = _inventoryRepository.GetAllInventoryItems(searchTxt);

            // Bind the list of inventory items to the DataGridView
            gridInventory.DataSource = inventoryItems;

            gridInventory.Columns["InventoryPicture"].Visible = false;
            gridInventory.Columns["CreatedAt"].Visible = false;
            gridInventory.Columns["Description"].Visible = false;

            // Change the header text for existing columns
            gridInventory.Columns["InventoryId"].HeaderText = "ID";
            gridInventory.Columns["InventoryName"].HeaderText = "Name";
            gridInventory.Columns["CategoryName"].HeaderText = "Category";
            gridInventory.Columns["Status"].HeaderText = "Status";
            gridInventory.Columns["CreatedAt"].HeaderText = "Date Created";



            // Add the "View" button column if it’s not already added
            if (gridInventory.Columns["btnView"] == null)
            {
                var btnView = new DataGridViewButtonColumn();
                btnView.Name = "btnView";
                btnView.HeaderText = "View";
                btnView.Text = "View";
                btnView.UseColumnTextForButtonValue = true;
                gridInventory.Columns.Add(btnView);
            }

            // Add the "Update" button column if it’s not already added
            if (gridInventory.Columns["btnUpdate"] == null)
            {
                var btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = "Update";
                btnUpdate.Text = "Update";
                btnUpdate.UseColumnTextForButtonValue = true;
                gridInventory.Columns.Add(btnUpdate);
            }

            // Add the "Delete" button column if it’s not already added
            if (gridInventory.Columns["btnDelete"] == null)
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                gridInventory.Columns.Add(btnDelete);
            }

            // Subscribe to the CellPainting event
            gridInventory.CellPainting +=GridInventory_CellPainting;
        }



        private void gridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button cell and a valid row
            if (e.RowIndex >= 0)
            {
                int inventoryId = (int)gridInventory.Rows[e.RowIndex].Cells["InventoryId"].Value;

                if (e.ColumnIndex == gridInventory.Columns["btnView"].Index)
                {
                    // load in view mode
                    AddInventoryForm addInventoryForm = new AddInventoryForm(true, inventoryId);
                    addInventoryForm.Show();
                }
                else if (e.ColumnIndex == gridInventory.Columns["btnUpdate"].Index)
                {
                    // load inventory form in edit mode
                    AddInventoryForm addInventoryForm = new AddInventoryForm(false, inventoryId);
                    addInventoryForm.InventoryItemSaved += LoadInventoryData;
                    addInventoryForm.Show();

                }
                else if (e.ColumnIndex == gridInventory.Columns["btnDelete"].Index)
                {
                    // Handle the "Delete" button click
                    var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        _inventoryRepository.DeleteInventoryItem(inventoryId);
                        MessageBox.Show("Inventory item deleted successfully.");
                        LoadInventoryData(string.Empty); // Refresh the grid after deletion
                    }
                }
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTxt = txtSearch.Text;
            LoadInventoryData(searchTxt);
        }
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadInventoryData(string.Empty);
        }

        // Cell Painting event handler
        private void GridInventory_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if we are painting one of the button columns
            if (e.RowIndex >= 0 && (e.ColumnIndex == gridInventory.Columns["btnView"].Index ||
                                    e.ColumnIndex == gridInventory.Columns["btnUpdate"].Index ||
                                    e.ColumnIndex == gridInventory.Columns["btnDelete"].Index))
            {
                // Set the background color based on the button type
                Color buttonColor;
                if (e.ColumnIndex == gridInventory.Columns["btnView"].Index)
                {
                    buttonColor = Color.LavenderBlush; // View button color
                }
                else if (e.ColumnIndex == gridInventory.Columns["btnUpdate"].Index)
                {
                    buttonColor = Color.Azure; // Update button color
                }
                else // Delete button
                {
                    buttonColor = Color.IndianRed; // Delete button color
                }

                // Fill the cell background
                using (Brush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                // Draw the button text
                TextRenderer.DrawText(e.Graphics, e.Value?.ToString(), e.CellStyle.Font, e.CellBounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Prevent default painting
                e.Handled = true;
            }
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AddInventoryForm addInventoryForm = new AddInventoryForm(false, null);
            addInventoryForm.InventoryItemSaved += LoadInventoryData;
            addInventoryForm.Show();

        }
    }
}
