using Microsoft.AspNetCore.Mvc;
using PWFilmes.API.Context;
using PWFilmes.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PWFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private PWFilmesContext _context;

        public CategoriaController(PWFilmesContext context)
        {
            _context = context;
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {

            _context.CategoriaSet.ToList();

            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria { Codigo = 1, Descricao = "Terror", Cor = "Vermelho" });
            categorias.Add(new Categoria { Codigo = 2, Descricao = "Suspense", Cor = "Azul" });
            categorias.Add(new Categoria { Codigo = 3, Descricao = "Comédia", Cor = "Amarelo" });
            categorias.Add(new Categoria { Codigo = 4, Descricao = "Romance", Cor = "Cinza" });
            categorias.Add(new Categoria { Codigo = 5, Descricao = "Fantasia", Cor = "Rosa" });
            categorias.Add(new Categoria { Codigo = 6, Descricao = "Aventura", Cor = "Verde" });

            return Ok(categorias);
        }
        
        [HttpGet("obter/{codigo}")] //Nome q está entre chaves tem q estar obrigatóriamente nos parâmetros da class
            public IActionResult Obter( int codigo)
            {
                List<Categoria> categorias = new List<Categoria>();
                categorias.Add(new Categoria { Codigo = 1, Descricao = "Terror", Cor = "Vermelho" });
                categorias.Add(new Categoria { Codigo = 2, Descricao = "Suspense", Cor = "Azul" });

                Categoria cat = categorias.FirstOrDefault(p => p.Codigo == codigo); // p = Propercies/ Propriedade 

                return Ok(cat);
            }
        }
}
