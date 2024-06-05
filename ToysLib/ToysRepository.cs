using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib
{
    public class ToysRepository
    {
        
        private List<Toy> toys = new List<Toy>
        {
            new Toy { Id = 1, Brand = "Lego", Model = "Star Wars", Price = 19 },
            new Toy { Id = 2, Brand = "Playmobil", Model = "Pirate", Price = 25 },
            new Toy { Id = 3, Brand = "Barbie", Model = "Fashion", Price = 15 },
            new Toy { Id = 4, Brand = "Playmobil", Model = "Knights", Price = 30 },
            new Toy { Id = 5, Brand = "Lego", Model = "City", Price = 20 }
        };
        public Toy GetById(int id)
        {
            Toy? toy = toys.FirstOrDefault(t => t.Id == id);
            if (toy == null)
            { 
                throw new ArgumentException("Toy not found");
            }
            return toy;
        }
        public List<Toy> GetAll(int price = 0, string? brand = null )
        {
            List<Toy> toys = new List<Toy>();
            if (price > 0)
            {
                toys = this.toys.Where(t => t.Price <= price).ToList();
            }
            else
            {
                toys = this.toys;
            }
            if (brand != null)
            {
                toys = toys.Where(t => t.Brand == brand).ToList();
            }
            return toys;
        }
        public Toy Add(Toy toy)
        {
            toy.validate();
            toys.Add(toy);
            return toy;
        }
        public Toy Remove(int id)
        {
            Toy toy = GetById(id);
            toys.Remove(toy);
            return toy;
        }
        
    }
}
