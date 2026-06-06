namespace Domain.Entities
{
    public abstract class Livro : Publicacao
    {
        public int QtdPag{get; private set;}
        public string Genero{get; private set;}

        protected Livro(int qtdPag, string genero, string titulo, string anoPubli) : base(titulo, anoPubli)
        {
            QtdPag = qtdPag;
            Genero = genero;
        }
    }
}