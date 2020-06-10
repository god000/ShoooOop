using System.Data.Entity;
using System.Linq;
using Storage.Models;

namespace Storage
{
    public class DataContext : DbContext
    {

        public DbSet<IBranch> Branches { get; set; }
        public DbSet<IItem> Items { get; set; }

        public void AddItem(IItem i)
        {
                Items.Add(i);
                SaveChanges();
        }

        public void DeleteItem(IItem i)
        {
            SaveChanges();
        }
        public void SetInfo(object a)
        {
            Entry(a).State = EntityState.Modified;
            SaveChanges();
        }
        public IBranch GetBranches(int id)
        {
            return Branches.Where(x => x.Id == id).FirstOrDefault();
        }
        
        public IItem GetItem(int id)
        {
            return Items.Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
