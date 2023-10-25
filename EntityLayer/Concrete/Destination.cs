using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace EntityLayer.Concrete
{
	public class Destination
	{
        [Key]
        public int DestinationID  { get; set; }

		public string City { get; set; }

        public string DayNight { get; set; }

        public double Price { get; set; }

        public string Image  { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public bool Status { get; set; }


    }
}

