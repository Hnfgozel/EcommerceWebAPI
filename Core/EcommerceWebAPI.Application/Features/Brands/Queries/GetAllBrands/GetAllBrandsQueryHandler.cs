using EcommerceWebAPI.Application.Bases;
using EcommerceWebAPI.Application.Interfaces.AutoMapper;
using EcommerceWebAPI.Application.Interfaces.UnitOfWorks;
using EcommerceWebAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EcommerceWebAPI.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryHandler : BaseHandler, IRequestHandler<GetAllBrandsQueryRequest, IList<GetAllBrandsQueryResponse>>
    {
        public GetAllBrandsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllBrandsQueryResponse>> Handle(GetAllBrandsQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await unitOfWork.GetReadRepository<Brand>().GetAllAsync();

            return mapper.Map<GetAllBrandsQueryResponse, Brand>(brands);
        }
    }
}
