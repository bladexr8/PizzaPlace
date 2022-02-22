using System.Collections.Generic;
/**
  * Class for sending data from server to client
  * and vice versa
  **/

  namespace PizzaPlace.Shared {

      public class Basket {
          public Customer Customer { get; set; } = new Customer();
          public List<int> Orders { get; set; } = new List<int>();
          public bool HasPaid { get; set; } = false;

          public void Add(int pizzaId) {
            Orders.Add(pizzaId);
          }

          public void RemoveAt(int index) {
              Orders.RemoveAt(index);
          }
      }

  }
