using System.Diagnostics.Tracing;
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

        public Emprestimo Emprestar(Usuario usuario)
        {
            if (Disponivel is true)
            {
                var emprestimo = new Emprestimo(DateTime.Now, "Ativo", usuario, this);
                Disponivel = false;
                return emprestimo;
            }
            throw new Exception("Livro não disponível para empréstimo.");
        }

        public void Devolver()
        {
            Disponivel = true;
        }
    }
}