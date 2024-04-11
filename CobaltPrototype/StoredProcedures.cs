using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltPrototype
{
    public class StoredProcedures
    {
        public const string GetData = "[cp].[GetTableData]";
        public const string Filter = "[cp].[Filter]";
        //Other Filters
        public const string RangeFilter = "[cp].[RangeFilter]";
        public const string NotHasAnyOfFilter = "[cp].[NotHasAnyOfFilter]";
        public const string NotContainsFilter = "[cp].[NotContainsFilter]";
        public const string LessThanOrEqualToFilter = "[cp].[LessThanOrEqualToFilter]";
        public const string LessThanFilter = "[cp].[LessThanFilter]";
        public const string HasOneOfFilter = "[cp].[HasOneOfFilter]";
        public const string GreaterThanOrEqualToFilter = "[cp].[GreaterThanOrEqualToFilter]";
        public const string GreaterThanFilter = "[cp].[GreaterThanFilter]";
        public const string EqualsFilter = "[cp].[EqualsFilter]";
        public const string ContainsFilter = "[cp].[ContainsFilter]";
    }
}
