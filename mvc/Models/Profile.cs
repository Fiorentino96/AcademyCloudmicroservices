//un namespace è un contenitore, tramite il suo nome usato come prefisso posso accedere a tutto quanti in esso è contenuto
using System.ComponentModel.DataAnnotations;

namespace TodoWebApi.Models
{
    public class Profile
    {

        public Profile()
        {
            Todos = new List<Todo>();
        }
        [Key]
        public int Id{get;set;}
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Town { get; set; }
        public string? Email { get; set; }
        // navigation property
        public List<Todo> Todos { get; set; } 
    }

}