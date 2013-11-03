using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _005_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(1 / x);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("dividiu por zero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("o número é muito grande");
            }
            catch (FormatException)
            {
                Console.WriteLine("digite um núúúúúmero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

                throw new MyException("erro na bagaça", ex);
            }

            Console.ReadKey();
        }
    }

    class MyException : Exception
    {
        public MyException(String msg = "sem mensagem", Exception ex = null)
            : base(msg)
        {

            using (var arquivo = new StreamWriter(String.Format("log-{0}.txt", DateTime.Now.ToString("yyyy-MM-dd")), true, Encoding.UTF8))
            {
                arquivo.WriteLine("{0} -> {1} ({2})", DateTime.Now.ToString("HH:mm:ss.fff"), "MyException", msg);

                if (ex != null)
                    arquivo.WriteLine("  {0} ({1})", ex.GetType().Name, ex.Message);

                arquivo.Close();
            }
        }
    }
}
