using Direct;
using Direct.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogifier.Directs.Models
{
  public class DMCategories : DMBlog
  {
    public DMCategories() : base("Categories", "Id", null) { }
    public DMCategories(DirectDatabaseBase db) : base("Categories", "Id", db) { }

    [DColumn(Name = "Id", IsPrimary = true)]
    public int Id { get; set; }
    public string Name { get; set; }


    public static List<DMCategories> LoadAll()
      => BlogifierDatabase.Instance.Query<DMCategories>().Where("[id]>0").Additional("ORDER BY [id] ASC").Load();

    public static async Task<List<DMCategories>> LoadAllAsync()
      => await BlogifierDatabase.Instance.Query<DMCategories>().Where("[id]>0").Additional("ORDER BY [id] ASC").LoadAsync();
  }
}
