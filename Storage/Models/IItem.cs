using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Models
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        int PriseBuy { get; set; }
        int PriseSell { get; set; }
        int dateProduction { get; set; }
        int ShelfLife { get; set; }
        string Type { get; set; }
    }
}
