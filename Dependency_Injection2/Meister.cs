﻿namespace Dependency_Injection2 {
    internal class Meister {
        public List<Lehrling> Lehrlinge { get; set; } = new List<Lehrling>();
        public Tnt tnt { get; set; }
        Schaufel schaufel = new Schaufel();
        public int MyProperty { get; set; }
        public void ZeigeLehrlinge() {
            if (Lehrlinge.Count == 0) {
                Console.WriteLine("Zur zeit habe ich keine Lehrlinge");
            } 
            for (int i = 0; i < Lehrlinge.Count; i++) {            
                Console.WriteLine($"Lehrling Nummer {i+1} heisst {Lehrlinge[i].Name}");
            }
        }
        public void Gibanweisung() {
            if (Lehrlinge.Count > 0) {
                Random rnd = new();
                int x = rnd.Next(0, 2);
                if (x != 0) {
                    Lehrlinge.First().GrabLoch(tnt);
                }
                else if (x == 0) {
                    Lehrlinge.First().GrabLoch(schaufel);
                }
            }else {
                Console.WriteLine("Sorry, alle Lehrlinge sind verbraucht");
            }
        }
        public void Beileid(object source, TntEventArgs e) {
            Console.WriteLine($"Mein Beileid, {e.person.Name} ist bei grabung mit TnT gestorben.");
            Lehrlinge.Remove(e.person);
        }
    }
}
