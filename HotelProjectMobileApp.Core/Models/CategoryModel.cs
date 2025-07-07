using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectMobileApp.Core.Models
{
    public class CategoryModel:BaseModel
    {
        
        //public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryDescription { get; set; }
        public string RoomPay { get; set; }
        public int PersonCount { get; set; }
    }
}
