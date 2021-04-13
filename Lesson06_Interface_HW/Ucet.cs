namespace Lesson06_Interface_HW
{
    class Ucet : IUcet
    {
        public int Zustatek { get; set; }

        public string Vlastnik { get;}

        public Ucet(int zustatek, string vlastnik)
        {
            Zustatek = zustatek;
            Vlastnik = vlastnik;
        }
    }
}
