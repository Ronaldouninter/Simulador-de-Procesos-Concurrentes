using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Procesos_Concurrentes
{
    /// <summary>
    /// Ronaldo Nuñez 
    /// En este proyecto se simula la ejecución de tres procesos concurrentes: el lanzamiento de un cohete, la construcción de un edificio y el desarrollo de un videojuego. Cada proceso se ejecuta en un hilo separado, lo que permite que los tres procesos se ejecuten simultáneamente. Los resultados de cada proceso se muestran en listas separadas en la interfaz de usuario.
    /// </summary>
    public partial class Form1 : Form
    {
        Thread hiloCohete;
        Thread hiloEdificio;
        Thread hiloVideojuegos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            ListbCohete.Items.Clear();
            ListbEdificio.Items.Clear();
            ListbVideojuegos.Items.Clear();

            LblEstado.Text = "Estado: Procesos ejecutándose...";

            hiloCohete = new Thread(SimularCohete);
            hiloEdificio = new Thread(SimularEdificio);
            hiloVideojuegos = new Thread(SimularVideojuegos);

         
            hiloCohete.Start();
            hiloEdificio.Start();
            hiloVideojuegos.Start();
        }

        private void SimularCohete()
        {
            AgregarCohete("Iniciando sistemas");
            Thread.Sleep(700);

            AgregarCohete("Encendiendo motores");
            Thread.Sleep(1000);

            AgregarCohete("Verificando combustible");
            Thread.Sleep(600);

            AgregarCohete("Despegue exitoso");
        }

     
        private void SimularEdificio()
        {
            AgregarEdificio("Preparando terreno");
            Thread.Sleep(1200);

            AgregarEdificio("Construyendo cimientos");
            Thread.Sleep(1500);

            AgregarEdificio("Levantando estructura");
            Thread.Sleep(1800);

            AgregarEdificio("Instalando acabados");
            Thread.Sleep(1000);

            AgregarEdificio("Proyecto terminado");
        }

       
        private void SimularVideojuegos()
        {
            AgregarVideojuegos("Registrando jugadores");
            Thread.Sleep(900);

            AgregarVideojuegos("Iniciando partida");
            Thread.Sleep(700);

            AgregarVideojuegos("Calculando puntuaciones");
            Thread.Sleep(1300);

            AgregarVideojuegos("Determinando ganador");
            Thread.Sleep(800);

            AgregarVideojuegos("Torneo finalizado");
        }

        private void AgregarCohete(string mensaje)
        {
            if (ListbCohete.InvokeRequired)
            {
                ListbCohete.Invoke(new Action(() =>
                {
                    ListbCohete.Items.Add(mensaje);
                }));
            }
            else
            {
                ListbCohete.Items.Add(mensaje);
            }
        }

        private void AgregarEdificio(string mensaje)
        {
            if (ListbEdificio.InvokeRequired)
            {
                ListbEdificio.Invoke(new Action(() =>
                {
                    ListbEdificio.Items.Add(mensaje);
                }));
            }
            else
            {
                ListbEdificio.Items.Add(mensaje);
            }
        }

        private void AgregarVideojuegos(string mensaje)
        {
            if (ListbVideojuegos.InvokeRequired)
            {
                ListbVideojuegos.Invoke(new Action(() =>
                {
                    ListbVideojuegos.Items.Add(mensaje);
                }));
            }
            else
            {
                ListbVideojuegos.Items.Add(mensaje);
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            ListbCohete.Items.Clear();
            ListbEdificio.Items.Clear();
            ListbVideojuegos.Items.Clear();

            LblEstado.Text = "Estado: Esperando...";

            hiloCohete = null;
            hiloEdificio = null;
            hiloVideojuegos = null;
        }
    }
}
