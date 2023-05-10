namespace Dependency_Injection2 {
    internal class Program {
        static void Main(string[] args) {
            Meister meister = new Meister();
            meister.Lehrlinge.Add(new Lehrling() { Name = "Peter0"});
            meister.Lehrlinge.Add(new Lehrling() { Name = "Peter1"});
            meister.Lehrlinge.Add(new Lehrling() { Name = "Peter2"});
            meister.Lehrlinge.Add(new Lehrling() { Name = "Peter3" });
            Tnt tnt = new Tnt();
            tnt.TntEvent += meister.Beileid;
            meister.tnt = tnt;
            meister.ZeigeLehrlinge();
            for (int i = 0; i < 20; i++) {
                meister.Gibanweisung();
            }
            meister.ZeigeLehrlinge();
        }
    }
}