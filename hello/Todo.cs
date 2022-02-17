namespace TodoWebApi.Model
{
    // è un DTO
    public class Todo
    {
        // naming convention: 
        //Camel casing 
        public int Id{get;set;}
        private string title=string.Empty;
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
        public Profile? Person = null;
        public int EstimatedHours = 0;
        public States State { get; set; }  
        public DateTime CreatedAt {get;set;}   

    }


}