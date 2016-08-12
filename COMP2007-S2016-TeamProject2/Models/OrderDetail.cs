/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628
 * File Description: Create a website that allow customer to view the cuisines and order them online.
 * WebSite Name: Hai Di Lao Hot Pot
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_TeamProject2.Models
{
    public class OrderDetail
    {

        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int FoodItemId { get; set; }
        public virtual FoodItem FoodItem { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}