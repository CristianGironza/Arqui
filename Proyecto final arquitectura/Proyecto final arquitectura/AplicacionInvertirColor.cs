using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Proyecto_final_arquitectura
{
    class AplicacionInvertirColor
    { 
    
        public const String imagenEntrada = "C:\\Users\\57318\\Documents\\ICESI\\2020-1\\arqui\\final arqui\\Arqui\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagenesOriginales\\imagen2-1500x1500-8 bits.png";
        public const String imagenSalida = "C:\\Users\\57318\\Documents\\ICESI\\2020-1\\arqui\\final arqui\\Arqui\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagenesInvertidas\\imagen2Invertida-1500x1500-8 bits-a4.png";
        public const String direccion_Resultados = "C:\\Users\\57318\\Documents\\ICESI\\2020-1\\arqui\\final arqui\\Arqui\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\pruebas\\pruebasAlgoritmo4\\Resultados-imagen2-1500x1500-8 bits.txt";

        private Bitmap bmp;

        public void Init()
        {
            bmp = new Bitmap(imagenEntrada);
      
        }

        public long AlgoritmoUno() 
        {

            int rows = bmp.Height;
            int colums = bmp.Width;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < rows; i++) { 
                for( int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    
                    int red = 255 - c.R;
                    int green = 255 - c.G;
                    int blue = 255 - c.B;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, red, green, blue));
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            bmp.Save(imagenSalida);
           
            return tiempo;

        }

        public long AlgoritmoDos()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(i, j);

                    int red = 255 - c.R;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, red, c.G, c.B));
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(i, j);

                    int green = 255 - c.G;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, c.R, green, c.B));
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    int blue = 255 - c.B;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, c.R, c.G, blue));
                }
            }

            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            bmp.Save(imagenSalida);
            return tiempo;
        }

        public long AlgoritmoTres()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(j, i);

                    int red = 255 - c.R;
                    int green = 255 - c.G;
                    int blue = 255 - c.B;

                    bmp.SetPixel(j, i, Color.FromArgb(c.A, red, green  , blue));
                }
            }

            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            bmp.Save(imagenSalida);
            return tiempo;
        }

        public long AlgoritmoCuatro()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Color c = bmp.GetPixel(i, j);

                    int red = 255 - c.R;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, red, c.G, c.B));
                }
            }

            for (int i = rows-1; i >= 0; i--)
            {
                for (int j = colums-1; j >= 0; j--)
                {
                    Color c = bmp.GetPixel(i, j);

                    int green = 255 - c.G;
                    int blue = 255 - c.B;

                    bmp.SetPixel(i, j, Color.FromArgb(c.A, c.R, green, blue));
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            bmp.Save(imagenSalida);
            return tiempo;
        }

        public long AlgoritmoCinco()
        {
            int rows = bmp.Height;
            int columns = bmp.Width;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < rows; i = i+2)
            {
                for(int j = 0; j < columns; j = j+2)
                {
                    Color c = bmp.GetPixel(i, j);
                    int red = 255 - c.R;
                    int green = 255 - c.G;
                    int blue = 255 - c.B;
                    bmp.SetPixel(i, j, Color.FromArgb(c.A, red, green, blue));
                    if ((i + 1) < rows && (j + 1) < columns)
                    {
                    
                        c = bmp.GetPixel(i, j + 1);
                        red = 255 - c.R;
                        green = 255 - c.G;
                        blue = 255 - c.B;
                        bmp.SetPixel(i, j + 1, Color.FromArgb(c.A, red, green, blue));

                        c = bmp.GetPixel(i + 1, j);
                        red = 255 - c.R;
                        green = 255 - c.G;
                        blue = 255 - c.B;
                        bmp.SetPixel(i + 1, j, Color.FromArgb(c.A, red, green, blue));

                        c = bmp.GetPixel(i + 1, j + 1);
                        red = 255 - c.R;
                        green = 255 - c.G;
                        blue = 255 - c.B;
                        bmp.SetPixel(i + 1, j + 1, Color.FromArgb(c.A, red, green, blue));

                    }
                    else if ((i + 1) < rows && (j + 1) >= columns)
                    {
                        c = bmp.GetPixel(i + 1, j);
                        red = 255 - c.R;
                        green = 255 - c.G;
                        blue = 255 - c.B;
                        bmp.SetPixel(i + 1, j, Color.FromArgb(c.A, red, green, blue));

                    }
                    else if ((i + 1) >= rows && (j + 1) < columns)
                    {
                        c = bmp.GetPixel(i, j + 1);
                        red = 255 - c.R;
                        green = 255 - c.G;
                        blue = 255 - c.B;
                        bmp.SetPixel(i, j + 1, Color.FromArgb(c.A, red, green, blue));
                    }
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            bmp.Save(imagenSalida);
            return tiempo;
        }

        public void Pruebas(int algoritmo) 
        {
                StreamWriter sw = new StreamWriter(direccion_Resultados);

            if (algoritmo == 1)
            {
                for (int i = 1; i < 150; i++)
                {
                    sw.WriteLine(AlgoritmoUno());
                }
            }
            else if (algoritmo == 2)
            {
                for (int i = 1; i < 100; i++)
                {
                    sw.WriteLine(AlgoritmoDos());
                }
            }
            else if (algoritmo == 3)
            {
                for (int i = 1; i < 100; i++)
                {
                    sw.WriteLine(AlgoritmoTres());
                }
            }
            else if (algoritmo == 4)
            {
                for (int i = 1; i < 100; i++)
                {
                    sw.WriteLine(AlgoritmoCuatro());
                }
            }
            else if (algoritmo == 5)
            {
                for (int i = 1; i < 100; i++)
                {
                    sw.WriteLine(AlgoritmoCinco());
                }
            }

            sw.Close();

        }

        static void Main(string[] args)
        {
            AplicacionInvertirColor aplicacion = new AplicacionInvertirColor();
            //aplicacion.Init();
            //aplicacion.AlgoritmoUno();
            //aplicacion.Init();
            //aplicacion.AlgoritmoDos();
            //aplicacion.Init();
            //aplicacion.AlgoritmoTres();
            //aplicacion.Init();
            //aplicacion.AlgoritmoCuatro();
            //aplicacion.Init();
            //aplicacion.AlgoritmoCinco();
            //Console.WriteLine("hola mundo");
            aplicacion.Init();
            aplicacion.Pruebas(5);
        }
    }
   
}
