﻿using MediatR;
using EcommerceWebAPI.Application.Interfaces.RedisCache;

namespace EcommerceWebAPI.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryRequest : IRequest<IList<GetAllBrandsQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllBrands";

        public double CacheTime => 5;
    }
}
