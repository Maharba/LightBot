using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

namespace LightBotTablero
{
    class Tablero
    {
        public Tablero(string archivo)
        {
            Mapa = Cargar(archivo);
        }

        public static byte[,] Mapa { get; private set; }
        //private byte[,] tablero = new byte[5, 5];

        public static Point PosicionRobot
        {
            get
            {
                Point punto = new Point();
                for (int i = 0; i < Mapa.Length / 2; i++)
                {
                    for (int j = 0; j < Mapa.Length / 2; j++)
                    {
                        if (Mapa[j, i] == 3)
                            punto =  new Point(j, i);
                        else
                            throw new ApplicationException("Robot no encontrado en el mapa.");
                    }
                }
                return punto;
            }
            // TODO: Posicionar el robot en el mapa dependiendo del movimiento ordenado.
        }

        public byte[,] Cargar(string archivo)
        {
            string linea;
            TextReader tx = new StreamReader(archivo);
            int y = 0;
            bool noRobot = true;
            while ((linea = tx.ReadLine()) != null)
            {
                for (int x = 0; x < linea.Length; x++)
                {
                    switch (linea[x])
                    {
                        case '.': // Espacio vacío
                            Mapa[x, y] = 0;
                            break;
                        case '*': // Robot
                            if (noRobot) 
                            {
                                Mapa[x, y] = 2;
                                noRobot = false;
                            } else 
                                throw new ApplicationException("No puede haber más de un robot en el mapa.");
                            break;
                        case '#': // Paredes
                            Mapa[x, y] = 1;
                            break;
                        case '+': // Objetivo
                            Mapa[x, y] = 3;
                            break;
                    }
                }
                y++;
            }
            return Mapa;
        }
    }
}
