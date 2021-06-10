using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer 
            { 
                Id=1, CustomerNumber="10", Name="Hasan", LastName="AYDINER", TcNo="12345678890"
            };

            CoorporateCustomer customer2 = new CoorporateCustomer
            {
                Id=2, CustomerNumber="11", CompanyName="GariBANK", TaxNo="154513436"
            };

            Customer customer3 = new IndividualCustomer
            {
                Id=3, Name="Afra", LastName="AYDINER", CustomerNumber="12", TcNo="213214214214"
            };

            Customer customer4 = new CoorporateCustomer
            {
                Id=4, CustomerNumber="13", CompanyName="Talana", TaxNo="1232131244"
            };
        }
    }
}
