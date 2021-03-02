using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_march_collection_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // read from procdut text file
            productManeger pM = new productManeger();
            List<products> lstProducts = pM.getAllProducts();
            displayProduct(lstProducts);
            pM.updatePrice(lstProducts);
            pM.saveUpdatePrice(lstProducts);
            Console.WriteLine("+--------------------------+");
            displayProduct(lstProducts);


        }
        static void displayProduct(List<products> lstProducts)
        {
            foreach (products item in lstProducts)
            {
                Console.WriteLine(item.id+"\t"+item.pname+"\t"+item.pprice);
            }
        }
    }
    class productManeger
    {
       
        public List<products> getAllProducts()
        {
            List<products> lstProduct = new List<products>();
            FileStream fs = new FileStream(
                @"..\..\products.txt",
                FileMode.Open,
                FileAccess.Read
                );
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                string[] cols = line.Split(',');
                products p = new products
                {
                    id = int.Parse(cols[0]),
                    pname = cols[1],
                    pprice = double.Parse(cols[2])
                };
                lstProduct.Add(p);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
           
            return lstProduct;
        }
        public void updatePrice(List<products> lstProducts)
        {
            foreach (products item in lstProducts)
            {
                item.pprice *= 1.1;
            }
        }
        public void saveUpdatePrice(List<products> lstProducts)
        {
            FileStream fs = new FileStream(
                "..\\..\\products_updated.txt", 
                FileMode.Create, 
                FileAccess.Write
                );
            StreamWriter sw = new StreamWriter(fs);
            foreach ( products ps in lstProducts)
            {
                string line = "";
                string[] cols = new string[3];
                cols[0] = ps.id.ToString();
                cols[1] = ps.pname;
                cols[2] = ps.pprice.ToString();
                line = String.Join(",",cols);//joining the list of string 

            }
            sw.Close();
            fs.Close();

        }
    }
}
