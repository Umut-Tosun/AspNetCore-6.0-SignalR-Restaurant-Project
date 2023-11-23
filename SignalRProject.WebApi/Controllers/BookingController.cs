using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.BookingDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService BookingService)
        {
            _BookingService = BookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _BookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking Booking = new Booking()
            {
                Date = createBookingDto.Date,
                FirstName = createBookingDto.FirstName,
                LastName = createBookingDto.LastName,
                Mail = createBookingDto.Mail,
                PersonCount = createBookingDto.PersonCount,
                PhoneNumber = createBookingDto.PhoneNumber,

            };
            _BookingService.Tadd(Booking);
            return Ok("Hakkımda kısmı başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _BookingService.TGetById(id);
            _BookingService.Tdelete(value);
            return Ok("Hakkımda alanı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking Booking = new Booking()
            {
                BookingId = updateBookingDto.BookingId,
                Date = updateBookingDto.Date,
                FirstName = updateBookingDto.FirstName,
                LastName = updateBookingDto.LastName,
                Mail = updateBookingDto.Mail,
                PersonCount = updateBookingDto.PersonCount,
                PhoneNumber = updateBookingDto.PhoneNumber,
            };
            _BookingService.Tupdate(Booking);
            return Ok("Hakkımda alanı güncellendi.");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _BookingService.TGetById(id);
            return Ok(value);
        }
    }
}
