//un namespace è un contenitore, tramite il suo nome usato come prefisso posso accedere a tutto quanti in esso è contenuto
namespace TodoWebApi.Model
{
    // qui sto creando una classe di oggetti adatti ad uno scopo preciso
    public class ProfileList
    {
        // per membro privato la convenzione CamelCasing usa la prima lettera minuscola
        private List<Profile> internalList = new List<Profile>();
        // il tipo ritornato non è significativo: void
        public void AddItem(Profile profile)
        {
            if (internalList.Contains(profile))
            {
                throw new Exception("Attenzione: hai già aggiunto questo profile alla lista profili!!");
            }
            internalList.Add(profile);
        }
        public void PrintProfilesList(int top)
        {
            // un ciclo for è così costituito
            // inizializzazione es int i=0 ; 
            // condizione di permanenza es i<wip ; 
            // espressione(di incremento) da eseguire ad ogni iterazione i++;
            for (int i = 0; i < top; i++)
                {
                    Console.Write(internalList[i].Email);
                    Console.Write($"({internalList[i].Name} {internalList[i].Surname}) - Descrizione: ");
                    Console.WriteLine(internalList[i].Town);                    
                }
        }

    }

}