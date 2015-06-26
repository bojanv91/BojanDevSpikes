using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.DomainEventsExample.Core
{
    public class BookingCartItem
    {
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
    }

    public class BookingCart
    {
        private IList<BookingCartItem> _items = new List<BookingCartItem>();
        private int _nightsOfStay = 0;

        public void AddRoom(string roomType, decimal pricePerNight)
        {
            _items.Add(new BookingCartItem() { RoomType = roomType, PricePerNight = pricePerNight });
        }

        public void ChangeNightsOfStay(int nightsOfStay)
        {
            nightsOfStay = nightsOfStay;
        }
    }
}
