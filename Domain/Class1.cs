namespace Domain
{
    public class Meting
    {
        public int Id { get; set; }

        public int Waarde { get; init; }

        public string SomeText { get; set; }

        public Meting(int waarde)
        {
            Waarde = waarde;
        }

        public bool IsPositive => Waarde > 0;
    }
}