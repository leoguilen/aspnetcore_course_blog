﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Medium.Core.Domain
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; set; }
    }
}
