using Desafio_02.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            #region Ubuntus
            var ubuntu1 = new Ubuntu()
            {
                Nome = "Ubuntu1 Silva",
                Idade = 33,
                Peso = 88.50,
                Altura = 2.10M,
                EhDev = true
            };
            var ubuntu2 = new Ubuntu()
            {
                Nome = "Ubuntu2 Santos",
                Idade = 26,
                Peso = 88.50,
                Altura = 1.65M,
                EhDev = true
            };
            var ubuntu3 = new Ubuntu()
            {
                Nome = "Ubuntu3 Silva",
                Idade = 85,
                Peso = 66.50,
                Altura = 1.40M,
                EhDev = false
            };

            List<Ubuntu> ubuntus = new List<Ubuntu>();
            ubuntus.Add(ubuntu1);
            ubuntus.Add(ubuntu2);
            ubuntus.Add(ubuntu3);
            #endregion

            #region T1
            //T1 - Somar a idade de todos Ubuntus
            var idadeSomada = ubuntus.Select(x => x.Idade).Sum();
            Console.WriteLine($"A idade dos ubuntus Somada é: {idadeSomada}\n");
            Console.ReadKey();
            #endregion

            #region T2
            //T2 - Agrupar os nomes de todos Ubuntus
            Console.WriteLine("Nome dos Ubuntus Agrupados:\n");
            foreach (var ubuntu in ubuntus)
            {
                Console.WriteLine($"{ubuntu.Nome}");
            }
            Console.ReadKey();
            Console.WriteLine("\n");
            #endregion

            #region T3
            Console.WriteLine("Calculando Imc de todos os ubuntus\n");
            var ubuntu1Imc = (decimal)ubuntu1.Peso / (ubuntu1.Altura * ubuntu1.Altura);
            var ubuntu2Imc = (decimal)ubuntu2.Peso / (ubuntu2.Altura * ubuntu2.Altura);
            var ubuntu3Imc = (decimal)ubuntu3.Peso / (ubuntu3.Altura * ubuntu3.Altura);

            Console.WriteLine($"o Imc do primeiro Ubuntu é: {ubuntu1Imc.ToString("F2")}");
            Console.WriteLine($"o Imc do segundo Ubuntu é: {ubuntu2Imc.ToString("F2")}");
            Console.WriteLine($"o Imc terceiro Ubuntu é: {ubuntu3Imc.ToString("F2")}");
            Console.ReadKey();
            #endregion

            #region T4
            //T4 - Contar quantos Ubuntus sao Devs
            Console.WriteLine("\nQuantidade de Ubuntus Devs:");
            Console.WriteLine($"{ubuntus.Where(x => x.EhDev == true).Count()}\n");
            Console.ReadKey();
            #endregion

            #region T5

            //T5 - Exibir somente Ubuntu com nome Silva
            Console.WriteLine("Ubuntus com Silva no Nome: \n");

            var Silvas = ubuntus.Where(x => x.Nome.ToUpper().Contains("SILVA")).Select(x => x.Nome).ToList();
            foreach (var Silvinha in Silvas)
            {
                Console.WriteLine($"{Silvinha}");
            }
            Console.ReadKey();

            #endregion

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
