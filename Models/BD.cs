using System.Data.SqlClient;
using Dapper;

public static class BD
{
    public static string _connectionString = @"Server=localhost;
    DataBase=BDSeries;Trusted_Connection=True";

    public static List<Actores> ObtenerActores(int idSerie)
    {
        List<Actores> ListaActores = new List<Actores>();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Actores WHERE idSerie = @pIdSerie";
            ListaActores = db.Query<Actores>(sql, new {pIdSerie = idSerie}).ToList();
        }
        return ListaActores;
    }

    public static string ObtenerInfoSeries(int idSerie)
    {
        string info;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Sinopsis FROM Series WHERE idSerie = @pIdSerie";
            info = db.Query<Series>(sql, new {pIdSerie = idSerie});
        }
    }

    public static List<Series> ObtenerSeries()
    {
        List<Series> ListaSeries = new List<Series>();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series";    
            ListaSeries = db.Query<Series>(sql).ToList();
        }
        return ListaSeries;
    }

    public static List<Temporadas> ObtenerTemporadas(int idSerie)
    {
        List<Temporadas> ListaTemporadas = new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE idSerie = @pIdSerie";
            ListaTemporadas = db.Query<Temporadas>(sql, new {pIdSerie = idSerie}).ToList();
        }
        return ListaTemporadas;
    }
}