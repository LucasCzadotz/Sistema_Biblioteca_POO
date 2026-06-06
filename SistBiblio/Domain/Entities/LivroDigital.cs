namespace Domain.Entities
{
    public class LivroDigital : Livro
    {
        public string URLDowload{get; private set;}
        public int TamanhoMB{get; private set;}

        public LivroDigital(string uRLDowload, int tamanhoMB, int qtdPag, string genero, string titulo, string anoPubli) : base(qtdPag, genero, titulo, anoPubli)
        {
            URLDowload = uRLDowload;
            TamanhoMB = tamanhoMB;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Ano: {AnoPubli}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"N Paginas: {QtdPag}");
            Console.WriteLine($"URL Dowload: {URLDowload}");
            Console.WriteLine($"Tamanho MB: {TamanhoMB}");
        }

        public void RealizarDowload()
        {
            Console.WriteLine("Baixando   ---->   99/100%   :)    ");
        }
    }
}