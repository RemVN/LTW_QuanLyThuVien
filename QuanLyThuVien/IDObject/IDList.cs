using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.IDObject
{
    public class IDList<T> : List<T> where T : ID
    {
        public IDList()
        {
        }

        public IDList(List<T> list)
        {
            this.AddRange(list);
        }

        public T getByID(string id)
        {
            foreach(T obj in this)
            {
                if (obj.Id.Equals(id)) return obj;
            }
            return null;
        }

        public void removeById(string id)
        {
            foreach (T obj in this.Reverse<T>())
            {
                if (obj.Id.Equals(id)) this.Remove(obj);
            }
        }

    }
}
