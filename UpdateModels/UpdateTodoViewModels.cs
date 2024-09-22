using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.ViewModels
{
    public class UpdateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
