using Direct;
using Direct.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blogifier.Directs.Models
{
	public class DMBlog : DirectModel
	{
		public DMBlog(string tableName, string id_name, DirectDatabaseBase db) : base(tableName, id_name, db, DirectDatabaseType.SQLite) { }
	}
}
