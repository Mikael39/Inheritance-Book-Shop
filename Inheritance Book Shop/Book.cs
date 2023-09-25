using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Book_Shop
{
    public class Book
    {

        protected string title;
        protected string author;
        protected decimal price;


        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {   
                string input = value.Split(' ')[1];
                bool startWithInt = char.IsDigit(input[0]);
                if (startWithInt ) 
                {
                    throw new ArgumentException("\"Author not valid!\"");
                }
                else
                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
              
                if (value.Length < 3)
                {
                    throw new ArgumentException("\"Title not valid!\"");
                }
                else
                    this.title = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {

                if (value <= 0) 
                {
                    throw new ArgumentException("Price not valid!");
                }
                else
                 this.price = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
                   
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }



    }
}
