

using LoveCart.Library.Entities.Abstract;

namespace LoveCart.Library.Entities.Dto;

    public class CartTitleDto : BaseEntity, IDto
    {
    public  string QrCode { get; set; }
    public  DateTime CreateDate { get; set; }
    public  string Name { get; set; }
    }

