using System;
using System.Collections.Generic;
using System.Linq;

using uComponents.DataTypes.UrlPicker.Dto;

using UmbracoVault.TypeHandlers;

namespace UmbracoVault.uComponents.TypeHandlers
{
    /// <summary>
    ///     Used for binding Url Picker data types from Umbraco to strongly typed objects
    /// </summary>
    public class UrlPickerStateTypeHandler : ITypeHandler
    {
        private static UrlPickerState Get(object value)
        {
            var urlPickerState = value as UrlPickerState ?? (UrlPickerState.Deserialize(value.ToString()) ?? new UrlPickerState { NewWindow = false, Title = string.Empty, Url = string.Empty });

            return urlPickerState;
        }

        public object GetAsType<T>(object input)
        {
            return Get(input);
        }

        public Type TypeSupported => typeof(UrlPickerState);
    }
}