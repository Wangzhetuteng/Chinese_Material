/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628
 * File Description: Create a website that allow customer to view the cuisines and order them online:
 * View food types, food items, food items details; add items to Cart; remove food items from cart;
 * Fill out shipping information and promotion code; submit order.
 * WebSite Name: Learn Mandarin Online
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
                new FoodType { Name = "Book Sessions" },
            };


            new List<FoodItem>
            {


                new FoodItem { Title = "First Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Level Tone", DetailedDescription="The first tone is high and level. It is important to keep one's voice even (almost monotone) across the whole syllable when pronouncing the first tone. It is represented by a straight horizontal line above a letter in pinyin (or sometimes by a number 1 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/FirstTone1.png", FoodItemLargeImageUrl = "/Assets/Images/FirstTone2.gif" },
                new FoodItem { Title = "Second Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Rising Tone", DetailedDescription="The second rises moderately. In English we sometimes associate this rise in pitch with a question. The second tone is represented by a rising diagonal line above a letter in pinyin (or sometimes by a number 2 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/SecondTone1.png", FoodItemLargeImageUrl = "/Assets/Images/SecondTone2.gif" },
                new FoodItem { Title = "Third Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Falling-Rising Tone", DetailedDescription="The third tone falls and then rises again. When pronounced clearly, its tonal dipping is very distinctive. It is represented by a curved dipping line above a letter in pinyin (or sometimes by a number 3 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/ThirdTone1.png", FoodItemLargeImageUrl = "/Assets/Images/ThirdTone2.gif" },
                new FoodItem { Title = "Fourth Tone", FoodType = foodtypes.Single(g => g.Name == "Tones"), ShortDescription = "Falling Tone", DetailedDescription="The fourth tone starts out high but drops sharply to the bottom of the tonal range. English-speakers often associate this tone with an angry command. It is represented by a dropping diagonal line above a letter in pinyin (or sometimes by a number 4 written after the syllable).", FoodItemThumbnailImageUrl = "/Assets/Images/FourthTone1.png", FoodItemLargeImageUrl = "/Assets/Images/FourthTone2.gif" },

                new FoodItem { Title = "Dian", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to stand / to set up / to establish / to lay down / to draw up / at once / immediately", FoodItemThumbnailImageUrl = "/Assets/Images/dian.png", FoodItemLargeImageUrl = "/Assets/Images/li.gif"},
                new FoodItem { Title = "Heng", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="surname Wang; king or monarch / best or strongest of its type / grand / great; to rule / to reign over", FoodItemThumbnailImageUrl = "/Assets/Images/heng.png", FoodItemLargeImageUrl = "/Assets/Images/wang.gif" },
                new FoodItem { Title = "Shu", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="within / among / in / middle / center / while (doing sth) / during / (dialect) OK / all right; to hit (the mark) / to be hit by / to suffer / to win (a prize, a lottery); five directions, namely: east 东, south 南, west 西, north 北 and middle 中", FoodItemThumbnailImageUrl = "/Assets/Images/shu.png", FoodItemLargeImageUrl = "/Assets/Images/zhong.gif" },
                new FoodItem { Title = "Pie", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="eight / 8", FoodItemThumbnailImageUrl = "/Assets/Images/pie.png", FoodItemLargeImageUrl = "/Assets/Images/ba.gif" },
                new FoodItem { Title = "Na", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="(once) again / also / both... and... / and yet / (used for emphasis) anyway", FoodItemThumbnailImageUrl = "/Assets/Images/na.png", FoodItemLargeImageUrl = "/Assets/Images/you.gif" },
                new FoodItem { Title = "Ti", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="ice", FoodItemThumbnailImageUrl = "/Assets/Images/ti.png", FoodItemLargeImageUrl = "/Assets/Images/bing.gif" },
                new FoodItem { Title = "Heng Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="leather / skin / fur", FoodItemThumbnailImageUrl = "/Assets/Images/henggou.png", FoodItemLargeImageUrl = "/Assets/Images/pi.gif" },
                new FoodItem { Title = "Shu Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="water / river / liquid / beverage / additional charges or income / (of clothes) classifier for number of washes", FoodItemThumbnailImageUrl = "/Assets/Images/shugou.png", FoodItemLargeImageUrl = "/Assets/Images/shui.gif" },
                new FoodItem { Title = "Xie Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="I / me / my", FoodItemThumbnailImageUrl = "/Assets/Images/xiegou.png", FoodItemLargeImageUrl = "/Assets/Images/wo.gif" },
                new FoodItem { Title = "Heng Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="country / nation / state / national", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhe.png", FoodItemLargeImageUrl = "/Assets/Images/guo.gif" },
                new FoodItem { Title = "Shu Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="mountain / hill / anything that resembles a mountain / bundled straw in which silkworms spin cocoons / gable", FoodItemThumbnailImageUrl = "/Assets/Images/shuzhe.png", FoodItemLargeImageUrl = "/Assets/Images/shan.gif" },
                new FoodItem { Title = "Heng Pie", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="friend", FoodItemThumbnailImageUrl = "/Assets/Images/hengpie.png", FoodItemLargeImageUrl = "/Assets/Images/you.gif" },
                new FoodItem { Title = "Pie Dian", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="good / well / proper / good to / easy to / very / so / (suffix indicating completion or readiness) / (of two people) close / on intimate terms / to be fond of / to have a tendency to / to be prone to", FoodItemThumbnailImageUrl = "/Assets/Images/piedian.png", FoodItemLargeImageUrl = "/Assets/Images/hao.gif" },
                new FoodItem { Title = "Heng Zhe Zhe Zhe Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to be / thus / so / therefore / then / only / thereupon", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhezhezhegou.png", FoodItemLargeImageUrl = "/Assets/Images/nai.gif" },
                new FoodItem { Title = "Shu Wan Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to be / thus / so / therefore / then / only / thereupon", FoodItemThumbnailImageUrl = "/Assets/Images/shuwangou.png", FoodItemLargeImageUrl = "/Assets/Images/ji.gif" },
                new FoodItem { Title = "Shu Zhe Wan Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="a bow (weapon) / to bend / to arch (one's back etc)", FoodItemThumbnailImageUrl = "/Assets/Images/shuzhewangou.png", FoodItemLargeImageUrl = "/Assets/Images/gong.gif" },
                new FoodItem { Title = "Wan Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="dog", FoodItemThumbnailImageUrl = "/Assets/Images/wangou.png", FoodItemLargeImageUrl = "/Assets/Images/gou.gif" },
                new FoodItem { Title = "Heng Zhe Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="surname Xi / to practice / to study / habit", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhegou.png", FoodItemLargeImageUrl = "/Assets/Images/xi.gif" },
                new FoodItem { Title = "Heng Zhe Ti", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to recognize / to know / to admit", FoodItemThumbnailImageUrl = "/Assets/Images/hengzheti.png", FoodItemLargeImageUrl = "/Assets/Images/ren.gif" },
                new FoodItem { Title = "Heng Zhe Zhe Pie", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="and / to reach / up to / in time for", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhezhepie.png", FoodItemLargeImageUrl = "/Assets/Images/ji2.gif" },
                new FoodItem { Title = "Heng Pie Wan Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="ministry; department; section; part; division; troops; board; measure word for works of literature, films, machines etc", FoodItemThumbnailImageUrl = "/Assets/Images/hengpiewangou.png", FoodItemLargeImageUrl = "/Assets/Images/bu.gif" },
                new FoodItem { Title = "Pie Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="public / collectively owned / common / international (e.g. high seas, metric system, calendar) / make public / fair / just / Duke, highest of five orders of nobility / honorable (gentlemen) / father-in-law / male (animal)", FoodItemThumbnailImageUrl = "/Assets/Images/piezhe.png", FoodItemLargeImageUrl = "/Assets/Images/gong1.gif" },
                new FoodItem { Title = "Shu Ti", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="(adverb of degree) / quite / very / awfully", FoodItemThumbnailImageUrl = "/Assets/Images/shuti.png", FoodItemLargeImageUrl = "/Assets/Images/hen.gif" },
                new FoodItem { Title = "Shu Zhe Pie", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="for a particular person, occasion, purpose / focused on one thing / special / expert / particular (to sth) / concentrated / specialized", FoodItemThumbnailImageUrl = "/Assets/Images/shuzhepie.png", FoodItemLargeImageUrl = "/Assets/Images/zhuan.png" },
                new FoodItem { Title = "Shu Zhe Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="ancient cooking cauldron with two looped handles and three or four legs / pot (dialect) / to enter upon a period of (classical) / Kangxi radical 206 / one of the 64 hexagrams of the Book of Changes", FoodItemThumbnailImageUrl = "/Assets/Images/shuzhezhe.png", FoodItemLargeImageUrl = "/Assets/Images/ding.gif" },
                new FoodItem { Title = "Heng Zhe Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="depressed / sunken / indented / concave", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhezhe.png", FoodItemLargeImageUrl = "/Assets/Images/ao.png" },
                new FoodItem { Title = "Heng Zhe Zhe Zhe", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to stick out / protruding / convex", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhezhezhe.png", FoodItemLargeImageUrl = "/Assets/Images/tu.jpg" },
                new FoodItem { Title = "Heng Zhe Wan", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="along / to follow (a line, tradition etc) / to carry on / to trim (a border with braid, tape etc) / border / edge", FoodItemThumbnailImageUrl = "/Assets/Images/hengzhewan.png", FoodItemLargeImageUrl = "/Assets/Images/yan.png" },
                new FoodItem { Title = "Bian Xie Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="	heart / mind / intention / center / core", FoodItemThumbnailImageUrl = "/Assets/Images/bianxiegou.png", FoodItemLargeImageUrl = "/Assets/Images/xin.gif" },
                new FoodItem { Title = "Heng Xie Gou", FoodType = foodtypes.Single(g => g.Name == "Strokes"), DetailedDescription="to fly", FoodItemThumbnailImageUrl = "/Assets/Images/hengxiegou.png", FoodItemLargeImageUrl = "/Assets/Images/fei.gif" },

                new FoodItem { Title = "Monday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Monday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Tuesday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Tuesday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Wednesday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Wednesday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Thursday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Thursday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Friday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Friday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Saturday Morning 9:00 - 10:00 AM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="9:00 - 10:00 AM"},
                new FoodItem { Title = "Saturday Morning 10:00 - 11:00 AM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="10:00 - 11:00 AM"},
                new FoodItem { Title = "Saturday Afternoon 3:00 - 4:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="3:00 - 4:00 PM"},
                new FoodItem { Title = "Saturday Afternoon 4:00 - 5:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="4:00 - 5:00 PM"},
                new FoodItem { Title = "Saturday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Saturday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
                new FoodItem { Title = "Sunday Morning 9:00 - 10:00 AM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="9:00 - 10:00 AM"},
                new FoodItem { Title = "Sunday Morning 10:00 - 11:00 AM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="10:00 - 11:00 AM"},
                new FoodItem { Title = "Sunday Afternoon 3:00 - 4:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="3:00 - 4:00 PM"},
                new FoodItem { Title = "Sunday Afternoon 4:00 - 5:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="4:00 - 5:00 PM"},
                new FoodItem { Title = "Sunday Evening 7:00 - 8:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="7:00 - 8:00 PM"},
                new FoodItem { Title = "Sunday Evening 8:00 - 9:00 PM", FoodType = foodtypes.Single(g => g.Name == "Book Sessions"), Price = 30M, DetailedDescription="8:00 - 9:00 PM"},
            }.ForEach(a => context.FoodItems.Add(a));
        }
    }
}
