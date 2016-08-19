/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628, Zhen Zhang 200257444
 * File Description: Create a website that allow customer to view the cuisines and order them online:
 * View food types, food items, food items details; add dood items to Cart; remove food items from cart;
 * Fill out shipping information and promotion code; submit order.
 * WebSite Name: Hai Di Lao Hot Pot
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using COMP2007_S2016_TeamProject2.Models;

namespace COMP2007_S2016_TeamProject2.Controllers
{
    public class FoodItemsController : ApiController
    {
        private RestaurantStoreContext db = new RestaurantStoreContext();

        // GET: api/FoodItems
        public IQueryable<FoodItem> GetFoodItems()
        {
            return db.FoodItems;
        }

        // GET: api/FoodItems/5
        [ResponseType(typeof(FoodItem))]
        public async Task<IHttpActionResult> GetFoodItem(int id)
        {
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return NotFound();
            }

            return Ok(foodItem);
        }

        // PUT: api/FoodItems/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFoodItem(int id, FoodItem foodItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != foodItem.FoodItemId)
            {
                return BadRequest();
            }

            db.Entry(foodItem).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FoodItems
        [ResponseType(typeof(FoodItem))]
        public async Task<IHttpActionResult> PostFoodItem(FoodItem foodItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FoodItems.Add(foodItem);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = foodItem.FoodItemId }, foodItem);
        }

        // DELETE: api/FoodItems/5
        [ResponseType(typeof(FoodItem))]
        public async Task<IHttpActionResult> DeleteFoodItem(int id)
        {
            FoodItem foodItem = await db.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return NotFound();
            }

            db.FoodItems.Remove(foodItem);
            await db.SaveChangesAsync();

            return Ok(foodItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FoodItemExists(int id)
        {
            return db.FoodItems.Count(e => e.FoodItemId == id) > 0;
        }
    }
}