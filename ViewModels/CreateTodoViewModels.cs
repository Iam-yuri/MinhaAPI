using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.ViewModels
{
    public class CreateTodoViewModels
    {
        [Required]
        public string Title { get; set; }
    }
}
