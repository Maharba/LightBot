using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace LightBotTablero
{
    public enum Movimientos
    {
        Izquierda,
        Arriba,
        Derecha,
        Abajo
    }

    class Robot
    {

        public Point Posicion
        {
            get { return Tablero.PosicionRobot; }
        }

        public void Mover(Movimientos mov)
        {
            switch (mov)
            {
                case Movimientos.Izquierda:
                    break;
                case Movimientos.Arriba:
                    break;
                case Movimientos.Derecha:
                    break;
                case Movimientos.Abajo:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("mov");
            }
        }
    }
}
