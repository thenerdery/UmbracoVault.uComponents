using System;
using System.Collections.Generic;
using System.Linq;

using UmbracoVault.Attributes;

namespace ReferenceWebsite.Models
{
    [UmbracoMediaEntity(AutoMap = true)]
    public class MediaItem
    {
        [UmbracoProperty(Alias = "umbracoFile")]
        public string Url { get; set; }
        public string Alt { get; set; }
    }
}