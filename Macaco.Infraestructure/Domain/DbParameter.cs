using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Macaco.Infraestructure.Domain
{
    [AttributeUsage(AttributeTargets.All)]
    public class DbParameterAttribute : Attribute
    {
        public string ParameterName { get; set; }
    }
}
