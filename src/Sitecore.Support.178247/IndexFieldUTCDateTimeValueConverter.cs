using Sitecore.Abstractions;
using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ContentSearch.Converters
{
    public class IndexFieldUTCDateTimeValueConverter : Sitecore.ContentSearch.Converters.IndexFieldUtcDateTimeValueConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            //Sitecore.Support.178247
            culture = CultureInfo.InvariantCulture;                      
            return base.ConvertTo(context, culture, value, destinationType);
            //
        }
    }
}