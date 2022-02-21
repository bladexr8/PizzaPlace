using System;

/**
  * Class for sending data from server to client
  * and vice versa
  **/

namespace PizzaPlace.Shared {

    public enum Spiciness {
        None,
        Spicy,
        Hot
    }

    public class Pizza {
      // constructor
      public Pizza(int id, string name, decimal price, 
                      Spiciness spiciness) {
        this.Id = id;
        this.Name = name
          ?? throw new ArgumentNullException(nameof(name), 
            "A pizza needs a name!");
        this.Price = price;
        this.Spiciness = spiciness;
      }

      // immutable properties (can only be set in constructor)
      public int Id { get; }
      public string Name { get; }
      public decimal Price { get; }
      public Spiciness Spiciness { get; }
    }

}