using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Storage.Models;
using Storage;

namespace ClinicStorage
{
    public interface IStorageService
    {
        DataContext Db { get; }
        void AddItem(IItem i);
        void DeleteItem(IItem i);
        void SetInfo(object obj);
        bool CheckCanAddItem(IItem i, string category);
        IBranch GetBranches(int id);
        IItem GetItem(int id);

    }
}
