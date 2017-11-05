using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DbColumnName : Attribute
    {
        private string _columnName;

        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        private bool _isPrimary;

        public bool IsPrimary
        {
            get { return _isPrimary; }
            set { _isPrimary = value; }
        }


        public DbColumnName(string columnName, bool isPrimary = false)
        {
            this._columnName = columnName;
            this._isPrimary = IsPrimary;
        }
    }
}
