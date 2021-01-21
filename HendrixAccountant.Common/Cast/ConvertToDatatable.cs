using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;


namespace HendrixAccountant.Common.Cast
{
    public class ConvertToDatatable
    {
        public static DataTable FromList<T>(IList<T> list)
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable();
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
