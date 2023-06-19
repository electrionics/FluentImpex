using System;
using FluentImpex.Converters.Common.Base;

namespace FluentImpex.Converters.Common.Default
{
    public class StringConverter:BaseConverter<string>
    {
        public override object ConvertStringValue(Type propertyType, string value, string additionalValue = null)
        {
            return value == string.Empty ? null : value;
        }

        public override string ValidateString(Type propertyType, string value)
        {
            return null;
        }
    }
}