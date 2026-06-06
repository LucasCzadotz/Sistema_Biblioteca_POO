namespace Domain.Entities
{
    public class Revista : Publicacao
    {
        public string Marca{get; private set;}
        public string Edicao{get; private set;}

        public Revista(string marca, string edicao, string titulo, string anoPubli) : base(titulo, anoPubli)
        {
            Marca = marca;
            Edicao = edicao;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Ano: {AnoPubli}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Edicao: {Edicao}");
        }
    }
}