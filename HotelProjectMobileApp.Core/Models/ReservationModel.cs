using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectMobileApp.Core.Models
{
    public class ReservationModel:BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }
    }
}
