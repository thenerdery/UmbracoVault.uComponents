using System;
using System.Collections.Generic;
using UmbracoVault.Attributes;
using UmbracoVault.uComponents.Attributes;
using uComponents.DataTypes.UrlPicker.Dto;

namespace ReferenceWebsite.Models
{
    /// <summary>
    /// Model containing a URLPickerState property
    /// </summary>
    [UmbracoEntity(AutoMap = true)]
    public class UComponentsUrlModel
    {
        public UrlPickerState UrlState { get; set; }
    }

    /// <summary>
    /// Row model for a uComponents DataType Grid
    /// </summary>
    [UmbracoEntity(AutoMap = true)]
    public class UComponentsDataTypeGridItem
    {
        public string TextString { get; set; }
        //public DateTime DatePicker { get; set; }
        //TODO: Re-enable support for DateTime once included in Core
        public Person ContentPicker { get; set; }
        public string[] CheckboxList { get; set; }
        public MediaItem MediaPicker { get; set; } //MediaItem is a class with the `UmbracoMediaEntity` attribute

    }

    /// <summary>
    /// Model containing a DataTypeGrid
    /// </summary>
    [UmbracoEntity(AutoMap = true)]
    public class UComponentsDataTypeGridModel
    {
        [UmbracoDataTypeGridProperty]
        public List<UComponentsDataTypeGridItem> DataTypeGrid { get; set; }
    }
}