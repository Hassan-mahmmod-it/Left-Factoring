using System;
using System.IO;
using System.Collections;
namespace console
{
	class program
	{

		public static void Main()
		{
			String[] data = File.ReadAllLines(@"C:\\Users\\AL Manar\\Desktop\\test.txt");
			char[] N = new char[data.Length];
			char[] b = new char[data.Length];
			char[] symplye = { 'a', 'b', 'c', 'd' };
			char[] production = { 'A', 'B', 'C', 'E' };
			char swap = 'Q';
			int z = 0;
			for (int i = 0; i < data.Length; i++)
			{
				N = data[i].ToCharArray();
				b = data[i].ToCharArray();
			}
			for (int i = 1; i < N.Length; i++)
			{
				for (int j = 0; j < symplye.Length; j++)
				{

					if (N[i] == production[j])
					{

						N[i] = ' ';
						N[i] = swap;
					}
					if (N[i] == '|')
					{
						z = i;
					}
				}

			}
			for (int i = z; i < N.Length; i++)
			{
				N[i] = ' ';
			}
			for (int i = 0; i < N.Length; i++)
				Console.Write(N[i]);

			Console.Write('\n');
			for (int i = 1; i < b.Length; i++)
			{
				for (int j = 0; j < symplye.Length; j++)
				{
					if (b[i] == symplye[j])
					{
						b[i] = ' ';
					}
				}
				b[0] = swap;
			}
			Console.Write('\n');
			for (int i = 0; i < b.Length; i++)
			{
				Console.Write(b[i]);
			}

		}
	}
}