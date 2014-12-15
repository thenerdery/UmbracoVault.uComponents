﻿using System;

namespace Nerdery.Umbraco.Vault.TypeHandlers.Primitives
{
    public class FloatTypeHandler : ITypeHandler
    {
        private object Get(string stringValue)
        {
            float result;

            float.TryParse(stringValue, out result);

            return result;
        }

        public object GetAsType<T>(object input)
    	{
			return Get(input.ToString());
    	}

        public Type TypeSupported
        {
            get { return typeof (float); }
        }
    }
}