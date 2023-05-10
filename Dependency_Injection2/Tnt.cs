namespace Dependency_Injection2 {
    internal class Tnt : IGrabable {
        public event EventHandler<TntEventArgs> TntEvent;
        public void Buddel(Lehrling l) {
            Random rnd = new Random();
            int x = rnd.Next(0,2);
            if (x != 0) {
                Console.WriteLine($"{l.Name} benutzt TNT\nKawuum!");
                Thread.Sleep(1000);
                Console.WriteLine("Sprengung erfolgreich.");
            } else if (x == 0) {
                Console.WriteLine($"{l.Name} benutzt TNT\nKawuum!!!!!");
                Thread.Sleep(1000);
                Console.WriteLine("Sprengung erfolgreich aber der Lehrling ist tot.");
                TntEvent(this, new TntEventArgs() { person = l});
            }
            Console.WriteLine("");
        }
    }
}
