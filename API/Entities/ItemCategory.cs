using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ItemCategory : BaseEntity
    {
        public int Id { get; set; }
        // Food,Clothing,Electronics,Home and Garden are some industries.It is food for our project.
        public string BusinessType { get; set; } 
        public string Name { get; set; }
    }
}