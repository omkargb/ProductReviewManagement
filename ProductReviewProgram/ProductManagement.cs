using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewProgram
{
    public class ProductManagement
    {
        List<ProductReview> ProductList;

        public void ProductReviews()
        {
            ProductList = new List<ProductReview>
            {
                new ProductReview() { ProductId = 10, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 111, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 60, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 12, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 50, UserId = 16, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 40, UserId = 111, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 11, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 15, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "bad", isLike = false }
            };
        }

        public void Top3Products(List<ProductReview> ProductList)
        {
            var result = (from pr 
                          in ProductList 
                          orderby pr.Rating descending
                          select pr).Take(3);

            Console.WriteLine(" displaying Top 3 products");
        
            foreach (ProductReview p in ProductList)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.isLike);
            }
        }
    }
}
