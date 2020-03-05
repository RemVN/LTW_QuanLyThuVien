using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien
{
    class FilterObject
    {
        string feildName;
        object value;

        public FilterObject(string fieldName, object value)
        {
            FeildName = fieldName;
            Value = value;
        }

        public string FeildName { get => feildName; set => feildName = value; }
        public object Value { get => value; set => this.value = value; }
    }
}
