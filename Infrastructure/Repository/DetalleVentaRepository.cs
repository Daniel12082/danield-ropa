using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Repository;
public class DetalleVentaRepository : GenericRepository<DetalleVenta> , IDetalleVentaRepository
    {
        private readonly danieldropaContext _context;
        public DetalleVentaRepository(danieldropaContext context) : base(context)
        {
            _context = context;
        }
    }
