using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectFinal1.Models;
namespace ProjectFinal1.Models
{
    public class Cart
    {
        public String Customer { get; set; }
        public String Account { get; set; }
        public DateTime DATE_OR { get; set; }
        public DateTime DATE_DEL { get; set; }
        public String HOME_OR { get; set; }
        public SortedList<string, ORDER_DETAILS> Sel_product{ get; set; }
        /// <summary>
        /// defaul contructor
        /// </summary>
        public Cart()
        {
            this.Customer = "";this.Account = ""; this.DATE_OR = DateTime.Now; this.DATE_DEL = DateTime.Now.AddDays(2);
            this.HOME_OR = "";this.Sel_product = new SortedList<string, ORDER_DETAILS>();
        }
        public bool IsEmpty()
        {
            return (Sel_product.Count == 0);
        }
        /// <summary>
        /// method add product to cart
        /// </summary>
        /// <param name="ID_PR"></param>
        public void addItem(string ID_PR)
        {
            
            if (Sel_product.Keys.Contains(ID_PR))
            {
                // get product in cart
                ORDER_DETAILS x = Sel_product.Values[Sel_product.IndexOfKey(ID_PR)];
                x.AMOUNT++;
                // return cart
                updateOneItem( x);

            }
            else 
            {

                // new Object seselected product
                ORDER_DETAILS y =new ORDER_DETAILS();
                //update object
                y.ID_PR= ID_PR;
                y.AMOUNT = 1;
                PRODUCT z= Global.GetPRODUCTByID(y.ID_PR);
                y.PRICE = z.PRICE;
                y.SALE= z.SALE;
                //
                Sel_product.Add(ID_PR, y);
            }
        }
        public void updateOneItem(ORDER_DETAILS x)
        {
            this.Sel_product.Remove(x.ID_PR);
            this.Sel_product.Add(x.ID_PR, x);
        }
        /// <summary>
        /// delete product in cart
        /// </summary>
        /// <param name="ID_PR"></param>
        public void deleteTtem(string ID_PR)
        {
            if(Sel_product.Keys.Contains(ID_PR))
            {
                Sel_product.Remove(ID_PR);
            }    
        }
        /// <summary>
        /// reduce the quantity or remove the selected product
        /// </summary>
        /// <param name="ID_PR"></param>

        public void decrease(String ID_PR)
        {
            if(Sel_product.Keys.Contains(ID_PR))
            {
                ORDER_DETAILS x = Sel_product.Values[Sel_product.IndexOfKey(ID_PR)];
                if(x.AMOUNT>1)
                {     
                    x.AMOUNT --;
                        updateOneItem(x);
                    }
                else
                {
                    deleteTtem(ID_PR);
                }
            }    
        }

        public int moneyOfOneProduct(ORDER_DETAILS x)
        {
            return (int)(x.PRICE*x.AMOUNT-(x.PRICE*x.AMOUNT*x.SALE));
        }

        /// <summary>
        /// total cat
        /// </summary>
        /// <returns></returns>
        public int totalOfCart()
        {
            int total = 0;
            foreach (ORDER_DETAILS i in Sel_product.Values)
                total += moneyOfOneProduct(i);
            return total;
        }
    }
}