namespace Domain.Exceptions
{
    [Serializable]
    public class ProductNotFoundException : Exception
    {
        public string ProductCode { get; } = string.Empty;

        public ProductNotFoundException() { }

        public ProductNotFoundException(string message)
            : base(message) { }

        public ProductNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public ProductNotFoundException(string message, string productCode)
            : base(message)
        {
            ProductCode = productCode;
        }
    }
}
