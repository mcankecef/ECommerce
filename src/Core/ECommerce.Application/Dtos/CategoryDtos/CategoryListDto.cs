﻿using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Dtos
{
    public class CategoryListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
