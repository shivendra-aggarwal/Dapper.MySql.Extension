using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    public class Parameter
    {
        public string DbColumnName { get; set; }

        public string ParamName { get; set; }

        public string Value { get; set; }
    }
}
