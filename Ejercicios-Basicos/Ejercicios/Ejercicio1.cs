using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Basicos.Ejercicios
{
    internal class Ejercicio1
    {
        public static void Ejecutar_Ejercicio1()
        {
            string Nickname;
            int xp;
            int UserPremium;
            bool User;

            Console.WriteLine("===== COMPLETA LOS SIGUIENTES DATOS =====");
            Console.Write("Ingrese su Nickname: ");
            Nickname = Console.ReadLine();
            Console.Write("Ingrese su xp: ");
            xp = int.Parse(Console.ReadLine());
            Console.Write("¿Eres usuario Premium? (1 para Sí, 0 para No): ");
            UserPremium = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (UserPremium == 1)
            {
                User = true;
            }
            else
            {
                User = false;

            }
        }
    }
}
