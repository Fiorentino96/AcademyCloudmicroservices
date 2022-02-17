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
        public string? Description = null;

      
       public int? IdProfile = null;
       // navigation property
        public Profile? Profile = null;
        public int EstimatedHours = 0;
        public States State { get; set; }
        public DateTime CreatedAt { get; set; }

    }


}