using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
namespace Proyecto_final_arquitectura
{
    class AplicacionInvertirColor
    { 
    
        public const String img1500X1500 = "C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno.png";
        private Bitmap bmp;

        public void Init()
        {
            bmp = new Bitmap(img1500X1500);
      
        }

        public void AlgoritmoUno() 
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
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

            bmp.Save("C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno_Invertida.png");
        }

        public void AlgoritmoDos()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
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

            bmp.Save("C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno_Invertido-algoritmo2.png");
        }

        public void AlgoritmoTres()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
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

            bmp.Save("C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno_Invertida-algoritmo3.png");
        }

        public void AlgoritmoCuatro()
        {
            int rows = bmp.Height;
            int colums = bmp.Width;
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
            bmp.Save("C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno_Invertida-algoritmo4.png");

        }

        public void AlgoritmoCinco()
        {
            int rows = bmp.Height;
            int columns = bmp.Width;
            for(int i = 0; i < rows; i = i+2)
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
            bmp.Save("C:\\Users\\57318\\source\\repos\\Proyecto final arquitectura\\Proyecto final arquitectura\\data\\imagen_Uno_Invertida-algoritmo5.png");
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
            aplicacion.Init();
            aplicacion.AlgoritmoCinco();
            Console.WriteLine("hola mundo");
        }
    }
   
}
