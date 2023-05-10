namespace Dependency_Injection2 {
    internal class Schaufel : IGrabable {
        public void Buddel(Lehrling l) {
            Console.Write($"{l.Name} benutzt Schaufel: ");
            Thread.Sleep(1000);
            Console.WriteLine("Nach stundenlanger, mühsamer arbeit ist das Loch fertig.");
            Console.WriteLine("");
        }
    }
}
