using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDL_Guia1_Ejercicio2
{
    public partial class Form1 : Form
    {
        /*int x, y; Variables globales que permiten determinar la ubicación del clic */

        Graphics lienzo; 

        public Form1()
        {
            InitializeComponent();
            lienzo = panel1.CreateGraphics();
            nUPX.Maximum = panel1.Width; //Toma como maximo rango el tamaño del panel
            nUPY.Maximum = panel1.Height; //Toma como maximo rango el tamaño del panel

            //Llenamos el combobox con los colores del sistema
            string[] colores = Enum.GetNames(typeof (System.Drawing.KnownColor));
            cmbcolores.Items.AddRange(colores);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            Point punto = new Point(e.X,e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate(); */

        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            int op = listBox1.SelectedIndex;
            int size = (int)nuptamaño.Value;
            int x = (int)nUPX.Value;
            int y = (int)nUPY.Value;
            Color color = Color.FromName(cmbcolores.SelectedItem.ToString());
            Pen lapiz = new Pen(color,3);
            Brush pincel = new SolidBrush(color);

            switch (op)
            {
                case 0: // Cirulo
                    lienzo.DrawEllipse(lapiz, x - size / 2, y - size / 2, size, size);
                    lienzo.FillEllipse(pincel, x - size / 2, y - size / 2, size, size);
                    break;

                case 1: //Rectangulo
                    lienzo.DrawRectangle(lapiz,x,y,size,size);
                    lienzo.FillRectangle(pincel, x, y, size, size);

                    break;
                default:
                    MessageBox.Show("Selecciona una figura");
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*
            Graphics g = panel1.CreateGraphics(); //Establece zona para dibujo
            Pen lapiz = new Pen(Color.Black); //Declaro colo de pen a utilizar

            if (listBox1.SelectedIndex == 0) //Si selecciona circulo
            {
                SolidBrush sb = new SolidBrush(Color.Red); //Brush en rojo
                g.DrawEllipse(lapiz, x - 50, y - 50, 50, 50);
                /*Esto dibujarña una elipse usando ese "pen", con la posición X y Y
                menos 50 y dimensiones 100 

                g.FillEllipse(sb, x - 50, y - 50, 50, 50); //Rellena de color la elipse dada
            }

            if (listBox1.SelectedIndex == 1) //Si selecciona el rectangulo
            {
                SolidBrush sb = new SolidBrush(Color.Green); //Brush en verde
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 50);
                /* Dibujará rectangulo utilizando ese pen, con la posicio´n en X y Y menos 50
                y dimensiones de 100 
                g.FillRectangle(sb, x - 50, y - 50, 100, 100); //Rellena de color la elipse dada
            }
            */
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //Lo siguiente hará que me diga las coordenadas donde yo de click

            nUPX.Value = panel1.PointToClient(Cursor.Position).X; //Da las coordenadas de X
            nUPY.Value = panel1.PointToClient(Cursor.Position).Y; //Da las coordenadas de Y 

        }
    }
}
