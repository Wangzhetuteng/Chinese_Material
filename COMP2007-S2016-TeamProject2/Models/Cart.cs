﻿/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628
 * File Description: Create a website that allow customer to view the cuisines and order them online:
 * View food types, food items, food items details; add dood items to Cart; remove food items from cart;
 * Fill out shipping information and promotion code; submit order.
 * WebSite Name: Hai Di Lao Hot Pot
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_TeamProject2.Models
{
    public class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int Count { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual int FoodItemId { get; set; }
        public virtual FoodItem FoodItem { get; set; }
    }
}