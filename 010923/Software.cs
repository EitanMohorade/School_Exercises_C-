using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Software : Aplication
    {
        private CategorySoftware categorySoftware;
        public CategorySoftware CategorySoftware { get{return categorySoftware;} set{categorySoftware = value;} }

        public Software(CategorySoftware categorySoftware, List<Review> listReview, string name, double price, bool earlyAccess, double valuation) : base(listReview ,name, price, earlyAccess, valuation)
        {
            this.categorySoftware = categorySoftware;
        }
    }
}