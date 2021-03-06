﻿using System;
using System.Text;

namespace Problem_2.Book_Shop
{
    public class Book
    {
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title= title;
            this.Price = price;
        }

        private string author;
        private string title;
        private decimal price;

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            private set
            {
                var nameTokens = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (nameTokens.Length > 1 &&
                    char.IsDigit(nameTokens[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f2}")
                .AppendLine();

            return sb.ToString();
        }

    }
}
