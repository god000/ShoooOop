using System.Collections.Generic;
using Storage.Models;

namespace Storage
{
    public interface IStorageService
    {
        DataContext Db { get; }
        void AddItem(IItem i);
        void DeleteItem(IItem i);
        void SetInfo(object obj);
        bool CheckCanAddItem(IItem i, string category);
        List<IItem> GetItemFromBranche(int id);
        IItem GetItem(int id);

    }
}
