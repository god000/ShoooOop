using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Storage.Models;

namespace Storage
{
    public class StorageService : DropCreateDatabaseIfModelChanges<DbContext>, IStorageService
    {
        private DataContext db;
        public DataContext Db => db;

        

        public StorageService()
        {
            db = new DataContext();            
        }

                
        public void SetInfo(object obj)
        {
            db.SetInfo(obj);
        }
        

        public void AddItem(IItem i)
        {
            db.AddItem(i);
        }

        public void DeleteItem(IItem i)
        {
            db.DeleteItem(i);
        }

        public bool CheckCanAddItem(IItem i, string category)
        {
            throw new NotImplementedException();
        }

        public IItem GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<IItem> GetItemFromBranche(int id)
        {
            throw new NotImplementedException();
        }
    }
}
