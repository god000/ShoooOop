namespace Storage.Models
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get ; set ; }
        public int PriseBuy { get ; set; }
        public int PriseSell { get ; set ; }
        public int dateProduction { get ; set ; }
        public int ShelfLife { get; set ; }
        public string Type { get ; set ; }
        public int IdBranch { get ; set; }
    }
}
