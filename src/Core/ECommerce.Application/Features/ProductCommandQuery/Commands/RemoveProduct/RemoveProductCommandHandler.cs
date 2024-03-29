﻿using AutoMapper;
using MediatR;
using ECommerce.Application.Dtos;
using ECommerce.Application.Interfaces.Repository;
using ECommerce.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Application.Common.Exceptions;

namespace ECommerce.Application.Features.ProductCommandQuery.Commands.RemoveProduct
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommandRequest, CustomResponseDto<NoContentDto>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public RemoveProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<NoContentDto>> Handle(RemoveProductCommandRequest request, CancellationToken cancellationToken)
        {
            var removeProduct = await _repository.GetByIdAsync(request.Id);
            
            if (removeProduct is null)
                throw new NotFoundException($"Product is not found");
            
            await _repository.RemoveAsync(removeProduct);

            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
