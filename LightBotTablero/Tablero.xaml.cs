using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LightBotTablero
{
    /// <summary>
    /// Interaction logic for Tablero.xaml
    /// </summary>
    public partial class Tablero : UserControl
    {
        public Tablero()
        {
            InitializeComponent();
        }

        private Casillas c;

        public Casillas Casilla
        {
            get { return c; }
            set
            {
                switch (value)
                {
                    case Casillas.A1:
                        //grdTablero.Children.Add(elRobot);
                        Grid.SetColumn(elRobot, 0);
                        Grid.SetRow(elRobot, 0);
                        break;
                    case Casillas.A2:
                        //grdTablero.Children.Add(elRobot);
                        Grid.SetColumn(elRobot, 0);
                        Grid.SetRow(elRobot, 1);
                        break;
                    case Casillas.A3:
                        //grdTablero.Children.Add(elRobot);
                        Grid.SetColumn(elRobot, 0);
                        Grid.SetRow(elRobot, 2);
                        break;
                    case Casillas.A4:
                        //grdTablero.Children.Add(elRobot);
                        Grid.SetColumn(elRobot, 0);
                        Grid.SetRow(elRobot, 3);
                        break;
                    case Casillas.A5:
                        Grid.SetColumn(elRobot, 0);
                        Grid.SetRow(elRobot, 4);
                        break;
                    case Casillas.B1:
                        Grid.SetColumn(elRobot, 1);
                        Grid.SetRow(elRobot, 0);
                        break;
                    case Casillas.B2:
                        Grid.SetColumn(elRobot, 1);
                        Grid.SetRow(elRobot, 1);
                        break;
                    case Casillas.B3:
                        Grid.SetColumn(elRobot, 1);
                        Grid.SetRow(elRobot, 2);
                        break;
                    case Casillas.B4:
                        Grid.SetColumn(elRobot, 1);
                        Grid.SetRow(elRobot, 3);
                        break;
                    case Casillas.B5:
                        Grid.SetColumn(elRobot, 1);
                        Grid.SetRow(elRobot, 4);
                        break;
                    case Casillas.C1:
                        Grid.SetColumn(elRobot, 2);
                        Grid.SetRow(elRobot, 0);
                        break;
                    case Casillas.C2:
                        Grid.SetColumn(elRobot, 2);
                        Grid.SetRow(elRobot, 1);
                        break;
                    case Casillas.C3:
                        Grid.SetColumn(elRobot, 2);
                        Grid.SetRow(elRobot, 2);
                        break;
                    case Casillas.C4:
                        Grid.SetColumn(elRobot, 2);
                        Grid.SetRow(elRobot, 3);
                        break;
                    case Casillas.C5:
                        Grid.SetColumn(elRobot, 2);
                        Grid.SetRow(elRobot, 4);
                        break;
                    case Casillas.D1:
                        Grid.SetColumn(elRobot, 3);
                        Grid.SetRow(elRobot, 0);
                        break;
                    case Casillas.D2:
                        Grid.SetColumn(elRobot, 3);
                        Grid.SetRow(elRobot, 1);
                        break;
                    case Casillas.D3:
                        Grid.SetColumn(elRobot, 3);
                        Grid.SetRow(elRobot, 2);
                        break;
                    case Casillas.D4:
                        Grid.SetColumn(elRobot, 3);
                        Grid.SetRow(elRobot, 3);
                        break;
                    case Casillas.D5:
                        Grid.SetColumn(elRobot, 3);
                        Grid.SetRow(elRobot, 4);
                        break;
                    case Casillas.E1:
                        Grid.SetColumn(elRobot, 4);
                        Grid.SetRow(elRobot, 0);
                        break;
                    case Casillas.E2:
                        Grid.SetColumn(elRobot, 4);
                        Grid.SetRow(elRobot, 1);
                        break;
                    case Casillas.E3:
                        Grid.SetColumn(elRobot, 4);
                        Grid.SetRow(elRobot, 2);
                        break;
                    case Casillas.E4:
                        Grid.SetColumn(elRobot, 4);
                        Grid.SetRow(elRobot, 3);
                        break;
                    case Casillas.E5:
                        Grid.SetColumn(elRobot, 4);
                        Grid.SetRow(elRobot, 4);
                        break;
                }
            }
        }

        
    }
}
