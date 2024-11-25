using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class Form3 : Form
    {
        private int contador = 0; // Personas actuales en la sala
        private readonly object bloqueo = new(); // Bloqueo para la sección crítica
        private readonly SemaphoreSlim semaforo;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    if (contador > 0) // Solo permite salir si hay personas dentro
                    {
                        contador--; // Decrementa el contador al salir
                        semaforo.Release(); // Libera un permiso en el semáforo
                        ActualizarResultado($"Una persona ha entrado. Total: {contador}");
                    }
                    else
                    {
                        ActualizarResultado("La sala está llena. No se puede entrar.");
                    }
                }
            });
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    if (contador > 0) // Solo permite salir si hay personas dentro
                    {
                        contador--; // Decrementa el contador al salir
                        semaforo.Release(); // Libera un permiso en el semáforo
                        ActualizarResultado($"Una persona ha salido. Total: {contador}");
                    }
                    else
                    {
                        ActualizarResultado("La sala está vacía. No se puede salir.");
                    }
                }
            });
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($" {DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }
    }
   
 }

