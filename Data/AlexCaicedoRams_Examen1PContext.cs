using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlexCaicedoRams_Examen1P.Models;

namespace AlexCaicedoRams_Examen1P.Data
{
    public class AlexCaicedoRams_Examen1PContext : DbContext
    {
        public AlexCaicedoRams_Examen1PContext (DbContextOptions<AlexCaicedoRams_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<AlexCaicedoRams_Examen1P.Models.AlexCaicedo_Tabla> AlexCaicedo_Tabla { get; set; } = default!;
    }
}
