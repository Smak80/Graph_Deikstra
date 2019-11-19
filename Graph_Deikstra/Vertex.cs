using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Deikstra
{
	class Vertex
	{
		public uint Label { get; set; }
		public bool Visited { get; set; }

		public Vertex()
		{
			Label = uint.MaxValue;
			Visited = false;
		}
	}

	class Edge
	{
		public uint From { get; private set; }
		public uint To { get; private set; }
		public decimal Value { get; set; }

	}
}
