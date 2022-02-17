//un namespace è un contenitore, tramite il suo nome usato come prefisso posso accedere a tutto quanti in esso è contenuto
namespace TodoWebApi.Model
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Town { get; set; }
        public string? Email { get; set; }
    }

}