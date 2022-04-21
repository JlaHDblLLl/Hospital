namespace _5._1
{
    public class Adress
    {
        public string Street { get; set; }
        public string House { get; set; }
        public Adress(string street, string house)
        {
            this.Street = street;
            this.House = house;
        }
    }
}