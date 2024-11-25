using System.Drawing.Text;

namespace DemoConcurrencia
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _Cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial...");
            for (int i = 0; i < 5; i++)
            {//Sleep: Detiene el procesamiento
                Thread.Sleep(2000); //Carga la segunda linea después de cada 2 segundos
                ActualizarResultado($"Actividad - paso {i + 1}");
            }

            ActualizarResultado("Fin del proceso secuencial.");
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

        private void btnTarea_Click(object sender, EventArgs e)
        {
            _Cts = new CancellationTokenSource();
            var token = _Cts.Token;
            try
            {
                ActualizarResultado("Iniciando Task...");
                Task.Run(() =>
                {
                    Thread.Sleep(5000);
                });
                ActualizarResultado("Task completada");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _Cts.Cancel();
        }

       
    }
}
