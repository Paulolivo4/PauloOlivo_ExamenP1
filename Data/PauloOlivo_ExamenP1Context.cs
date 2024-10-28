using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PauloOlivo_ExamenP1.Models;

namespace PauloOlivo_ExamenP1.Data
{
    public class PauloOlivo_ExamenP1Context : DbContext
    {
        public PauloOlivo_ExamenP1Context (DbContextOptions<PauloOlivo_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<PauloOlivo_ExamenP1.Models.PO_Tablita> PO_Tablita { get; set; } = default!;
    }
}
