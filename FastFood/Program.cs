namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository newRep = new Repository();
            Service newService = new Service(newRep);
            UI newUI = new UI(newService);

            newUI.MainMenu();
        }
    }
}
