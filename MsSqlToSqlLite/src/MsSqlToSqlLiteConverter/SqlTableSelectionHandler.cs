namespace MsSqlToSqlLiteConverter
{
    using System.Collections.Generic;

    /// <summary>
    /// This handler allows the user to change which tables get converted from SQL Server
    /// to SQLite.
    /// </summary>
    /// <param name="schema">The original SQL Server DB schema</param>
    /// <returns>The same schema minus any table we don't want to convert.</returns>
    public delegate List<TableSchema> SqlTableSelectionHandler(List<TableSchema> schema);
}