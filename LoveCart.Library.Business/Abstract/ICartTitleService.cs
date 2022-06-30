using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveCart.Library.Entities.Models;
using LoveCart.Library.Utilities.Dto;

namespace LoveCart.Library.Business.Abstract
{
    public interface ICartTitleService
    {
        Task<BaseResponse<IEnumerable<CartTitleDto>>> GetCartsTitlesAsync();
        Task<BaseResponse<CartTitleDto>> GetCartTitleAsync(int Id);
        Task<BaseResponse<IEnumerable<CartDetailDto>>> GetCartDetailsByTitleIdAsync(int Id);
        Task<BaseResponse<int>> CreateCartDetailAsync(CartDetailDto Model);

    }
}
