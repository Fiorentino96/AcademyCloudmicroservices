using TodoWebApi.Model;

Console.WriteLine("Ecco un primo esempio di console app scritta in c#");

TodoList KanbanExample = new TodoList();

Todo item1 = new Todo();
item1.Title = "Chiudere la spiegazione di oggi";
item1.EstimatedHours = 2;
item1.Description = "dobbiamo assolutamente fare domande";
item1.Person = new Profile();
item1.Person.Name = "Fiorentino";// setto il nome accedendo con la dot notation all'oggetto appena instanziato
item1.State = States.Todo;

Todo item2 = new Todo();
item2.Title = "Incominciare a vedere del codice";
item2.EstimatedHours = 100;
item2.Person = new Profile() // setto tutte le proprietà con la lista di inizializzazione
{
    Name = "Luca",
    Email = "luca.marafioti@fastwebnet.it",
    Surname = "Marafioti",
    Town = "Genova"
};
item2.State = States.Testing;

Todo item3 = new Todo();
item3.Title = "Ricordare Frase e parola del giorno";
item3.EstimatedHours = 0;
item3.Person = new Profile();
item3.Person.Name = "AndreD";
item3.State = States.Done;
item3.CreatedAt = DateTime.Now.AddDays(-10);

Todo item4 = new Todo();
item4.Title = "Ripasso!!!";
item4.Person = new Profile();
item4.Person.Name = "Chiara";
item4.State = States.Todo;
item4.CreatedAt = DateTime.Now.AddDays(-3);

Todo item5 = new Todo()
{
    CreatedAt = DateTime.Now,
    Id = 100,
    State = States.Todo,
    Title = "Nuovo argomento",
    EstimatedHours = 1,
    Description = "Questa todo è stata creata oggi nel nuovo modello",
    Person = new Profile()
    {
        Id = 100,
        Name = "Nuovo",
        Surname = "Facilitatore",
        Town = "Bologna",
        Email = "mail@site.ext"
    }
};

int wip = 4;

KanbanExample.AddItem(item5);
KanbanExample.AddItem(item1);
KanbanExample.AddItem(item2);
KanbanExample.AddItem(item3);
KanbanExample.AddItem(item4);

//try
//{
//    KanbanExample.AddItem(item4);
//}
//catch (Exception exc)
//{
//    Console.WriteLine(exc.Message);
//}

KanbanExample.PrintItemsList(wip);

// 

if (item4.CreatedAt.Date == item5.CreatedAt.Date)
{
    Console.WriteLine("La card è stata inserita nello stesso giorno");
}
else if (item4.CreatedAt.Date < item5.CreatedAt.Date)
{
    Console.WriteLine("Fare prima la card " + item4.Title);
}
else
{
    Console.WriteLine("Fare prima la card " + item5.Title);
}
//
Console.ReadLine();