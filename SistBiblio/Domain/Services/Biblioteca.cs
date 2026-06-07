using System.ComponentModel;
using Domain.Entities;
namespace Domain.Services
{
    public class Biblioteca
    {
        public List<Usuario> Usuarios{get; private set;}
        public List<Publicacao> Publicacoes{get; private set;}

        public Biblioteca()
        {
            Usuarios = new List<Usuario>();
            Publicacoes = new List<Publicacao>();
        }

        public void AdicionarPublicacao(Publicacao p)
        {
            Publicacoes.Add(p);
        }

        public void AdicionarUsuario(Usuario u)
        {
            Usuarios.Add(u);
        }

        public Publicacao ?BuscarPorTitulo(string titulo)
        {
            foreach (Publicacao p in Publicacoes)
            {
                if (p.Titulo == titulo)
                    return p;
            }
            return null;
        }

        public void RealizarEmprestimo(Usuario u, LivroFisico l)
        {
            if (Usuarios.Contains(u))
            {
                if (l.Disponivel == true)
                 {
                    var emprestimo = l.Emprestar(u);
                    u.EmprestimosAtivos.Add(emprestimo);
                 }
            }
        }
    }
}