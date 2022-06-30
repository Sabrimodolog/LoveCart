using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveCart.Library.Business.Abstract;
using LoveCart.Library.DataAccess.Abstract;
using LoveCart.Library.Entities.Models;
using LoveCart.Library.Utilities.Dto;

namespace LoveCart.Library.Business.Concrete
{
    public class CartTitleManager: ICartTitleService
    {
        private readonly ICartTitleDal _cartTitleDal;
        public CartTitleManager(ICartTitleDal cartTitleDal)
        {
                this._cartTitleDal=cartTitleDal;
        }
        public async Task<BaseResponse<IEnumerable<CartTitleDto>>> GetCartsTitlesAsync()
        {
            var data = await _cartTitleDal.GetAllAsync();
         
            return new BaseResponse<IEnumerable<CartTitleDto>>(data,true) ;
        }


        public async Task<BaseResponse<CartTitleDto>> GetCartTitleAsync(int Id)
        {
            var data = await _cartTitleDal.GetCartTitleAsync(Id);
            var DetailList = await _cartTitleDal.GetCartDetailsByTitleIdAsync(data.Id);
            data.CartDetails = DetailList.ToList();
            return new BaseResponse<CartTitleDto>(data, true);
        }

        public async Task<BaseResponse<IEnumerable<CartDetailDto>>> GetCartDetailsByTitleIdAsync(int Id)
        {
            var data = await _cartTitleDal.GetCartDetailsByTitleIdAsync(Id);
            return new BaseResponse<IEnumerable<CartDetailDto>>(data, true);
        }

        public async Task<BaseResponse<int>> CreateCartDetailAsync(CartDetailDto Model)
        {
            var data = await _cartTitleDal.CreateCartDetailAsync(Model);
            return new BaseResponse<int>(data, true);
        }
    }
}
