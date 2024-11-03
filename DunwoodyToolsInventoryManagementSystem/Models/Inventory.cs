using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyToolsInventoryManagementSystem.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public string CategoryName { get; set; }
        public byte[] InventoryPicture { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
