using System;
using System.Linq;
using EFGettingStartedConsole.Context;
using EFGettingStartedConsole.Model;

using var db = new BlogContext();

Console.WriteLine($"DB path: {db.DbPath}");

// Create
Console.WriteLine("Inserting new blog...");
db.Blogs.Add(new Blog { Url = "somewhere.com" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog...");
var blog = db.Blogs
  .OrderBy(b => b.BlogId)
  .First();

// Update
Console.WriteLine("Updating the blog and adding a post...");
blog.Url = "somewhere else";
blog.Posts.Add(new Post
{
    Title = "Hello World",
    Content = "This is a post from the console app..."
});
db.SaveChanges();


Console.WriteLine("Deleting the previously created blog...");
db.Remove(blog);
db.SaveChanges();
