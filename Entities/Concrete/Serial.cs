﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Serial : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}