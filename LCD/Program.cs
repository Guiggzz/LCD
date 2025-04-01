using System;

namespace LCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> ");
            var line = Console.ReadLine();
            var number = uint.Parse(line);

            switch (number)
            {
                case 0: Zero(); break;
                case 1: One(); break;
                case 2: Two(); break;
                case 3: Three(); break;
                case 4: Four(); break;
                case 5: Five(); break;
                case 6: Six(); break;
                case 7: Seven(); break;
                case 8: Eight(); break;
                case 9: Nine(); break;
            }
        }

        private static void Zero() => Console.WriteLine("""
                                                          _  
                                                         | | 
                                                         | | 
                                                         |_| 
                                                        """);

        private static void One() => Console.WriteLine("""
                                                           
                                                         | 
                                                         | 
                                                           
                                                       """);

        private static void Two() => Console.WriteLine("""
            
                                                         _  
                                                         _| 
                                                        |_  
                                                         
            
            """);

        private static void Three() => Console.WriteLine("""
                                                           _  
                                                           _| 
                                                           _| 
                                                           
                                                           """);

        private static void Four() => Console.WriteLine("""
                                                             
                                                         |_|
                                                           |
                                                           
                                                        """);

        private static void Five() => Console.WriteLine("""
                                                          _  
                                                         |_  
                                                          _| 
                                                          
                                                        """);

        private static void Six() => Console.WriteLine("""
                                                         _  
                                                        |_  
                                                        |_|
                                                         
                                                       """);

        private static void Seven() => Console.WriteLine("""
                                                           _  
                                                            | 
                                                            | 
                                                            
                                                         """);

        private static void Eight() => Console.WriteLine("""
                                                           _  
                                                          |_|
                                                          |_|
                                                          
                                                         """);

        private static void Nine() => Console.WriteLine("""
                                                          _  
                                                         |_|
                                                          _| 
                                                          
                                                        """);
    }
}