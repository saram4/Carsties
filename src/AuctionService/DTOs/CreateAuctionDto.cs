using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs
{
    public class CreateAuctionDto
    {
        [Required]
        public String Make { get; set; }
        [Required]
        public String Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public String Color { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int ReservePrice { get; set; }
        [Required]
        public DateTime AuctionEnd { get; set; }
    }
}
