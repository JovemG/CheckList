using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using CheckList.Models;

namespace CheckList.Data
{
    public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{
		}	
		public DbSet<FuncionarioModel> FuncionarioModel { get; set; }
	}
}
