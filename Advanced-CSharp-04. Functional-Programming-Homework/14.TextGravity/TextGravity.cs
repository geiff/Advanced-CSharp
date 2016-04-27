using System;
using System.Security;

namespace _14.TextGravity
{
    class TextGravity
    {
        static void Main()
        {
            int colSize = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int rowSize = 0;

            if (text.Length % colSize == 0)
            {
                rowSize = text.Length / colSize;
            }
            else
            {
                rowSize = text.Length / colSize + 1;
            }

            char[,] matrix = new char[rowSize, colSize];

            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (index < text.Length)
                    {
                        matrix[row, col] = text[index];
                        index++;
                    }
                    else
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }


            bool isFull = true;
            while (isFull)
            {
                isFull = false;
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row + 1, col] == ' ' && matrix[row, col] != ' ')
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                            isFull = true;
                        }
                    }
                }
            }

            Console.Write("<table>");
            for (int rowi = 0; rowi < matrix.GetLength(0); rowi++)
            {
                Console.Write("<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("<td>" + SecurityElement.Escape(matrix[rowi, col].ToString()) + "</td>");
                }

                Console.Write("</tr>");
            }

            Console.WriteLine("</table>");
        }
    }
}
