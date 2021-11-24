using System;

namespace BlazorTut.Data
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Accountname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PlaceId { get; set; }
        public string Place { get; set; }

        public Booking()
        {
            Id = Guid.NewGuid();
            AccountId = Guid.NewGuid();
            Accountname = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(1);
            PlaceId = "all";
            Place = "Hele gården";
        }
    }
}