using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Utils
{
	public static class Extensions
	{
        public static List<Dictionary<string, string>> ToListOfDictionaries(this Table table)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            if (table.Rows.Count == 0)
            {
                throw new InvalidOperationException("Gherkin data table has no rows");
            }

            return table.Rows.Select(x => x.ToDictionary(x => x.Key, x => x.Value)).ToList();
        }
    }
}
