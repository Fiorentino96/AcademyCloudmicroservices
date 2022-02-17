using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoWebApi.Models
{
    // è un DTO
    public class Todo
    {
        // naming convention: 
        //Camel casing 

        [Key]
        public int Id { get; set; }
        private string title = string.Empty;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value.ToUpper();
            }
        }
        public string? Description { get; set; } = null;

     
        public int? IdProfile { get; set; } = null;
       // navigation property
        [ForeignKey("IdProfile")]
        public Profile? Profile { get; set; } = null;
        public int EstimatedHours { get; set; } = 0;
        public States State { get; set; }
        public DateTime CreatedAt { get; set; }

    }


}