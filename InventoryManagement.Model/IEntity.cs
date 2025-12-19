using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    internal interface IEntity
    {
        int Id { get; set; }
        int CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        int UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
