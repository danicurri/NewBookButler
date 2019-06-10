using System;
using System.Collections.Generic;

class Libro
{
    public string titulo;
    public string autor;
    public string editorial;
    public int paginas;
    public string categoria;
    public int anyo;
    public string ubicacion;
    public string observaciones;
    public string codigo;

    public Libro(string titulo, string autor, string editorial, int paginas, 
                string categoria, int anyo, string ubicacion, string observaciones,
                string codigo)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.editorial = editorial;
        this.paginas = paginas;
        this.categoria = categoria;
        this.anyo = anyo;
        this.ubicacion = ubicacion;
        this.observaciones = observaciones;
        this.codigo = codigo;
    }


    //Getters and setters
    public string GetTitulo() { return titulo; }

    public void SetTitulo(string titulo) { this.titulo = titulo; }

    public string GetAutor() { return autor; }

    public void SetAutor(string autor) { this.autor = autor; }

    public string GetEditorial() { return editorial; }

    public void SetEditorial(string editorial) { this.editorial = editorial; }

    public int GetPaginas() { return paginas; }

    public void SetPaginas(int paginas) { this.paginas = paginas; }

    public int GetAnyo() { return anyo; }

    public void SetAnyo(int anyo) { this.anyo = anyo; }

    public string GetUbicacion() { return ubicacion; }

    public void SetUbicacion(string ubicacion) { this.ubicacion = ubicacion; }

    public string GetObservaciones() { return observaciones; }

    public void SetObservaciones(string observaciones) { this.observaciones =
                                                        observaciones; }

    public string GetCodigo() { return codigo; }

    public void SetCodigo(string codigo) { this.codigo = codigo; }
}

