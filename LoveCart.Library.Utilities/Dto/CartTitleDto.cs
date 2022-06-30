

using Ragnarok.Library.Entities.Abstract;

namespace LoveCart.Library.Utilities.Dto;

    public class CartTitleDto : BaseEntity, IDto
    {
    public  string QrCode { get; set; }
    public  DateTime CreateDate { get; set; }
    public  string Name { get; set; }
    public  string Name2 { get; set; }
    public List<CartDetailDto> CartDetails { get; set; }


}

