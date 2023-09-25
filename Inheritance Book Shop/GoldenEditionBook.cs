using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Book_Shop
{
    internal class GoldenEditionBook : Book
    {
        double multiplier = 1.30;
        public override decimal Price => Decimal.Multiply(base.Price, (decimal)multiplier);

        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }
    }


  

}
