using System;

namespace BDDDemo
{
    public class ProductService
    {
       public int  ShowPrice(User user)
        {
            var price = 0;
            if (user.LoggedIn == true && user.Name=="Supreet")
            {
               price= 120;
               
            }
            return price;

        }
    }
}
