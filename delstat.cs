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
		public void ConvertToCSV(string inputstring, string outputDestination)
		{
			Int32 vals = inputstring.Length - 309;
			Int32 rowsEst = vals / 309;
			rowsEst = rowsEst / 10;
			Int32 index = 309;
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(new System.IO.FileStream(outputDestination,System.IO.FileMode.CreateNew)))
			{
				string header = "";
				foreach (KeyValuePair<string, int> kvp in breaks)
				{
					header += kvp.Key + ",";
				}
				header.TrimEnd(new char[] { ',' });
				sw.WriteLine(header);
				int counter = 0;
				int groupsComplete = 0;
				Console.Write("Percent Complete: 0 ");
				while (vals > 0)
				{
					List<string> r = new List<string>();
					if ("d".Equals(inputstring.Substring(index, 1).ToLower()))
					{
						index += 1;
						vals -= 1;
					}
					else
					{
						return;
					}
					foreach (KeyValuePair<string, int> kvp in breaks)
					{
						if (kvp.Value.Equals("ZipCode"))
						{
							r.Add("'"+inputstring.Substring(index, kvp.Value));
						}
						else
						{
							r.Add(inputstring.Substring(index, kvp.Value));
						}
						index += kvp.Value;
						vals -= kvp.Value;
					}
					row rr = new row(r);
					sw.Write(rr.ToCSV());
					counter += 1;
					if (counter % rowsEst == 0)
					{
						groupsComplete += 1;
						Console.Write((groupsComplete * 10) + " " );
					}

				}
				Console.WriteLine("100");
			}
		}
	}
}
