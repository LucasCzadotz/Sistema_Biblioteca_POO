namespace Domain.Entities
{
    public abstract class Publicacao
    {
        public string Titulo{get; private set;}
        public string AnoPubli{get; private set;}

        protected Publicacao(string titulo, string anoPubli)
        {
            Titulo = titulo;
            AnoPubli = anoPubli;
        }
    
        public abstract void ExibirDetalhes();
    }    
}