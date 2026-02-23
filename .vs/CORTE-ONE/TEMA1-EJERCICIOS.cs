// @Henzo //
while (true)
{
    Console.WriteLine("===== EJERCICIOS TEMA 1 ===== \n1. Perfil de Usuario Gamer. \n2. Calculadora de Propina Solidaria. \n3. Control de Aforo en Eventos. \n4. Generador de Correos Corporativos. \n5. Simulador de Semáforo Inteligente.\n ");
    Console.Write("Elija una opción (1-5): ");
    int opcion = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcion)
    {
        case 1:
            bool Premium;
            Console.Write("===== INGRESE LOS SIGUIENTES DATOS ===== \nIngrese su Nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("Ingrese su nivel de experiencia (1 - 100): ");
            int xp = int.Parse(Console.ReadLine());
            Console.Write("Si tienes premium ingresa (1), de lo contrario ingrese (2): ");
            int UserPremium = int.Parse(Console.ReadLine());
            Console.WriteLine("\n=========================================");
            if (UserPremium == 1)
            {
                Premium = true;
                Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium está activa.");
            }
            else
            {
                Premium = false;
                Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium no está activa.");
            }
            Console.WriteLine("\n=========================================");
            Console.Write("Oprima enter para volver al menú.");
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine("===== INGRESE LOS SIGUIENTES DATOS =====: ");
            float TotalPagar = 0.0f;
            Console.Write("Ingrese el total de la cuenta: $ ");
            float totalCuenta = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el porcentaje de propina (10 - 15 - 20): ");
            float porcentajePropina = float.Parse(Console.ReadLine());
            if (porcentajePropina == 10)
            {
                TotalPagar += (totalCuenta + (totalCuenta * 0.10f));
            }
            else if (porcentajePropina == 15)
            {
                TotalPagar += (totalCuenta + (totalCuenta * 0.15f));
            }
            else if (porcentajePropina == 20)
            {
                TotalPagar += (totalCuenta + (totalCuenta * 0.20f));
            }

            if (TotalPagar > 1000)
            {
                Console.WriteLine($"\nEl total a pagar con propina es: ${TotalPagar} \n¡Gracias por tu generosidad!");
            }
            else
            {
                Console.WriteLine($"\nEl total a pagar con propina es: ${TotalPagar} \n¡Gracias por tu propina!.");
            }
            break;
    }
}