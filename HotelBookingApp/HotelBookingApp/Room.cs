using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public bool Balcony { get; set; }
        public bool DownForRepair { get; set; }
        public int NumberOfBeds { get; set; }
    }
}
