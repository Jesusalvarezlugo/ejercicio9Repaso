namespace ejercicio9Repaso
{
    class Program
    {
        public static void Main(string[] args)
        {
            string frase;
            List<string> listaFrase = new List<string>();
            string rutaArchivo;

            Console.WriteLine("Introduce una frase por consola: ");
            frase= Console.ReadLine();

            remplazoVocales(frase);

            guardaFraseEnLista(frase);

            Console.WriteLine("Introduce la ruta del archivo donde guardar el fichero en formato: ddMMyyyy.txt");
            rutaArchivo=Console.ReadLine();
            escribirEnFichero(frase,rutaArchivo);

            leerFichero(frase,rutaArchivo);

            Console.WriteLine("¿Cuantas vocales faltan?");
            int numVocales=Int32.Parse(Console.ReadLine());




        }

        public static void remplazoVocales(string frase1)
        {
            List<char> listaVocales= new List<char>() { 'a','e','i','o','u'};

            for(int i=0;i<listaVocales.Count;i++)
            {
               
                  frase1= frase1.Replace(listaVocales[i], '*');
                
            }

            Console.WriteLine(frase1);
        }

        public static void guardaFraseEnLista(string frase1)
        {
            

            List<string> listaString = new List<string>(frase1.Split(" "));

            foreach(String str in listaString)
            {
                Console.WriteLine(str);
            }
                     


        }

        public static void escribirEnFichero(string frase,string rutaArchivo)
        {
            using(StreamWriter sw=new StreamWriter(rutaArchivo))
            {
                List<string> listaString = new List<string>(frase.Split(" "));

                foreach(string str in listaString)
                {
                    sw.WriteLine(str);
                }
            }
        }

        public static void leerFichero(string frase,string rutaArchivo)
        {
            
            List<string> listaFrase1=new List<string>(frase.Split(" "));
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string contenidoFichero =sr.ReadLine();

                if (listaFrase1.Count >= 2)
                {
                    string ultimaLinea = listaFrase1[listaFrase1.Count - 1];
                    string penultimaLinea = listaFrase1[listaFrase1.Count - 2];

                    Console.WriteLine("Ultima linea: " + ultimaLinea);
                    Console.WriteLine("Penultima linea: " + penultimaLinea);
                }
                else
                {
                    Console.WriteLine("El archivo no tiene al menos dos líneas.");
                }
            }
        }


    }
}
