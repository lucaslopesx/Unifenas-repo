using CodeFirst_AtividadePratica.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst_AtividadePratica.Controllers
{
    public class CategoriaController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria()
            {
                CategoriaId = 1,
                CategoriaName = "Notebooks"

            },
            new Categoria()
            {
                CategoriaId = 2,
                CategoriaName = "Monitores"

            },
            new Categoria()
            {
                CategoriaId = 3,
                CategoriaName = "Impressoras"

            },
            new Categoria()
            {
                CategoriaId = 4,
                CategoriaName = "Mouses"

            },
            new Categoria()
            {
                CategoriaId = 5,
                CategoriaName = "Desktops"

            }
        };
        public IActionResult Index()
        {
            return View(categorias);
        }

        public IActionResult Create()
        {
            return View(); 
        }
    }
}
