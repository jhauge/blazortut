using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTut.Data
{
    public class BookingService
    {
        private List<BookingWeek> weeks = new()
        {
            new BookingWeek()
            {
                WeekNumber = 30,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 7, 26), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 27), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 28), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 29), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 30), IsBooked = true, Account = "KK"},
                    new BookingDay() { Date = new DateTime(2021, 7, 31), IsBooked = true, Account = "KK"},
                    new BookingDay() { Date = new DateTime(2021, 8, 1), IsBooked = true, Account = "KK"}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 31,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 2), IsBooked = true, Account = "KK"},
                    new BookingDay() { Date = new DateTime(2021, 8, 3), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 4), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 5), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 6), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 7), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 8), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 32,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 9), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 10), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 11), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 12), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 13), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 14), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 15), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 33,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 16), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 17), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 18), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 19), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 20), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 21), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 22), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 35,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 23), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 24), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 25), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 26), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 27), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 28), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 29), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 36,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 31), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 1), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 2), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 3), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 4), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 5), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 6), IsBooked = false, Account = ""}
                }
            },
        };

        private List<BookingWeek> barnweeks = new()
        {
            new BookingWeek()
            {
                WeekNumber = 30,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 7, 26), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 27), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 28), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 29), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 30), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 7, 31), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 1), IsBooked =  false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 31,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 2), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 3), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 4), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 5), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 6), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 7), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 8), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 32,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 9), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 10), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 11), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 12), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 13), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 14), IsBooked = true, Account = "JM"},
                    new BookingDay() { Date = new DateTime(2021, 8, 15), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 33,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 16), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 17), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 18), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 19), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 20), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 21), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 22), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 35,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 23), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 24), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 25), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 26), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 27), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 28), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 8, 29), IsBooked = false, Account = ""}
                }
            },
            new BookingWeek()
            {
                WeekNumber = 36,
                BookingDays = new[] {
                    new BookingDay() { Date = new DateTime(2021, 8, 31), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 1), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 2), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 3), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 4), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 5), IsBooked = false, Account = ""},
                    new BookingDay() { Date = new DateTime(2021, 9, 6), IsBooked = false, Account = ""}
                }
            },
        };
        public Task<List<BookingWeek>> GetBookingsAsync(string place)
        {
            if (place == "comm") return Task.FromResult(weeks);
            return Task.FromResult(barnweeks);
        }

    }
}