﻿namespace ECommerce.Application.Dtos.ProductDtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
    }
}
