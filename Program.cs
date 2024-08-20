using Microsoft.Data.Sqlite;

string connectionString = @"Data Source=HabitTracker.db";

using (var connection = new SqliteConnection(connectionString)) {
    connection.Open(); //Abrir la conexión con la base de datos

    var tableCmd = connection.CreateCommand();
    tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS meditation (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Date TEXT,
                                Quantity INTEGER
                                )";
    tableCmd.ExecuteNonQuery();

    connection.Close(); //Cerrarla
}