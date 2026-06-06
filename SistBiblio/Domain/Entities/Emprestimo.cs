namespace Domain.Entities
{
    public class Emprestimo
    {
        public string DataEmp{get; private set;}
        public string Status{get; private set;}
        public Usuario Usuario{get; private set;}
        public LivroFisico LivroFisico{get; private set;}

        public Emprestimo(string dataEmp, string status, Usuario usuario, LivroFisico livroFisico)
        {
            DataEmp = dataEmp;
            Status = status;
            Usuario = usuario;
            LivroFisico = livroFisico;
        }
    }
}