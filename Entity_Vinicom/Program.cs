using Entity_Vinicom.Data;
using Entity_Vinicom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Entity_Vinicom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // var b = new Blog();
            //b.Url = "www.goggle.com";
            //b.Rating = 1;

            //AddBlog(b);

            var c = new Blog();
            c.Url = "www.com/example.com/future-of-technology";
            c.Rating = 45;
            AddBlog(c);

            var d = new Blog();
            d.Url = "www.com/example.com/cloud-computing";
            d.Rating = 40;
            AddBlog(d);

            var e = new Blog();
            e.Url = "www.com/example.com/frontend";
            e.Rating = 50;
            AddBlog(e);

            var f = new Blog();
            f.Url = "www.com/example.com/data-analytics";
            f.Rating = 55;
            AddBlog(f);

            var g = new Blog();
            g.Url = "www.com/example.com/project-management";
            g.Rating = 55;
            AddBlog(g);

            var h = new Blog();
            h.Url = "www.com/example.com/role-of-devops";
            h.Rating = 60;
            AddBlog(h);

            var i = new Blog();
            i.Url = "www.com/example.com/cambridge-university";
            i.Rating = 55;
            AddBlog(i);

            var j = new Blog();
            j.Url = "www.com/example.com/cybersecurity";
            j.Rating = 35;
            AddBlog(j);

            var k = new Blog();
            k.Url = "www.com/example.com/evolution-of-backend";
            k.Rating = 45;
            AddBlog(k);




            var p = new Post();
            p.BlogId = 1;
            p.Title = "Introduction EF core";
            p.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(p);

            var q = new Post();
            q.BlogId = 3;
            q.Title = "Introduction EF core";
            q.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(p);

            var r = new Post();
            r.BlogId = 4;
            r.Title = "Introduction EF core";
            r.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(r);

            var s = new Post();
            s.BlogId = 5;
            s.Title = "Introduction EF core";
            s.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(s);

            var t = new Post();
            t.BlogId = 6;
            t.Title = "Introduction EF core";
            t.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(t);

            var u = new Post();
            u.BlogId = 7;
            u.Title = "Introduction EF core";
            u.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(u);

            var v = new Post();
            v.BlogId = 2;
            v.Title = "Introduction EF core";
            v.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(v);

            var w = new Post();
            w.BlogId = 3;
            w.Title = "Introduction EF core";
            w.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(w);

            var x = new Post();
            x.BlogId = 2;
            x.Title = "Introduction EF core";
            x.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(x);

            var y = new Post();
            y.BlogId = 10;
            y.Title = "Introduction EF core";
            y.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(y);

            var z = new Post();
            z.BlogId = 9;
            z.Title = "Introduction EF core";
            z.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(z);

            var zz = new Post();
            zz.BlogId = 1;
            zz.Title = "Introduction EF core";
            zz.Content = "Lorem ipsium lowvh fbay jbkc kabdc kjab kahbeb";
            AddPost(zz);









            //getPost();

            //var blog = getBlogById(1);
            //blog.Rating = 5;
            //updateBlog(blog.BlogId, blog);
        }



        //Adding Information to the Database
        public static void AddBlog(Blog newBlog)
        {
            try
            {
                using (var db = new DataContext())
                {
                    db.Blogs.Add(newBlog);
                    db.SaveChanges();
                    Console.WriteLine("New Blog Added");
                }
            }
            catch
            {
                Console.WriteLine("Error adding new Blog");
            }
            
        }

        public static void AddPost(Post newPost)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    bp.Posts.Add(newPost);
                    bp.SaveChanges();
                    Console.WriteLine("New Post Added");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Uploading Post");
                Console.WriteLine(ex.Message);
            }
        }

        //Retreiving Information from the Database
        public static void getBlog()
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var blog = bp.Blogs.ToList();

                    blog.ForEach(b =>
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine("Title: " + b.BlogId);
                        Console.WriteLine("Contetnt: " + b.Url);
                        Console.WriteLine("----------");
                    });
                    Console.WriteLine("Getting Blog");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Blog");

                if(ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        public static void getPost()
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var post = bp.Posts.ToList();

                    post.ForEach(p =>
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine("Title: " + p.Title);
                        Console.WriteLine("Contetnt: " + p.Content);
                        Console.WriteLine("----------");
                    });
                    Console.WriteLine("Getting Post");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        //Retrieving A single data by id
        public static Blog GetBlogById(int blogId)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var blog = bp.Blogs.FirstOrDefault(b => b.BlogId == blogId);

                    if(blog != null)
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine("Title: " + blog.BlogId);
                        Console.WriteLine("Contetnt: " + blog.Url);
                        Console.WriteLine("----------");
                    }
                    else
                    {
                        Console.WriteLine("Blog record not found");
                    }

                    return blog;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Blog");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }
                throw;

            }
        }

        public static Post getPostById(int postId)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var post = bp.Posts.FirstOrDefault(p => p.PostId == postId);

                    if(post != null)
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine("Title: " + post.Title);
                        Console.WriteLine("Contetnt: " + post.Content);
                        Console.WriteLine("----------");
                    }
                    else
                    {
                        Console.WriteLine("Post record not found");
                    }
                    return post;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }
                throw;

            }
        }

        //Update Information
        public static void updateBlog(int blogId, Blog updateData)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var blog = bp.Blogs.Find(blogId);
                    //var blog = bp.Blogs.FirstOrDefault(blog => blog.BlogId == blogId);

                    if(blog == null)
                    {
                        Console.WriteLine("Blog Not found");
                    }
                    else
                    {
                        blog.Rating = updateData.Rating;
                        bp.Update(blog);
                        bp.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");
                throw;
            }
        }

        public static void updatePost(int postId, Post updateData)
        {
            try
            {
                using (var db = new DataContext())
                {
                    var post = db.Posts.Find(postId);
                    if (post == null)
                    {
                        Console.WriteLine("Post Not found");
                    }
                    else
                    {
                        post.Title = updateData.Title;
                        db.Update(post);
                        db.SaveChanges();

                        Console.WriteLine("Blog updated successfully");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


        //Delete Information
        public static void deleteBlogById(int blogId)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var blog = bp.Blogs.Find(blogId);
                    if (blog != null)
                    {
                        bp.Remove(blogId);
                        bp.SaveChanges();
                        Console.WriteLine("Blog deleted successfully");
                        
                    }
                    else
                    {
                        Console.WriteLine("Blog Not found");
                    }

                    Console.WriteLine("Getting Post");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public static void deletePostById(int postId)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var post = bp.Posts.ToList();

                    if (post != null)
                    {
                        bp.Remove(postId);
                        bp.SaveChanges();
                        Console.WriteLine("Post deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Post not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        //Linq functions, Namespace
        //Using Join
        //This was achieveable with the use of navigational properties.
        public static Post getPostById2(int postId)
        {
            try
            {
                using (var bp = new DataContext())
                {
                    var post = bp.Posts.Where(p => p.PostId == postId).Include(p => p.Blog).FirstOrDefault();

                    if (post != null)
                    {
                        Console.WriteLine("---------");
                        Console.WriteLine("Title: " + post.Title);
                        Console.WriteLine("Contetnt: " + post.Content);
                        Console.WriteLine("----------");
                    }
                    else
                    {
                        Console.WriteLine("Post record not found");
                    }
                    return post;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting Post");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.Message);
                }
                throw;

            }
        }
    }
}
