using Domain.Entities;
namespace Domain.Contracts
{
    public interface IEmprestavel
    {
        public Emprestimo Emprestar();

        public void Devolver();
    }
}