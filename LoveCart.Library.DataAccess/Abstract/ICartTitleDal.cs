

using LoveCart.Library.DataAccess.Concrete.Repository;
using LoveCart.Library.Entities.Models;
using LoveCart.Library.Utilities.Dto;

namespace LoveCart.Library.DataAccess.Abstract;

    public interface ICartTitleDal : IGenericRepository
{
    Task<IEnumerable<CartTitleDto>> GetAllAsync();
    Task<CartTitleDto> GetCartTitleAsync(int Id);
    Task<IEnumerable<CartDetailDto>> GetCartDetailsByTitleIdAsync(int Id);
    Task<int> CreateCartDetailAsync(CartDetailDto Model);


}

