using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoinPostal
{
	class delstat
	{
		private Dictionary<string, int> breaks;//header, length

		public delstat()
		{
			breaks = new Dictionary<string, int>();
			breaks.Add("ZipCode", 5);
			breaks.Add("UpdateKeyNumber", 10);
			breaks.Add("ActionCode", 1);
			breaks.Add("CarrierRouteID", 4);
			breaks.Add("Centralized Count", 5);
			breaks.Add("Curb Count", 5);
			breaks.Add("NDCBU Count", 5);
			breaks.Add("Other Count", 5);
			breaks.Add("Facility Box Count", 5);
			breaks.Add("Contract Box Count", 5);
			breaks.Add("Detached Box Count", 5);
			breaks.Add("NPU Count", 5);
			breaks.Add("Caller Service Box Count", 5);
			breaks.Add("Remittance Box Count", 5);
			breaks.Add("Contest Box Count", 5);
			breaks.Add("Other Box Count", 5);
			breaks.Add("Centralized Count_1", 5);
			breaks.Add("Curb Count_1", 5);
			breaks.Add("NDCBU Count_1", 5);
			breaks.Add("Other Count_1", 5);
			breaks.Add("Facility Box Count_1", 5);
			breaks.Add("Contract Box Count_1", 5);
			breaks.Add("Detached Box Count_1", 5);
			breaks.Add("NPU Count_1", 5);
			breaks.Add("Caller Service Box Count_1", 5);
			breaks.Add("Remittance Box Count_1", 5);
			breaks.Add("Contest Box Count_1", 5);
			breaks.Add("Other Box Count_1", 5);
			breaks.Add("General Delivery_1", 5);
			breaks.Add("Centralized Count_2", 5);
			breaks.Add("Curb Count_2", 5);
			breaks.Add("NDCBU Count_2", 5);
			breaks.Add("Other Count_2", 5);
			breaks.Add("Facility Box Count_2", 5);
			breaks.Add("Contract Box Count_2", 5);
			breaks.Add("Detached Box Count_2", 5);
			breaks.Add("NPU Count_2", 5);
			breaks.Add("Caller Service Box Count_2", 5);
			breaks.Add("Remittance Box Count_2", 5);
			breaks.Add("Contest Box Count_2", 5);
			breaks.Add("Other Box Count_2", 5);
			breaks.Add("Centralized Count_3", 5);
			breaks.Add("Curb Count_3", 5);
			breaks.Add("NDCBU Count_3", 5);
			breaks.Add("Other Count_3", 5);
			breaks.Add("Facility Box Count_3", 5);
			breaks.Add("Contract Box Count_3", 5);
			breaks.Add("Detached Box Count_3", 5);
			breaks.Add("NPU Count_3", 5);
			breaks.Add("Caller Service Box Count_3", 5);
			breaks.Add("Remittance Box Count_3", 5);
			breaks.Add("Contest Box Count_3", 5);
			breaks.Add("Other Box Count_3", 5);
			breaks.Add("General Delivery", 5);
			breaks.Add("Families Served Count", 5);
			breaks.Add("Residential Mixed Count", 5);
			breaks.Add("Business Mixed Count", 5);
			breaks.Add("Finance Number", 6);
			breaks.Add("State Abbreviation", 2);
			breaks.Add("County Code", 3);
			breaks.Add("Municipality City State Key", 6);
			breaks.Add("Preferred Last Line City State Key", 6);

		}
		public void Parse(string inputstring)
		{
			Int32 vals = inputstring.Length - 309;
			Int32 index = 309;
			List<row> rows = new List<row>();
			while (vals > 0)
			{
				List<string> r = new List<string>();
				foreach (KeyValuePair<string, int> kvp in breaks)
				{
					r.Add(inputstring.Substring(index, kvp.Value));
					index += kvp.Value;
					vals -= kvp.Value;
				}
				row rr = new row(r);
				rows.Add(rr);
				Console.WriteLine(rr.ToCSV());
			}
			Console.WriteLine(rows.Count + " rows processed");
		}
	}
}
