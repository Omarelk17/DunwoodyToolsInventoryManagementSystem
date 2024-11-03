namespace DunwoodyToolsInventoryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }



        private void ItemViewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListInventoryForm listInventoryForm = new ListInventoryForm();

            listInventoryForm.Show();
        }

        
        
    }
}
