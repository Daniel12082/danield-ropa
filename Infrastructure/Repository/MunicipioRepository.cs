using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Repository;
public class MunicipioRepository : GenericRepository<Municipio> , IMunicipioRepository
    {
        private readonly danieldropaContext _context;
        public MunicipioRepository(danieldropaContext context) : base(context)
        {
            _context = context;
        }
    }
