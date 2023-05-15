using Article_struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 1.Описати структуру Article, що містить такі поля: код товару; Назва товару; ціну товару.
// 2.Описати перелік(enum) ArticleType, який визначає типи товарів, і додати відповідне поле в структуру Article із завдання №1.

namespace Article_struct
{
    public enum ArticleType { Beverages, Bakery, Meat, Vegetables, Fruits, Other }

    struct Article
    {
        public int ProductId;
        public string ProductTitle;
        public decimal ProductPrice;
        public ArticleType ProductType;

        public void Print(int n)
        {
            Console.WriteLine($"Item N: {n} \tID: {ProductId} \tTitle: {ProductTitle} \tPrice: {ProductPrice} \tType: {ProductType}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Article[] articles = new Article[4]
            {
                new Article { ProductId = 123, ProductTitle = "Coffee", ProductPrice = 35.0m, ProductType = ArticleType.Beverages },
                new Article { ProductId = 452, ProductTitle = "Bread", ProductPrice = 17.0m, ProductType = ArticleType.Bakery },
                new Article { ProductId = 8663, ProductTitle = "Meat", ProductPrice = 170.0m, ProductType = ArticleType.Meat },
                new Article { ProductId = 304, ProductTitle = "Cucumber", ProductPrice = 130.0m, ProductType = ArticleType.Vegetables }
            };

            for (int i = 0; i < articles.Length; i++) { articles[i].Print(i); }
        }
    }
}


