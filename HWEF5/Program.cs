using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWEF5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new ContextStore())
            {
                //#region Stores
                //Console.WriteLine("Введите кол-во товаров которые хотите добавит в магазин?");
                //int countItemsInStore = int.Parse(Console.ReadLine());
                //for (int i = 0; i < countItemsInStore; i++)
                //{
                //    Console.WriteLine("Введите наименование товара?");
                //    string nameItems = Console.ReadLine();
                //    Console.WriteLine("Введите кол-во этого товара?");
                //    int countItems = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Введите цену товара?");
                //    int priceItems = int.Parse(Console.ReadLine());
                //    var store = new Store
                //    {
                //        NameItems = nameItems,
                //        CountItems = countItems,
                //        PriceItems = priceItems
                //    };
                //    context.Stores.Add(store);
                //    context.SaveChanges();
                //}
                //#endregion

                //#region AddUser
                //Console.WriteLine("Сколько пользователей добавить?");
                //int countUser = int.Parse(Console.ReadLine());
                //for (int i = 0; i < countUser; i++)
                //{
                //    Console.WriteLine("Введите логин пользователя?");
                //    string login = Console.ReadLine();
                //    var user = new User
                //    {
                //        Login = login
                //    };
                //    context.Users.Add(user);
                //    context.SaveChanges();

                //    var data = context.Stores.ToList();//Показывает наименование товаров в магазине
                //    var countStore = context.Stores.Count();

                //    Console.WriteLine("Какой товар вы хотите выбрать? (c 0!!!)");
                //    for (int j = 0; j < countStore; j++)
                //    {
                //        Console.WriteLine($"{j}" + data[j].NameItems);
                //    }
                //    int choiceNameItems = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Выберите кол-во этого товара?");
                //    int choiceCountItems = int.Parse(Console.ReadLine());

                //    var price = data[choiceNameItems].PriceItems; //Цена товара который мы выбрали из магазина

                //    var basket = new BasketUsers
                //    {
                //        NameItems = data[choiceNameItems].NameItems,
                //        CountItems = choiceCountItems,
                //        PriceItems = choiceCountItems * data[choiceNameItems].PriceItems,
                //        UserId = context.Users.ToList()[i].Id
                //    };
                //    context.Basket.Add(basket);
                //    context.SaveChanges();
                //}
                //#endregion

                #region EnterUser
                Console.WriteLine("Введите логин пользователя?");
                string enterLoginAgain = Console.ReadLine();
                
                int number2 = context.Users.Count(user => user.Login.Contains(enterLoginAgain));
                
                if (number2!=0)
                {
                    //возвращаем Id пользователя логин которого равен введенным повторно
                    var getUsersId = (from user in context.Users
                             where user.Login.Contains(enterLoginAgain)
                             select user.Id).FirstOrDefault();
                    //возвращаем всю таблицу Корзина где UserId равен Id юзера(пользователя)
                    var getBasket = from basket in context.Basket
                              where basket.UserId == getUsersId
                              select basket;
                    foreach(BasketUsers n in getBasket)
                    {
                        Console.WriteLine(n.NameItems + "  " + n.PriceItems + "  " + n.CountItems);
                        Console.ReadLine();
                    }
                }
                else
                {
                        Console.WriteLine("Noo");
                }
                               
                Console.ReadLine();
                #endregion
            }
        }
    }
}
