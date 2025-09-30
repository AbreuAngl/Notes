namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
            if(File.Exists(caminho))
                CaixaEditor.Text = File.ReadAllText(caminho);
         
        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert("arquivo salvo", $"{Path.GetFileName(caminho)} salvo com sucesso em: {caminho}","ok");


        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            CaixaEditor.Text = String.Empty;
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                DisplayAlert("arquivo apagado", "arquivo apagado com sucesso", "ok");
            }
            else
                DisplayAlert("exclusao", "arquivo nao existe", "ok");
            
        }
    }

}
