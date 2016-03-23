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
        public DateTime DatePicker { get; set; }
        public Person ContentPicker { get; set; }
        public string[] CheckboxList { get; set; }
        public MediaItem MediaPicker { get; set; } //MediaItem is a class with the `UmbracoMediaEntity` attribute
        public int Numeric { get; set; }
        public string SimpleEditor { get; set; }
        public bool TrueFalse { get; set; }
        public string TextboxMultiple { get; set; }
        public UrlPickerState UrlPicker { get; set; }
        public string Dropdown { get; set; }
        public string[] DropdownMultiple { get; set; }
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