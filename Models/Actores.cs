using System;
public class Actores
{
    public int IdActores{get;set;}
    public int IdSerie{get;set;}
    public string Nombre{get;set;}

    public Actores()
    {

    }

    public Actores(int idActores, int idSerie, string nombre)
    {
        IdActores = idActores;
        IdSerie = idSerie;
        Nombre = nombre;
    }
}