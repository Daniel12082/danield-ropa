using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Repository;
public class VentaRepository : GenericRepository<Venta> , IVentaRepository
    {
        private readonly danieldropaContext _context;
        public VentaRepository(danieldropaContext context) : base(context)
        {
            _context = context;
        }
    }
