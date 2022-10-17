using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HarrisEducationDB
{
    public class DataManager


        private object values;

    public DataTable toDataTable<T>(List<T> items)
    {
        DataTable dt = new DataTable(typeof(T)Name);
        PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo prop in props)
        {
            dt.Columns.Add(prop.name);
            foreach (T item in items)
                object[] values = new object[props.Length];
            for (int i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(Item, null);
            }
            dt.Rows.Add(values);
        }
        return dt;




    }
