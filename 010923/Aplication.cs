using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Aplication
    {
        private string name;
        private double price;
        private bool earlyAccess;
        private double valuation;
        private List<Review> listReview;
        private object listReviewed;

        public bool EarlyAccess { get{return earlyAccess;} set{earlyAccess = value;} }
        public double Price { get{return price;} set{price = value;} }
        public string Name { get{return name;} set{name = value;} }
        public double Valuation { get{return valuation;} set{valuation = value;} }
        public List<Review> ListReview { get{return listReview;} set{listReview = value;} }

        public Aplication(List<Review> listReview, string name, double price, bool earlyAccess, double valuation)
        {
            this.ListReview = listReview;
            this.Valuation = valuation;
            this.Name = name;
            this.Price = price;
            this.EarlyAccess = earlyAccess;
        }
    }
}