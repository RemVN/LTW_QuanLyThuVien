using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QuanLyThuVien
{
    class Filter<T> 
    {
        List<FilterObject> fieldList;

        internal List<FilterObject> FieldList { get => fieldList; set => fieldList = value; }

        public Filter()
        {
            FieldList = new List<FilterObject>();
        }

        public Filter<T> withField(string fieldName, object value)
        {
            FieldList.Add(new FilterObject(fieldName, value));
            return this;
        }

        public bool isFilteredObject(T obj)
        {
            int count = 0;
            foreach(FilterObject field in FieldList)
            {
                object value = getValue(obj, field.FeildName);
                if (value == null) continue;
                if (value.Equals(field.Value)) count++;
            }
            if (count == FieldList.Count) return true;
            else
            return false;
        }

        public object getValue(T obj, string field)
        {
            foreach (PropertyInfo info in obj.GetType().GetProperties())
            {
                if (info.Name.Equals(field)) return info.GetValue(obj, null);
            }
            return null;
        }

        public List<T> getFilteredList(List<T> originList)
        {
            List<T> filteredList = new List<T>();
            foreach(T obj in originList)
            {
                if (isFilteredObject(obj)) filteredList.Add(obj);
            }
            return filteredList;
        }

    }
}
