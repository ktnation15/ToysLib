using System.Net.Http.Headers;
using System.Globalization;

namespace ToysLib
{
    public class Toy
    {
        // Properties
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public double Price { get; set; }

        // Methods
        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Price: {Price}";
        }
        // Validation methods
        public void ValidateBrand()
        {
            if(string.IsNullOrEmpty(Brand))
                throw new ArgumentException("Brand is required");
            if (Brand.Length < 2)
                throw new ArgumentException("Brand must be at least 2 characters long");
        }
        public void ValidateModel()
        {
            if(string.IsNullOrEmpty(Model))
                throw new ArgumentException("Model is required");
            if (Model.Length < 2)
                throw new ArgumentException("Model must be at least 2 characters long");
        }
        public void ValidatePrice()
        {
            if(Price <= 0)
                throw new ArgumentException("Price must be greater than 0");
        }
        public void validate()
        {
            ValidateBrand();
            ValidateModel();
            ValidatePrice();
        }
    }
}
