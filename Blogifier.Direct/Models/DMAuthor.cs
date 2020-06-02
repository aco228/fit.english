using Blogifier.Directs.Models;
using Direct;
using Direct.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogifier.Directs
{
	public class DMAuthor : DMBlog
	{
		public DMAuthor() : base("Authors", "Id", null) { }
		public DMAuthor(DirectDatabaseBase db) : base("Authors", "Id", db) { }


		[DColumn(Name ="Id", IsPrimary =true)]
		public int Id { get; set; }

		[DColumn(Name ="Email")]
		public string Email { get; set; }

		public string DisplayName { get; set; }
		public string Bio { get; set; }
		public string Avatar { get; set; }

		public static List<DMAuthor> LoadAll()
			=> BlogifierDatabase.Instance.Query<DMAuthor>().Where("[id]>0").Load();

		public static async Task<List<DMAuthor>> LoadAllAsync()
			=> await BlogifierDatabase.Instance.Query<DMAuthor>().Where("[id]>0").LoadAsync();

	}
}
