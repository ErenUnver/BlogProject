﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=305-08;Database=Db_BlogCoree;User=WebMobile_302;Password=webmobile.302;");
	
		}
		public DbSet<About> Abouts{ get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contact { get; set; }
		public DbSet<Writer> Writers { get; set; }

		public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogReyting> BlogReytings { get; set; }






    }
}
