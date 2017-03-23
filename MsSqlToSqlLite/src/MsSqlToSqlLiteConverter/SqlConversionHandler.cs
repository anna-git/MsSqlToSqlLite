namespace MsSqlToSqlLiteConverter
{
    /// <summary>
    /// This handler is called whenever a progress is made in the conversion process.
    /// </summary>
    /// <param name="done">TRUE indicates that the entire conversion process is finished.</param>
    /// <param name="success">TRUE indicates that the current step finished successfully.</param>
    /// <param name="percent">Progress percent (0-100)</param>
    /// <param name="msg">A message that accompanies the progress.</param>
    public delegate void SqlConversionHandler(bool done, bool success, int percent, string msg);
}