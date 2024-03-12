using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;

public class TodoController : Controller
{
    private static List<TodoItem> todoList = new List<TodoItem>();

    public IActionResult Index()
    {
        return View(todoList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TodoItem todoItem)
    {
        todoItem.Id = todoList.Count + 1;
        todoList.Add(todoItem);
        return RedirectToAction("Index");
    }

    public IActionResult MarkAsCompleted(int id)
    {
        var todoItem = todoList.Find(item => item.Id == id);
        if (todoItem != null)
        {
            todoItem.IsCompleted = true;
        }
        return RedirectToAction("Index");
    }
}


