using System;

namespace BlazorTut.Data
{
    public class BookingDay
    {
        public DateTime Date { get; set; }
        public bool IsBooked { get; set; }
        public string Account { get; set; }
    }
}