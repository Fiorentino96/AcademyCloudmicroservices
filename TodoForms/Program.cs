namespace TodoForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // fonte di form.designer:
        // https://www.geeksforgeeks.org/button-in-c-sharp/

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        
        ApplicationConfiguration.Initialize();
        
        Form1 f = new Form1();
        Application.Run(f);

        

    }    
}