namespace MsSqlToSqlLiteConverter
{
    public class ForeignKeySchema
	{
	    public string TableName;

		public string ColumnName;

		public string ForeignTableName;

		public string ForeignColumnName;

	    public bool CascadeOnDelete;

	    public bool IsNullable;
	}
}
