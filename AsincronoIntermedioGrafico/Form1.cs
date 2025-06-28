namespace AsincronoIntermedioGrafico
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            lblEstado.Text = "Procesando....(Puede Cancelar)";

            try
            {
                await TareaLarga(cts.Token);
            }
            catch (OperationCanceledException)
            {
                lblEstado.Text = "No sea Indeciso, ¡Decídase!";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private async Task TareaLarga(CancellationToken token)
        {
            for (int i = 1; i <= 5; i++)
            {
                token.ThrowIfCancellationRequested();
                await Task.Delay(1000, token);
                lblEstado.Text = $"Procesando... {i}/5 segundos";
            }
        }
    }
}
