namespace parte1
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.Clear();
            Console.WriteLine(@"
               ___                                   ,__ __               _                    
              / (_)                                 /|  |  |             | |    o              
             |      __   _  _         _   ,_  _|_    |  |  |   __,   __  | |        _  _    _  
             |     /  \_/ |/ |  |  |_|/  /  |  |     |  |  |  /  |  /    |/ \   |  / |/ |  |/  
              \___/\__/   |  |_/ \/  |__/   |_/|_/   |  |  |_/\_/|_/\___/|   |_/|_/  |  |_/|__/
                                                                                                
                                                                                                                                                                                        
            ");
            Console.WriteLine("                                       PRESS ENTER TO START");
            Console.WriteLine("-                                      --------------------");
            Console.ReadKey();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
                       MAIN MENU
                     -------------

                [1]     CELSIUS.
                [2]     FAHRENHEIT.
                [3]     KELVIN.
                [4]     EXIT.
                
                ");

                
                Console.WriteLine("            SELECCIONE LA OPCION QUE DESEA: ");
                Console.WriteLine("            ------------------------------- ");
                opcion = int.Parse(Console.ReadLine()!);


                switch(opcion)
                {
                    
                    //  CONVERSION DE CELSIUS.
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1] FAHRENHEIT.

                            [2] KELVIN.
                        ");
                    
                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                            Console.Clear();
                            Console.WriteLine("CONVIRTIENDO DE CELSIUS A FAHRENHEIT.");
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                            double num = Convert.ToDouble(Console.ReadLine()!);
                            // double Resultado = ((num * 9/5) + 32);
                            Console.Clear();
                            Console.WriteLine($"{num}°C CONVERTIDOS A FAHRENHEIT ES IGUAL A: {CelsiusToFarenheit(num)} °F");
                            Console.ReadKey();
                            }
                            break;

                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO DE CELSIUS A KELVIN");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                double num = Convert.ToDouble(Console.ReadLine()!);
                                //double Resultado = (num + 273.15);
                                Console.Clear();
                                Console.WriteLine($"{num}°C CONVERTIDOS A KELVIN ES IGUAL A: {CelsiusToKelvin(num)} °K");
                                Console.ReadKey();
                            }
                            break;

                            default:
                            {
                                Console.Clear();
                                Console.WriteLine("SELECCION INCORRECTA!");
                                Console.ReadKey();
                            }
                            break;
                            
                        }
                    
                    }break;
                    

                    //  CONVERSION DE FAHRENHEIT.

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------
                        
                            [1] CELSIUS.

                            [2] KELVIN.
                        ");
                    
                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO DE FAHRENHEIT A CELSIUS.");
                                Console.WriteLine("-------------------------------------");
                                Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                double num = Convert.ToDouble(Console.ReadLine()!);
                                double Resultado = ((num - 32) * 5/9);
                                Console.Clear();
                                Console.WriteLine($"{num}°F CONVERTIDOS A CELSIUS ES IGUAL A: {Resultado} °C");
                                Console.ReadKey();
                            }
                            break;
                            
                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO DE FAHRENHEIT A KELVIN.");
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                double num = Convert.ToDouble(Console.ReadLine()!);
                                double Resultado = (((num - 32) * 5/9) + 273.15);
                                Console.Clear();
                                Console.WriteLine($"{num}°F CONVERTIDOS A KELVIN ES IGUAL A: {Resultado} °K");
                                Console.ReadKey();
                            }
                            break;

                            default:
                            {
                                Console.Clear();
                                Console.WriteLine("SELECCION INCORRECTA!");
                            }
                            break;

                        }
                    
                    }
                    break;

                    // CONVERSION DE KELVIN

                    case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1] CELSIUS.
                        
                            [2] FAHRENHEIT.
                        ");

                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO DE KELVIN A CELSIUS.");
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                double num = Convert.ToDouble(Console.ReadLine()!);
                                double Resultado = (num - 273.15);
                                Console.Clear();
                                Console.WriteLine($"{num}°K CONVERTIDOS A CELSIUS ES IGUAL A: {Resultado} °C");
                                Console.ReadKey();
                            }
                            break;
                            
                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO DE KELVIN A FAHRENHEIT.");
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                double num = Convert.ToDouble(Console.ReadLine()!);
                                double Resultado = (((num - 273.15) * 9/5) + 32);
                                Console.Clear();
                                Console.WriteLine($"{num}°C CONVERTIDOS A KELVIN ES IGUAL A: {Resultado} °F");
                                Console.ReadKey();
                            }
                            break;

                        }
                    }
                    break;
                    

                    case 4:
                    {
                        Console.Clear();
                        Console.WriteLine(@"CERRANDO PROGRAMA...");
                        Thread.Sleep(3000);
                    }
                    break;
                    
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("PANA USTED VE ESA OPCION?");
                        Console.ReadKey();
                    }
                    break;
                }
            
            }
            while(opcion != 4);
            
        }


        // FUNCIONES.
        public static double CelsiusToFarenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}