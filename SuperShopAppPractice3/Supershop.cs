using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Supershop
    {
        public string name { set; get; }
        public string address { set; get; }
        public List<Product>productlist=new List<Product>();

        public Supershop(string name, string address) 
        {
            this.name = name;
            this.address = address;
        }
        public void  addproduct(Product productobj)
        {
            foreach (Product p in productlist )
            {
                if (p.id == productobj.id)
                {
                    p.quantity = p.quantity + productobj.quantity;
                    return;
                }
                else
                {
                    break;
                }
            }
            productlist.Add((productobj));

        }

        public string getinfo()
        {
            string msg="Shop Name= "+this.name+"Address: "+this.address+Environment.NewLine;
            foreach (Product p in productlist)
            {
                msg = msg + "product id=" + p.id + "quantity" + p.quantity + Environment.NewLine;
            }

            return msg;
        }

    }
   
}
