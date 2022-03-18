﻿using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProizvodiController : ControllerBase
    {
        private readonly IProizvodiService _proizvodiService;

        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public IEnumerable<Proizvodi> Get()
        {
            return _proizvodiService.Get();
        }

        [HttpGet("{id}")]
        public Proizvodi GetById(int id)
        {
            return _proizvodiService.GetById(id);
        }
    }
}
