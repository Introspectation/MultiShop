using MT.MS.Discount.Dtos;
using MultiShop.Discount.Context;

namespace MT.MS.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        /*public Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons (Code, Rate, IsActive, ValidDate) values (@code, @rate, @Is"
        }*/

        public Task DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCouponDto>> GetAllCouponAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCouponDto> GetByIdCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            throw new NotImplementedException();
        }
    }
}
