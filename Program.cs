namespace MoneyGram
{
    class Program
    {
       static void Main(string [] args)
        {   
            
            // START.
            Console.Clear();
            
            Console.WriteLine(@"
                ______  ___                                  _________                                     _____ 
                ___   |/  /______ _______ _____ _____  __    __  ____/______ _______ ___   _______ __________  /_
                __  /|_/ / _  __ \__  __ \_  _ \__  / / /    _  /     _  __ \__  __ \__ | / /_  _ \__  ___/_  __/
                _  /  / /  / /_/ /_  / / //  __/_  /_/ /     / /___   / /_/ /_  / / /__ |/ / /  __/_  /    / /_  
                /_/  /_/   \____/ /_/ /_/ \___/ _\__, /      \____/   \____/ /_/ /_/ _____/  \___/ /_/     \__/  
                                                /____/                                                           
            ");
            Console.WriteLine("                                                   PRESS ENTER TO START");
            Console.WriteLine("                                                   --------------------");
            Console.ReadKey();
            int opcion = 0;
            do
            {
                //Console.Clear();
                Console.WriteLine(@"

                                                SELECCIONE LA MONEDA QUE POSEE: 
                                                ==============================
                                                
                                                [1]    (RD$) - PESO.
                                                [2]    (US$) - DOLLAR.
                                                [3]    (E$)  - EURO.
                                                [4]         EXIT.
                    
                ");

                opcion = int.Parse(Console.ReadLine()!);
                switch(opcion)
                {
                    //  CONVERSION DE PESO.
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (US$) - DOLLAR.
                            [2]    (E$)  - EURO.
                        ");
                    
                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A DOLLAR: ");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[RD$ {num}] EN DOLLAR ES IGUAL A: [{PesosToDolares(num)} $US]");
                                Console.ReadKey();
                            }
                            break;

                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A EURO");
                                Console.WriteLine("-------------------");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[RD$ {num}] EN EURO ES IGUAL A: [{PesosToEuros(num)} EU$]");
                                Console.ReadKey();

                            }
                            break;
                        
                            default:
                            {
                                Console.WriteLine("RELOADING...");
                                Console.WriteLine("------------");
                                Thread.Sleep(3000);
                            }
                            break;
                        
                        }

                    }
                    break;

                    //  CONVERSION DE DOLLAR.

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (RD$) - PESO.
                            [2]    (EU$) - EURO.
                        ");
                    
                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A PESO: ");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[US$ {num}] EN PESO ES IGUAL A: [{DollarToPeso(num)} RD$]");
                                Console.ReadKey();
                            }
                            break;

                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A EURO");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[US$ {num}] EN EURO ES IGUAL A: [{DollarToEuro(num)} EU$]");
                                Console.ReadKey();

                            }
                            break;
                        
                            default:
                            {
                                Console.WriteLine("RELOADING...");
                            }
                            break;
                        }   
                    }
                    break;

                    // CONVERSION DE EURO.

                    case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (RD$) - PESO.
                            [2]    (US$) - DOLLAR.
                        ");
                    
                        int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                        switch(opcion1)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A PESO: ");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[EU$ {num}] EN PESO ES IGUAL A: [{EuroToPeso(num)} RD$]");
                                Console.ReadKey();
                            }
                            break;

                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("CONVIRTIENDO A DOLLAR");
                                Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                int num = Convert.ToInt32(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine($"[EU$ {num}] EN DOLLAR ES IGUAL A: [{EuroToDollar(num)} US$]");
                                Console.ReadKey();
                            }
                            break;
                        
                            default:
                            {
                                Console.WriteLine("RELOADING...");
                            }
                            break;
                        }   
                    }
                    break;

                    // SALIENDO.

                    case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("SALIENDO");
                        Thread.Sleep(3000);
                    }
                    break;

                
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("USTED VE ESA OPCION?!");
                        Console.ReadKey();
                    }
                    break;
                }
                Console.Clear();
            
            }while(opcion != 4);
        }

        //      FUNCIONES.    //
        public static double PesosToDolares(double pesos)
        // funcion que convierte de pesos dominicanos a dólares estadounidenses
        {
            return pesos * 0.018;
        } 

        public static double PesosToEuros(double pesos) 
        {
          // funcion de convertir de pesos dominicanos a euros  
          return pesos * 0.017;
        }
        public static double DollarToPeso(double dollar)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return dollar * 55.01;
        }
    
        public static double DollarToEuro(double dollar)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return dollar * 0.9172;
        }
    
        public static double EuroToPeso(double Euro)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return Euro * 60.04;
        }

        public static double EuroToDollar(double Euro)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return Euro * 1.0903;
        }
    }   

}