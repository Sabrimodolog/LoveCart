using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ragnarok.Library.Entities.Abstract;

namespace LoveCart.Library.Utilities.Dto
{
    public class CartDetailDto : BaseEntity, IDto
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Images { get; set; }
        public DateTime Date { get; set; }
        public int TitleId { get; set; }
    }
}
