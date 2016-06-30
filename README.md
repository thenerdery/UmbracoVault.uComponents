#uComponents Support for Umbraco Vault

[![NuGet](https://img.shields.io/nuget/v/UmbracoVault.uComponents.svg?style=flat-square)](https://www.nuget.org/packages/UmbracoVault.uComponents)
[![Build status](https://img.shields.io/appveyor/ci/TheNerdery/umbracovault-uComponents.svg?style=flat-square)](https://ci.appveyor.com/project/TheNerdery/umbracovault-uComponents)
[![License](https://img.shields.io/github/license/thenerdery/UmbracoVault.uComponents.svg?style=flat-square)](https://github.com/thenerdery/UmbracoVault.uComponents/blob/master/LICENSE)

## Supported Data Types

The following uComponents data types are currently supported:

### UrlPicker

Create a property on your object with the type `uComponents.DataTypes.UrlPicker.Dto.UrlPickerState`.

Example:
```csharp
[UmbracoEntity(AutoMap = true)]
public class MyViewModel
{
    public string Name { get; set; }
    public string Location { get; set; }
    public UrlPickerState ExternalLink { get; set; }
}
```

### DataType Grid

Create a property and add the attribute `UmbracoVault.uComponents.Attributes.UmbracoDataTypeGridProperty`

The following field types have been tested:

 * Textstring
 * Checkbox list
 * Content Picker - can use Object mapping to map to another document type.
 * Media Picker
 * Numeric (only supports integers, limitation of Umbraco itself)
 * Dropdown
 * Dropdown Multiple

These field types are _NOT_ yet supported:

 * Date Picker
 * Date Picker with Time
 * Url Picker

Example Usage - Umbraco Document View Model
```csharp
[UmbracoEntity(AutoMap = true)]
public class UComponentsDataTypeGridModel
{        
    [UmbracoDataTypeGridProperty]
    public List<UComponentsDataTypeGridItem> DataTypeGrid { get; set; }
    public string SomeOtherProperty { get; set; }
}
```

The row view model is just the same as a standard model you would map for any other document type. In the example for `UCompnentsDataTypeGridItem` above:

Example Usage - DataType Grid Row View Model
```csharp
[UmbracoEntity(AutoMap = true)]
public class UComponentsDataTypeGridItem
{
    public string TextString { get; set; }
    public Person ContentPicker { get; set; }
    public string[] CheckboxList { get; set; } //Currently returns prevalue from Umbraco http://bit.ly/1qWCPXO
    public MediaItem MediaPicker { get; set; } //MediaItem is a class with the `UmbracoMediaEntity` attribute
    public int Numeric { get; set; }
    public bool TrueFalse { get; set; }
    public string TextboxMultiple { get; set; }
    public string Dropdown { get; set; } //Currently returns prevalue from Umbraco http://bit.ly/1qWCPXO
    public string[] DropdownMultiple { get; set; } //Currently returns prevalue from Umbraco http://bit.ly/1qWCPXO
}
```
