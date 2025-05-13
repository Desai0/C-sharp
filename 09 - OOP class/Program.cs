namespace Classs
{
    class Cat // public/internal
    {
        class CatData // Двигатель содержится в машине (Композиция)
        { //  public/internal/protected/private

        }
        public int Whiskers { get; private set; } // было полем стало свойством
        
        public int GetSetWhiskers
        {
            get => Whiskers;
            set {
                if (value > 0)
                    Whiskers = value;
            }
        }
        
        public string Tail { private get; set; } = "Black";

        public void Lie()
        {

        }

        public Cat() : this(4, "Black" { }
        public Cat(int whiskers) {
            Whiskers = whiskers;
        }
        public Cat(int whiskers, string tail) {
            Whiskers = whiskers;
            Tail = tail;
        }

        class Kitten : Cat
        {
            public Kitten() : base(4) { }
        }
    }
}