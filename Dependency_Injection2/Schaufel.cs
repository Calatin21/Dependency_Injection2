namespace Dependency_Injection2 {
    internal class Schaufel : IGrabable {
        public void Buddel(Lehrling l) {
            Console.WriteLine($"{l.Name} benutzt Schaufel:\nNach stundenlanger, mühsamer arbeit ist das Loch fertig.");
            Console.WriteLine("");
        }
    }
}
