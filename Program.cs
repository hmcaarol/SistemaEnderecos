using System;
using System.Linq;

namespace SistemaEnderecos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do exercício:");
            string numeroExercicio = Console.ReadLine();

            if (numeroExercicio == "1" || numeroExercicio == "2")
            {
                ExercicioUmEDois();
            }
            else if (numeroExercicio == "3")
            {
                Console.WriteLine("Informe a letra do exercício:");
                string letraExercicio = Console.ReadLine();

                if (letraExercicio.ToLower() == "a")
                {
                    ExercicioTresA();
                }
                else if (letraExercicio.ToLower() == "b")
                {
                    ExercicioTresB();
                }
                else if (letraExercicio.ToLower() == "c")
                {
                    ExercicioTresC();
                }
                else if (letraExercicio.ToLower() == "d")
                {
                    ExercicioTresD();
                }
                else
                {
                    Console.WriteLine("Não há exercício para a letra informada.");
                }
            }
            else
            {
                Console.WriteLine("Não há exercício para o número informado.");
            }
        }

        static void ExercicioUmEDois()
        {
            Console.WriteLine("Informe o Endereço:");
            var endereco = Console.ReadLine();

            string[] arrayEndereco = endereco.Split(' ');
            string rua = null;
            string numero = null;

            for (int i = 0; i < arrayEndereco.Length; i++)
            {
                bool temDigito = false;

                char[] listaEndereco = arrayEndereco[i].ToArray();

                for (int y = 0; y < listaEndereco.Length; y++)
                {
                    if (char.IsDigit(listaEndereco[y]))
                    {
                        temDigito = true;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(numero))
                {
                    numero += arrayEndereco[i] + " ";
                }
                else
                {
                    if (!temDigito)
                    {
                        rua += arrayEndereco[i] + " ";
                    }
                    else
                    {
                        numero += arrayEndereco[i] + " ";
                    }
                }
            }

            if (!string.IsNullOrEmpty(rua))
                rua = rua.Trim();

            if (!string.IsNullOrEmpty(numero))
                numero = numero.Trim();

            Console.WriteLine($"A rua informada é '{rua}' e o número informado é '{numero}'");
        }

        static void ExercicioTresA()
        {
            Console.WriteLine("Informe o Endereço:");
            var endereco = Console.ReadLine();

            string[] arrayEndereco = endereco.Split(',');

            string rua = arrayEndereco[1];
            string numero = arrayEndereco[0];

            Console.WriteLine($"A rua informada é '{rua.Trim()}' e o número informado é '{numero.Trim()}'");
        }

        static void ExercicioTresB()
        {
            Console.WriteLine("Informe o Endereço:");
            var endereco = Console.ReadLine();

            string[] arrayEndereco = endereco.Split(' ');
            string rua = null;
            string numero = null;

            for (int i = 0; i < arrayEndereco.Length; i++)
            {
                bool temDigito = false;

                char[] listaEndereco = arrayEndereco[i].ToArray();

                for (int y = 0; y < listaEndereco.Length; y++)
                {
                    if (char.IsDigit(listaEndereco[y]))
                    {
                        temDigito = true;
                        break;
                    }
                }

                if (!temDigito)
                {
                    rua += arrayEndereco[i] + " ";
                }
                else
                {
                    numero += arrayEndereco[i] + " ";
                }
            }

            if (!string.IsNullOrEmpty(rua))
                rua = rua.Trim();

            if (!string.IsNullOrEmpty(numero))
                numero = numero.Trim();

            Console.WriteLine($"A rua informada é '{rua}' e o número informado é '{numero}'");
        }

        static void ExercicioTresC()
        {
            Console.WriteLine("Informe o Endereço:");
            var endereco = Console.ReadLine();

            string[] arrayEndereco = endereco.Split(',');

            string rua = arrayEndereco[0];
            string numero = arrayEndereco[1];

            Console.WriteLine($"A rua informada é '{rua.Trim()}' e o número informado é '{numero.Trim()}'");
        }

        static void ExercicioTresD()
        {
            Console.WriteLine("Informe o Endereço:");
            var endereco = Console.ReadLine();

            string[] arrayEndereco = endereco.Split(' ');
            string rua = null;
            string numero = null;
            bool jaIncluiuDigito = false;

            for (int i = 0; i < arrayEndereco.Length; i++)
            {
                bool temDigito = false;

                char[] listaEndereco = arrayEndereco[i].ToArray();

                for (int y = 0; y < listaEndereco.Length; y++)
                {
                    if (char.IsDigit(listaEndereco[y]))
                    {
                        temDigito = true;
                        break;
                    }
                }

                if (!jaIncluiuDigito)
                {
                    rua += arrayEndereco[i] + " ";
                }
                else
                {
                    numero += arrayEndereco[i] + " ";
                }

                if (temDigito)
                {
                    jaIncluiuDigito = true;
                }
            }

            if (!string.IsNullOrEmpty(rua))
                rua = rua.Trim();

            if (!string.IsNullOrEmpty(numero))
                numero = numero.Trim();

            Console.WriteLine($"A rua informada é '{rua}' e o número informado é '{numero}'");
        }
    }
}
