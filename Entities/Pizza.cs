using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IlmhubPizza.Entities
{
    public class Pizza
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(3)]
        public string ShortName { get; set; }

        public EPizzaStockStatusing? StockStatus { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Ingredients { get; set; }

        [Required]
        [MinLength(0)]
        [MaxLength(1000)]
        public double Price { get; set; }


        public Pizza(Guid id, string title, string shortName, EPizzaStockStatusing? stockStatus, string ingredients, double price)
        {
            Id = id;
            Title = title;
            ShortName = shortName;
            StockStatus = stockStatus;
            Ingredients = ingredients;
            Price = price;
        }
    }
}