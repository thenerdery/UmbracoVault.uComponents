using System;
using System.Collections.Generic;
using System.Linq;

using UmbracoVault.Attributes;
using UmbracoVault.uComponents.TypeHandlers;

namespace UmbracoVault.uComponents.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UmbracoDataTypeGridPropertyAttribute : UmbracoPropertyAttribute
    {
        public UmbracoDataTypeGridPropertyAttribute()
        {
            TypeHandler = new DataTypeGridTypeHandler();
        }

        /// <summary>
        ///     Only needed if the camelCase name of the property is not the same as the umbraco property alias
        /// </summary>
        /// <param name="name"></param>
        public UmbracoDataTypeGridPropertyAttribute(string name)
            : base(name)
        {
            TypeHandler = new DataTypeGridTypeHandler();
        }
    }
}