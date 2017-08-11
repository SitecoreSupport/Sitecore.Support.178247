using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace Sitecore.Support.ContentSearch.ComputedFields
{
    public class UpdatedDate : AbstractComputedIndexField
    {
        public override object ComputeFieldValue(IIndexable indexable)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Item item = (Item)(indexable as SitecoreIndexableItem);
            return item?.Statistics.Updated;
        }
    }
}