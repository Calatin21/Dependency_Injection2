namespace Dependency_Injection2 {
    internal class Lehrling {        
        public string Name { get; set; }
        public void GrabLoch(IGrabable werkzeug) {
            werkzeug.Buddel(this);                   
        }
    }
}
