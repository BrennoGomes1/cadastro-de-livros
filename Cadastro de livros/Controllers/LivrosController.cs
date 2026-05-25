using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadastroDeLivros.Data;
using CadastroDeLivros.Models;

namespace CadastroDeLivros.Controllers;

public class LivrosController : Controller
{
    private readonly AppDbContext _context;

    public LivrosController(AppDbContext context)
    {
        _context = context;
    }

    // Listar todos os livros
    public async Task<IActionResult> Index()
    {
        var livros = await _context.Livros.ToListAsync();
        return View(livros);
    }

    // Formulário de criação
    public IActionResult Create()
    {
        return View();
    }

    // Salvar novo livro
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Livro livro)
    {
        if (ModelState.IsValid)
        {
            _context.Add(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(livro);
    }

    // Formulário de edição
    public async Task<IActionResult> Edit(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro == null) return NotFound();
        return View(livro);
    }

    // Salvar edição
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Livro livro)
    {
        if (id != livro.Id) return NotFound();

        if (ModelState.IsValid)
        {
            _context.Update(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(livro);
    }

    // Confirmação de exclusão
    public async Task<IActionResult> Delete(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro == null) return NotFound();
        return View(livro);
    }

    // Confirmar exclusão
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro != null)
        {
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }
}