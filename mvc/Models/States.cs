using System.ComponentModel;

namespace TodoWebApi.Models
{
    public enum States
    {
        [Description("To do")]
        Todo = 10,
        [Description("In progress")]
        Inprogress = 20,
        [Description("Testing")]
        Testing = 30,
        [Description("Done")]
        Done = 40
    }


}