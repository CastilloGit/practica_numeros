using System;

namespace pinta_nros
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 7;
            string asterisk = "*";
            string espacio = "";

            Console.WriteLine("Letra R: ");
            for(int row=0; row < lenght; row++)
            {
                for(int column = 0; column < lenght; column++)
                {
                      Console.Write(
                        (column == 0) ||
                        ((row == 0 || row == 4) && column < 4) ||
                        (column == 4 && (row == 0 || row == 3 || row == 5)) ||
                        (column == 5 && (row == 1 || row == 2 || row == 6))
                    ? asterisk : " ");

                }
                Console.WriteLine(espacio);
            }

            Console.WriteLine("Letra I: ");
            for(int fila = 0; fila < lenght; fila++)
            {
                for(int col=0; col < lenght; col++)
                {
                      Console.Write(
                        ((fila == 0 ) && (col > 0 && col < 6)) ||
                        (col == 3) ||
                        ((fila == 6 ) && (col > 0 && col < 6))
                    ? asterisk : " ");

                }
                Console.WriteLine(espacio);
            }            
        }
    }
}
