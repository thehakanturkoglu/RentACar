using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public short ModelYear { get; set; }
        public int Kilometer { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
