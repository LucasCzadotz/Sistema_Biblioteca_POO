using Domain.Contracts;

namespace Domain.Entities
{
    public class LivroFisico : Livro, IEmprestavel
    {
        public bool Disponivel{get; private set;}
        public string LocPrateleira{get; private set;}

        public LivroFisico(bool disponivel, string locPrateleira, int qtdPag, string genero, string titulo, string anoPubli) : base (qtdPag, genero, titulo, anoPubli)
        {
            Disponivel = disponivel;
            LocPrateleira = locPrateleira;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Ano: {AnoPubli}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"N Paginas: {QtdPag}");
            Console.WriteLine($"Disponivel: {Disponivel}");
            Console.WriteLine($"Localizacao do livro: {LocPrateleira}");
        }       

        public override Emprestimo Emprestar(Usuario usuario)
        {
            -----------------------------------------------
        }
    }
}