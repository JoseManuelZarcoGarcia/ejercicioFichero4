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

                // se mete en el array las filas del fichero
                string[] lineas = File.ReadAllLines(fichero);
                // se guarda la fila concreta
                string linea = lineas[numeroLinea - 1];

                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {

                    if (numeroPosicion >= 0 && numeroPosicion <= linea.Length)
                    {
                        Console.WriteLine("Que desea escribir: ");
                        string nuevoTexto = Console.ReadLine();

                        try 
                        {
                            string nuevaLinea = linea.Insert(numeroPosicion, nuevoTexto);
                            lineas[numeroLinea - 1] = nuevaLinea;

                            File.WriteAllLines(fichero,lineas);
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
asdqwezxcfghrtyvbn
1234567890
ajfsdkslfhjfyqweiufhdskjvnskjjddddddddddddd
                
             
             */

        }

    }

}