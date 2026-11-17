public class Livro
{
    public string Titulo;
    public string Autor;
    public uint Paginas;


    public Livro(string titulo, string autor, uint paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Paginas = paginas;
    }

    public string GetTitulo()
    {
        return this.Titulo;
    }

    public string GetAutor()
    {
        return this.Autor;
    }

    public uint GetPaginas()
    {
        return this.Paginas;
    }
    public override string ToString()
    {
        return $"""
            Título: {Titulo}
            Autor: {Autor}
            Número de Páginas: {Paginas}
            """;
    }
}
