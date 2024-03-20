namespace ejercicioFichero4
{

    class Program
    {

        static void Main(string[] args)
        {

            string fichero = "C:\\Users\\csi22-jzarcia\\Desktop\\textoACambiar.txt";

            try
            {
                Console.WriteLine("En que linea deseas escribir: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("En que posicion deseas escribir: ");
                int numeroPosicion = Convert.ToInt32(Console.ReadLine());


                string[] lineas = File.ReadAllLines(fichero);
                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {

                    if (numeroPosicion >= 0 && numeroPosicion <= lineas.Length)
                    {
                        Console.WriteLine("Que desea escribir: ");
                        string nuevoTexto = Console.ReadLine();

                        lineas[numeroLinea - 1] = nuevoTexto;

                        File.WriteAllLines(fichero, lineas);

                        try 
                        {

                            string nuevoContenido = lineas[numeroLinea].Insert(numeroPosicion, nuevoTexto);

                            File.WriteAllText(fichero, nuevoContenido);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(Console.Error);
                        }
                        
                        Console.WriteLine("El texto se ha escrito correctamente en la posición especificada.");
                    }
                    else
                    {
                        Console.WriteLine("La posición especificada está fuera del rango del archivo.");
                    }
                }
                else
                {
                    Console.WriteLine("La linea en la que desea escribir esta fuera de rango");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + e.Message);
            }

            /*
             
             
                jajajajajajajajajajaja
                patatapatata
                asd qwe zxc fgh rty vbn
                               
                ajfsdkslfhjfyqweiufhdskjvnskjjddddddddddddd
                
             
             */

        }

    }

}