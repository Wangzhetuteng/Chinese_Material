/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628, Zhen Zhang 200257444
 * File Description: Create a website that allow customer to view the cuisines and order them online:
 * View food types, food items, food items details; add dood items to Cart; remove food items from cart;
 * Fill out shipping information and promotion code; submit order.
 * WebSite Name: Hai Di Lao Hot Pot
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_TeamProject2.Models
{
    public class FoodItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodItem()
        {

        }
        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public FoodItem(string Title)
        {
            this.Title = Title;
        }

        [Display(Name = "Food Item")]
        public virtual int FoodItemId { get; set; }
        public virtual string Title { get; set; }
        [DisplayName("Food Item Thumbnail URL")]
        public virtual string FoodItemThumbnailImageUrl { get; set; }

        [DisplayName("Food Type")]
        public virtual int FoodTypeId { get; set; }
        public virtual FoodType FoodType { get; set; }

        [DisplayName("Short Description")]
        public virtual int ShortDescriptionId { get; set; }
        [DisplayName("Detailed Description")]
        public virtual int DetailedDescriptionId { get; set; }

        public virtual decimal Price { get; set; }





        [DisplayName("Food Item Large Image URL")]
        public virtual string FoodItemLargeImageUrl { get; set; }

        public virtual string ShortDescription { get; set; }
        public virtual string DetailedDescription { get; set; }


        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}