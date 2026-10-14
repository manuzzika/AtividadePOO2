using System.Net;

namespace AtividadePOO2.Core;

public class Livro
{
    public string Titulo { get; private set; }
    public string NomeAutora { get; private set; }
    public int Paginas { get; private set; }
    public string Sinopse { get; private set; }
    public string? Sumario { get; private set; }


    public Livro(string titulo, string nomeAutora, string pagina, string sinopse)
    {
        ValidarTitulo(titulo);
        ValidarNomeAutora(nomeAutora);
        ValidarPaginas(pagina);
        ValidarSinopse(sinopse);
    }
    
    public Livro(string titulo, string nomeAutora, string pagina,string sinopse, string? sumario)
    {
        ValidarSumario(sumario);
    }

    private int MINIMO_QUANTIDADE_PAGINA = 10;

    private void ValidarSumario(string sumario)
    {
        if (string.IsNullOrWhiteSpace(sumario))
            throw new Exception("É muito interessante para o leitor ter um sumário!");

        Sumario = sumario;
    }
    
    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("O titulo não pode ser vazio!");

        Titulo = titulo;
    }
    
    private void ValidarNomeAutora(string nomeAutora)
    {
        if (string.IsNullOrWhiteSpace(nomeAutora))
            throw new Exception("O livro obrigatoriamente deve ter um autor assinando!");

        NomeAutora = nomeAutora;
    }

    private void ValidarPaginas(string pagina)
    {
        if (pagina.Length < MINIMO_QUANTIDADE_PAGINA)
            throw new Exception($"O livro deve ter pelo menos {MINIMO_QUANTIDADE_PAGINA} páginas!");
        
    }

    private void ValidarSinopse(string sinopse)
    {
        if (string.IsNullOrWhiteSpace(sinopse))
            throw new Exception("O titulo não pode ser vazio!");

        Sinopse = sinopse;
    }
}


