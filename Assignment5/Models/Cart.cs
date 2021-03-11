using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Textbook book, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.textbook.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    textbook = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Textbook book) =>
            Lines.RemoveAll(x => x.textbook.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public double ComputeTotalSum() => Lines.Sum(e => e.textbook.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Textbook textbook { get; set; }
            public int Quantity { get; set; }
        }
    }
}
