using Blogifier.Directs;
using Direct;
using System;

namespace Blogifier.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var db = BlogifierDatabase.Instance;

			//var data = db.Load<DMAuthor>("SELECT * FROM Authors");
			var data = db.Query<DMAuthor>().Where("[id]>0").Load();

			Console.WriteLine("Hello World!");
		}
	}
}
