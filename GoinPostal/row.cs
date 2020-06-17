using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoinPostal
{
	public class row
	{
		private List<string> _values;
		public row(List<string> values)
		{
			_values = values;
		}
		public string ToCSV()
		{
			string ret = _values[0];
			for(int i = 1; i<_values.Count; i++  )
			{
				ret += "," + _values[i];
			}
			ret += Environment.NewLine;
			return ret;
		}
	}
}
