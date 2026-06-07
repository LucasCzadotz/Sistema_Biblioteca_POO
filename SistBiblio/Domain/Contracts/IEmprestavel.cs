using Domain.Entities;
namespace Domain.Contracts
{
    public interface IEmprestavel
    {
        public Emprestimo Emprestar(Usuario usuario);

        public void Devolver();
    }
}