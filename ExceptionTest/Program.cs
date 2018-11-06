using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            Console.Write("Insere um membro inteiro: ");

            try {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch (OverflowException) {
                double doublee = Convert.ToDouble(i);
                Console.WriteLine("Agora é um double");
            }
            catch (FormatException) {
                string str = Convert.ToString(i);
                Console.WriteLine("Agora é uma string");
            }
            catch (Exception e) {
                Console.WriteLine("Bum! Erro: " + e.Message);
            }
        }
    }
}
