namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Code { get; private set; }

        public Product(string? name, string? code)
        {
            Name = name;
            Code = code;
        }
    }
}