namespace Domain.Entities
{
    public class Usuario
    {
        public string Nome{get; private set;}
        public string CPF{get; private set;}
        
        public List<Emprestimo> EmprestimosAtivos{get; private set;}

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
            EmprestimosAtivos = new List<Emprestimo>();
        }
    }
}