using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank abcBank = new Bank("ABC", "Bangalore", "011-2323441");
            abcBank.AddCustomer(101, "snehasis", "Mecheda", "9647149128", "Red");
            abcBank.AddCustomer(102, "Syam", "Mecheda", "9647149128", "Green");
            abcBank.AddCustomer(103, "John", "Mecheda", "9647149128", "Green");
            abcBank.AddCustomer(104, "Steves", "Mecheda", "9647149128", "Red");

            Agency agency = new Agency("Insta Loan", "Delhi", "1020022231");

            Console.WriteLine("enter customer id");
            int id = int.Parse(Console.ReadLine());
            int f = 0;
            foreach (var item in abcBank.custList)
            {
                if (item.custId == id)
                {
                    agency.VerifyCustomer(item);
                    f = 1;
                }
                
            }
            if (f == 0)
            {
                Console.WriteLine("Customer not found or wrong cust-id");
            }
            
        }
    }
    class Customer
    {
        public int custId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustMobileNo { get; set; }
        public string status { get; set; }

        public Customer()
        {

        }
        public Customer(int cid,string cname,string cadd,string cmob,string st)
        {
            custId = cid;
            CustName = cname;
            CustAddress = cadd;
            CustMobileNo = cmob;
            status = st;
        }
    }
    class Bank
    {
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string BankContactNo { get; set; }

        
        public List<Customer> custList=new List<Customer>();
        public Bank()
        {
           // custArray = new Customer[100];
        }
        public Bank(string bname,string badd,string bcontact)
        {
            this.BankName = bname;
            this.BankAddress = badd;
            this.BankContactNo = bcontact;
            
        }
        public void AddCustomer(int cid, string cname, string cadd, string cmob, string st)
        {
            Customer c1 = new Customer(cid, cname, cadd, cmob, st);
            custList.Add(c1);
           // Console.WriteLine("Customer added successfully!!");
        }

    }
    class Agency
    {
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyContactNo { get; set; }
        public Agency()
        {

        }
        public Agency(string aname,string add,string acon)
        {
            AgencyName = aname;
            AgencyContactNo = acon;
            AgencyAddress = add;
        }

        public void VerifyCustomer(Customer customer)
        {
            if (customer.status.Equals("Green"))
            {
                Console.WriteLine("Customer's Status: GREEN"); 
                Console.WriteLine("Customer is eligible for loan");
            }
            else if (customer.status.Equals("Red"))
            {
                Console.WriteLine("Customer's Status: RED");
                Console.WriteLine("Customer is not eligible for loan");
            }
        }
    }
}
