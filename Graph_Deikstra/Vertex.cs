using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Deikstra
{
	class Vertex
	{
		/**
		 * Номер вершины графа
		 */
		public uint Number { get; private set; }
		/**
		 * Метка, равная длине кратчайшего пути на текущем шаге алгоритма до данной вершины из начальной 
		 */
		public decimal Label { get; set; }
		/**
		 * Признак того, что вершина уже рассмотрена
		 */
		public bool Visited { get; set; }
		/**
		 * Путь к вершине. Содержит последовательность номеров вершин от начальной
		 * до текущей (на данном шаге алгоритма), обеспечивающих наикратчайший путь.
		 */
		public string Path { get; set; }

		/**
		 * Константа для пометки бесконечно удаленной вершины 
		 */
		public static readonly uint INFINITY = uint.MaxValue;

		public Vertex(uint number)
		{
			Label = INFINITY;
			Visited = false;
			Number = number;
			Path = Number.ToString();
		}
	}

	/*class Edge
	{
		public uint From { get; private set; }
		public uint To { get; private set; }
		public decimal Value { get; set; }

	}*/
}