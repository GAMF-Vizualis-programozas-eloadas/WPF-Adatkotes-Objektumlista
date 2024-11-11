using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Adatkotes_Objektumlista
{
	public class Hallgató
	{
		public string Vezetéknév { get; set; }
		public string Keresztnév { get; set; }
		public string Neptun { get; set; }
		public string email { get; set; }
		public double GöngyölítettÁtlag { get; set; }

		public Hallgató(string VN, string KN, string N, string e, double GÁ)
		{
			Vezetéknév = VN;
			Keresztnév = KN;
			Neptun = N;
			email = e;
			GöngyölítettÁtlag = GÁ;
		}

		public Hallgató() : this("Nagyon", "Okos", "NAOKXX", "naok@net.hu", 3.24) { }

	}
}
