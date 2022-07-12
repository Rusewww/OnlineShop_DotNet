using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop_DotNet.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Enter name:")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Minimum lenth 3")]
        public string name { get; set; }

        [Display(Name = "Enter surname:")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Minimum lenth 2")]
        public string surname { get; set; }

        [Display(Name = "Enter adress:")]
        [StringLength(255, MinimumLength = 10, ErrorMessage = "Minimum lenth 10")]
        public string adress { get; set; }

        [Display(Name = "Enter phone number:")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(255, MinimumLength = 10, ErrorMessage = "Minimum lenth 10")]
        public string phone { get; set; }

        [Display(Name = "Enter email:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Minimum lenth 6")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public OrderDetail orderDetails { get; set; }
    }
}
