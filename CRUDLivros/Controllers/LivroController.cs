using System;
using System.Linq;
using CRUDLivros.Database;
using CRUDLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDLivros.Controllers
{
    public class LivroController : Controller
    {

        private readonly ApplicationDbContext database;

        public LivroController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            var livro = database.Livros.ToList();
            
            return View(livro); 
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Livro livro = database.Livros.First(registro => registro.Id == id);
            return View("Cadastrar", livro);  
        }

        public IActionResult Deletar(int id)
        {
            Livro livro = database.Livros.First(registro => registro.Id == id);
            database.Livros.Remove(livro);
             database.SaveChanges();
           return RedirectToAction("Index");  
        }

        [HttpPost]
        public IActionResult Salvar(Livro livro)
        {
            if(livro.Id == 0)
            {
                database.Livros.Add(livro);}
            else
            {
                Livro livroDoBanco = database.Livros.First(registro => registro.Id == livro.Id);
            
                livroDoBanco.Titulo = livro.Titulo;
                livroDoBanco.Autor = livro.Autor;
                livroDoBanco.Editora = livro.Editora;
                livroDoBanco.Ano = livro.Ano;
                livroDoBanco.Genero = livro.Genero;
            }

            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}