using Domain.Entities;
using Domain.Services;

Biblioteca biblioteca = new Biblioteca();
Usuario userLucas = new Usuario("Lucas Diego Czadotz", "12121123499");
Usuario userFulano = new Usuario("Fulano de La Silva", "49258201642");
Revista revista1 = new Revista("Nike", "1a", "Chuteiras AirMax", "2026");
LivroFisico livroF1 = new LivroFisico(true, "Prateleira 1", 300, "Aventura", "O Senhor dos Aneis", "1954");
LivroDigital livroD1 = new LivroDigital("www.RériPoti/PuxaDados.com.br", 5, 999, "Aventura", "Harry Potter e a Pedra Filosofal", "1997");

biblioteca.AdicionarUsuario(userLucas);
biblioteca.AdicionarUsuario(userFulano);
biblioteca.AdicionarPublicacao(revista1);
biblioteca.AdicionarPublicacao(livroF1);
biblioteca.AdicionarPublicacao(livroD1);

biblioteca.BuscarPorTitulo("O Senhor dos Aneis")?.ExibirDetalhes();
Console.WriteLine("_________________________");
livroD1.RealizarDowload();
Console.WriteLine("_________________________");
biblioteca.RealizarEmprestimo(userLucas, livroF1);
livroF1.ExibirDetalhes();