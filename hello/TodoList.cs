//un namespace è un contenitore, tramite il suo nome usato come prefisso posso accedere a tutto quanti in esso è contenuto
namespace TodoWebApi.Model
{
    // qui sto creando una classe di oggetti adatti ad uno scopo preciso
    public class TodoList
    {
        // per membro privato la convenzione CamelCasing usa la prima lettera minuscola
        private List<Todo> internalList = new List<Todo>();
        // il tipo ritornato non è significativo: void
        public void AddItem(Todo item)
        {
            if (internalList.Contains(item))
            {
                throw new Exception("Attenzione: hai già aggiunto questo item alla lavagna!!");
            }
            internalList.Add(item);
        }
        public void PrintItemsList(int wip)
        {
            DateTime dateNow = DateTime.Now;
            Console.Write("Le top " + wip + " Cards in data: ");
            Console.WriteLine(dateNow.ToString("yyyy-MM-dd HH:mm"));
            // un ciclo for è così costituito
            // inizializzazione es int i=0 ; 
            // condizione di permanenza es i<wip ; 
            // espressione(di incremento) da eseguire ad ogni iterazione i++;
            for (int i = 0; i < wip; i++)
                {
                    Console.Write(internalList[i].Title);Console.Write($" - {internalList[i].State.ToString()}");
                    Console.Write($"({internalList[i].Person?.Name} {internalList[i].EstimatedHours}) - Descrizione: ");
                    Console.WriteLine(internalList[i].Description);                    
                }
        }

    }

}