using System;
using System.Collections.Generic;
using System.Linq;

using UmbracoVault.Attributes;

namespace ReferenceWebsite.Models
{
    [UmbracoEntity(AutoMap = true)]
    public class Location
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}