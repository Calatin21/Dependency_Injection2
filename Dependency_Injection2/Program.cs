namespace Dependency_Injection2 {
    internal class Program {
        static void Main(string[] args) {
            Meister meister = new Meister();
            meister.Lehrlingeinstellen("Peter0");
            meister.Lehrlingeinstellen("Peter1");
            meister.Lehrlingeinstellen("Peter2");
            meister.Lehrlingeinstellen("Peter3");
            meister.Lehrlingeinstellen("Peter4");
            meister.Lehrlingeinstellen("Peter5");
            Tnt tnt = new Tnt();
            tnt.TntEvent += meister.Beileid;
            meister.tnt = tnt;
            
            meister.ZeigeLehrlinge();
            for (int i = 0; i < 20; i++) {
                meister.Gibanweisung();
            }
            meister.ZeigeLehrlinge();
            IGrabable schueppe = new Schaufel();
        }
    }
}