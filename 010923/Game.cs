using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Game : Aplication
    {
        private int minimumAge;
        private CategoryGame categoryGame;
        public CategoryGame CategoryGame { get{return categoryGame;} set{categoryGame = value;} }
        public int MinimumAge { get{return minimumAge;} set{ minimumAge = value;} }

        public Game(CategoryGame categoryGame, int minimumAge, List<Review> listReview, string name, double price, bool earlyAccess, double valuation) : base(listReview, name, price, earlyAccess, valuation)
        {
            this.MinimumAge = minimumAge;
            this.CategoryGame = categoryGame;
        }
    }
}