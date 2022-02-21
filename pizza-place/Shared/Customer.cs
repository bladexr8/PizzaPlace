using System.ComponentModel.DataAnnotations;
/**
  * Class for sending data from server to client
  * and vice versa
  **/

namespace PizzaPlace.Shared {

    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}