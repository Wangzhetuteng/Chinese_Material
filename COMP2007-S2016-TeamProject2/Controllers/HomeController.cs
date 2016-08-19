/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628, Zhen Zhang 200257444
 * File Description: Create a website that allow customer to view the cuisines and order them online:
 * View food types, food items, food items details; add dood items to Cart; remove food items from cart;
 * Fill out shipping information and promotion code; submit order.
 * WebSite Name: Hai Di Lao Hot Pot
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_TeamProject2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /HOME/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Contact/
        public ActionResult About()
        {
            return View();
        }
    }
}