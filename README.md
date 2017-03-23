# Convert Sql server database and insert scripts to a SQLite Database.
Comes from : https://github.com/elerch/Convert-SQL-Server-to-SQLite, with a minor changes to add the possibility to extract data into a sql file script. For example, testing your application and working with Entity Framework, you might want to mock it using Sqlite and an in memory database. You might want to inject into your in memory sqlite database datas from your sql server database, without all the hassle to convert it manually.

Just add Debug command line arguments like this :
"Data Source=youdatasource" "C:\users\me\test.sql" "dbo.tableToexclude,dbo.table2toexclude"
