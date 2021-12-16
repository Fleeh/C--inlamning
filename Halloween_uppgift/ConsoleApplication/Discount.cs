using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounting
{
    public class Discount
    {
        public Discount(Guid discountId, string name)
        {
            DiscountId = discountId;
            Name = name;
        }

        public Guid DiscountId { get; set; }
        public string Name { get; set; }
    }
}
