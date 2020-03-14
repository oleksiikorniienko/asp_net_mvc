using System;
namespace aspnet2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
