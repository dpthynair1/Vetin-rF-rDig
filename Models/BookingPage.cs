using System;
using System.Collections.Generic;
using System.Linq;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Docter_MVC_Miniproject3.Models
{
    public class BookingPage
    {
        private readonly ApplicationDbContext _appDbContext;
        public string BookingPageId { get; set; }
        public List<BookingPageItem> BookingPageItems { get; set; }
        

        public BookingPage(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static BookingPage GetBooking(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            Console.WriteLine(cartId);

            return new BookingPage(context) { BookingPageId = cartId };
        }

        public void AddToBookingPage(Appointment appointment, int amount)
        {


            var bookingPageItem =
                    _appDbContext.BookingPageItems.SingleOrDefault(
                        s => s.Appointment.AppointmentId == appointment.AppointmentId && s.Appointment.IsAvailable == true && s.BookingPageId == BookingPageId);

            if (bookingPageItem == null )
            {
                bookingPageItem = new BookingPageItem
                {
                    BookingPageId = BookingPageId,
                    Appointment = appointment,


                    ConsultationFee = 295,
                    Amount = 1
                };
                appointment.IsAvailable = false;

                _appDbContext.Appointments.Update(appointment);
                _appDbContext.BookingPageItems.Add(bookingPageItem);

              //  _appDbContext.SaveChanges();
              
            }
            else
            {
                bookingPageItem.Amount++;
            }
            _appDbContext.SaveChanges();

        }
        public List<BookingPageItem> GetBookingPageItems()
        {
            return BookingPageItems ??
                   (BookingPageItems =
                       _appDbContext.BookingPageItems.Where(c => c.BookingPageId == BookingPageId)
                           .Include(s => s.Appointment.Doctor)
                           .ToList());

        }

        //public decimal GetShoppingCartTotal()
        //{
        //    var total = _appDbContext.BookingPageItems.Where(c => c.BookingPageId == BookingPageId)
        //        .Select(c => c.Appointment.Price * c.Amount).Sum();
        //    return total;
        //}

        public void ClearBookingPage()
        {
            var BookinPageItems = _appDbContext
                .BookingPageItems
                .Where(page => page.BookingPageId == BookingPageId);

            _appDbContext.BookingPageItems.RemoveRange(BookinPageItems);

            _appDbContext.SaveChanges();
        }


    }
}
