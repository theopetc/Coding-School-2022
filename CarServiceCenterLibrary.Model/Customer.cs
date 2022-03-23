using System.ComponentModel.DataAnnotations;

namespace CarServiceCenterLibrary
{
    public class Customer : Person
    {
        public string Phone { get; set; }
        
        [Required]
        public string TIN { get; set; }
        public Customer()
        {

        }

    }

}