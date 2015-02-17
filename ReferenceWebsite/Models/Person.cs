using System;
using System.Collections.Generic;
using System.Linq;

using UmbracoVault.Attributes;

namespace ReferenceWebsite.Models
{

    [UmbracoEntity(AutoMap = true)]
    public class Person
    {
        public string Name { get; set; }
        public Location PrimaryLocation { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, PrimaryLocation);
        }
    }
}