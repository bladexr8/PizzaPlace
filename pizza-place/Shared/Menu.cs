using System.Collections.Generic;
using System.Linq;

/**
  * Class for sending data from server to client
  * and vice versa
  **/

namespace PizzaPlace.Shared {

    public class Menu {
        public List<Pizza> Pizzas { get; set; }
            = new List<Pizza>();

        public Pizza GetPizza(int id)
            => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
