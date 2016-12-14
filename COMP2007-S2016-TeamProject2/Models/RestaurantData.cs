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
using System.Data.Entity;

namespace COMP2007_S2016_TeamProject2.Models
{
    public class RestaurantData : DropCreateDatabaseAlways<RestaurantStoreContext>
    {
        protected override void Seed(RestaurantStoreContext context)
        {
            var foodtypes = new List<FoodType>
            {
                new FoodType { Name = "Tones" },
                new FoodType { Name = "Strokes" },
                new FoodType { Name = "Pin Yin" },
                new FoodType { Name = "Characters" },
            };


            new List<FoodItem>
            {


                new FoodItem { Title = "First Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Level Tone", DetailedDescription="The first tone is high and level. It is important to keep one's voice even (almost monotone) across the whole syllable when pronouncing the first tone. It is represented by a straight horizontal line above a letter in pinyin (or sometimes by a number 1 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/FirstTone1.png", FoodItemLargeImageUrl = "/Assets/Images/FirstTone2.gif" },
                new FoodItem { Title = "Second Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Rising Tone", DetailedDescription="The second rises moderately. In English we sometimes associate this rise in pitch with a question. The second tone is represented by a rising diagonal line above a letter in pinyin (or sometimes by a number 2 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/SecondTone1.png", FoodItemLargeImageUrl = "/Assets/Images/SecondTone2.gif" },
                new FoodItem { Title = "Third Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Falling-Rising Tone", DetailedDescription="The third tone falls and then rises again. When pronounced clearly, its tonal dipping is very distinctive. It is represented by a curved dipping line above a letter in pinyin (or sometimes by a number 3 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/ThirdTone1.png", FoodItemLargeImageUrl = "/Assets/Images/ThirdTone2.gif" },
                new FoodItem { Title = "Fourth Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Falling Tone", DetailedDescription="The fourth tone starts out high but drops sharply to the bottom of the tonal range. English-speakers often associate this tone with an angry command. It is represented by a dropping diagonal line above a letter in pinyin (or sometimes by a number 4 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/FourthTone1.png", FoodItemLargeImageUrl = "/Assets/Images/FourthTone2.gif" },

                new FoodItem { Title = "Dian", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/dian.png", FoodItemLargeImageUrl = "/Assets/Images/li.gif"},
                new FoodItem { Title = "Heng", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/heng.png", FoodItemLargeImageUrl = "/Assets/Images/wang.gif" },
                new FoodItem { Title = "Shu", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/shu.png", FoodItemLargeImageUrl = "/Assets/Images/zhong.gif" },
                new FoodItem { Title = "Pie", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/pie.png", FoodItemLargeImageUrl = "/Assets/Images/ba.gif" },
                new FoodItem { Title = "Na", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/na.png", FoodItemLargeImageUrl = "/Assets/Images/zhang.png" },
                new FoodItem { Title = "Ti", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/ti.png", FoodItemLargeImageUrl = "/Assets/Images/bing.gif" },
                new FoodItem { Title = "Heng Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/henggou.png", FoodItemLargeImageUrl = "/Assets/Images/mai.png" },
                new FoodItem { Title = "Shu Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/shugou.png", FoodItemLargeImageUrl = "/Assets/Images/xiao.png" },
                new FoodItem { Title = "Xie Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), ShortDescription = "", DetailedDescription="", FoodItemThumbnailImageUrl = "/Assets/Images/xiegou.png", FoodItemLargeImageUrl = "/Assets/Images/wo.jpeg" },






                new FoodItem { Title = "Kung Pao Chicken", FoodType = foodtypes.Single(g => g.Name == "Pin Yin"), Price = 10.25M, ShortDescription = "Salty & Spicy", DetailedDescription="Quick-fried with cashew nuts, chili peppers and onions. Our hot favorite", FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },
                new FoodItem { Title = "Moo shu Beef", FoodType = foodtypes.Single(g => g.Name == "Pin Yin"), Price = 9.95M, ShortDescription = "Salty & Spicy", DetailedDescription="A Chinese classic served with julienne vegetables, hoisin sauce and thin pancakes", FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },
                new FoodItem { Title = "Salt & spicy Ribs", FoodType = foodtypes.Single(g => g.Name == "Pin Yin"), Price = 8.85M, ShortDescription = "Salty & Spicy", DetailedDescription="Deep fried boneless spare ribs seasoned with spicy salt, chili & herbs", FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },

                new FoodItem { Title = "Jumbo Shrimps", FoodType = foodtypes.Single(g => g.Name == "Characters"), Price = 15.25M, ShortDescription = "Spicy", DetailedDescription="Large shrimps served on a skillet with vegetables. Topped with our spicy garlic sauce", FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },
                new FoodItem { Title = "Shrimp with Lobster Sauce", FoodType = foodtypes.Single(g => g.Name == "Characters"), Price = 12.50M, ShortDescription = "Salty", DetailedDescription="Garlic white wine sauce with Chinese black beans, mushroom, onion and egg",FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },
                new FoodItem { Title = "Sweet Chilli Shrimp", FoodType = foodtypes.Single(g => g.Name == "Characters"), Price = 13.50M, ShortDescription = "Sweet & Spicy", DetailedDescription="Hand-battered shrimp prepared to order and tossed in a spicy chilli sauce",FoodItemThumbnailImageUrl = "/Assets/Images/", FoodItemLargeImageUrl = "/Assets/Images/" },


            }.ForEach(a => context.FoodItems.Add(a));
        }
    }
}
