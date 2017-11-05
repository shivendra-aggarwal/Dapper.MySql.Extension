using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DbTableNameAttribute : Attribute
    {
        public DbTableNameAttribute(string tableName)
        {
            _tableName = tableName;
        }

        private string _tableName;

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

    }
}
