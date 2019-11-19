using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Deikstra
{
	class Graph
	{
		private Vertex[] v;
		private decimal[,] e;
		private string[] path;

		private uint VertexCount
		{
			get { return (uint)e.GetLength(0); }
		}

		public Graph(decimal[,] graph)
		{
			Array.Copy(
				graph, 
				e, 
				graph.Length
				);
			v = new Vertex[VertexCount];
			for (uint i = 0; i < VertexCount; i++)
			{
				v[i] = new Vertex(/*i+1*/);
			}
		}

		private Vertex GetMinV()
		{
			uint i = 0;
			while (v[i].Visited) i++;
			uint min = i;
			while (i < VertexCount)
			{
				if (v[i].Label < v[min].Label && !v[i].Visited)
					min = i;
				i++;
			}

			return v[min];
		}

		public void CalcShortestPath(uint from, uint to)
		{
			v[from].Label = 0;
			for (uint i = 0; i < VertexCount - 1; i++)
			{
				Vertex currentV = GetMinV();
			}
		}

	}
}
