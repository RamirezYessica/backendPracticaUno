// using TodoApi.Models;

// namespace TodoApi.Services
// {
//     public class TodoService
//     {
//         private readonly List<Todo> _todos = new();
//         private int _id = 1;

//         public List<Todo> GetAll() => _todos;

//         public Todo Add(string title)
//         {
//             var todo = new Todo
//             {
//                 Id = _id++,
//                 Title = title,
//                 IsCompleted = false
//             };

//             _todos.Add(todo);
//             return todo;
//         }

//         public void Toggle(int id)
//         {
//             var todo = _todos.FirstOrDefault(t => t.Id == id);
//             if (todo != null)
//                 todo.IsCompleted = !todo.IsCompleted;
//         }
//     }
// }
