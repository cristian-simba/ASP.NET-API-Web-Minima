/*Se puede usar un DTO para:

Evitar el exceso de publicación.
Ocultar las propiedades que los clientes no deben ver.
Omitir algunas propiedades para reducir el tamaño de la carga.
Acoplar los gráficos de objetos que contienen objetos anidados. Los gráficos de objetos acoplados pueden ser más cómodos para los clientes.

 */

// DTO
namespace ApiWebMinima.Models
{
    public class TodoItemDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public TodoItemDTO()
        {
            
        }
        public TodoItemDTO(Todo todo) => 
            (Id, Name, IsComplete) = (todo.Id, todo.Name, todo.IsComplete);
    }
}
