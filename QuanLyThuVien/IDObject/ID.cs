using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.IDObject
{
    public class ID : EditableObject
    {
        string id;
        public ID()
        {
        }

        public bool isValidID()
        {
            if (id == null) return false;
            if(id.Equals("")) return false;
            return true;
        }
        public string Id { get => id; set => id = value; }
    }
}
