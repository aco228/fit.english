using Direct.Types.SQLite;
using System;

namespace Blogifier.Directs
{
	public class BlogifierDatabase : DirectDatabaseSqlLite
	{
		public BlogifierDatabase() : base("Blogifier", @"Data Source=D:\github\fit.english\src\Blogifier\Blog.db") { }

		public static BlogifierDatabase Instance
		{
			get => new BlogifierDatabase();
		}
	}
}
