﻿using System.Collections.Generic;

namespace VidlyNew.Dtos
{
    public class NewRentalsDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}