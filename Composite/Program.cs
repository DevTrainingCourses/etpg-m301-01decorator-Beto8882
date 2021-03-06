using Composite.Orders;
using Composite.Products;
using System;

namespace Composite
{
    class Program
    {
        private readonly Random random = new Random();

        private SimpleProduct Ram4gb;
        private SimpleProduct Ram8gb;
        private SimpleProduct Disk500gb;
        private SimpleProduct Disk1tb;
        private SimpleProduct CpuAMD;
        private SimpleProduct CpuIntel;
        private SimpleProduct SmallCabinete;
        private SimpleProduct BigCabinete;
        private SimpleProduct Monitor20inch;
        private SimpleProduct Monitor30inch;
        private SimpleProduct SimpleMouse;
        private SimpleProduct GammerMouse;

        private CompositeProduct GammerPC;
        private CompositeProduct HomePC;
        private CompositeProduct Pc2x1;

        private void BuildProducts()
        {
            //Simple product construction
            Ram4gb = new SimpleProduct("RAM 4GB", 750, "KingStone");
            Ram8gb = new SimpleProduct("RAM 8GB", 1000, "KingStone");
            Disk500gb = new SimpleProduct("HDD 500GB", 1500, "ACME");
            Disk1tb = new SimpleProduct("HDD 1TB", 2000, "ACME");
            CpuAMD = new SimpleProduct("AMD phenon", 4000, "AMD");
            CpuIntel = new SimpleProduct("Intel i7", 4500, "Intel");
            SmallCabinete = new SimpleProduct("Small cabinet", 2000, "ExCom");
            BigCabinete = new SimpleProduct("Big Cabinet", 2200, "ExCom");
            Monitor20inch = new SimpleProduct("Display 20'", 1500, "HP");
            Monitor30inch = new SimpleProduct("Display 30'", 2000, "HP");
            SimpleMouse = new SimpleProduct("Simple mouse", 150, "Genius");
            GammerMouse = new SimpleProduct("Gammer mouse", 750, "Alien");

            //Gammer pc with 8gb ram,HDD 1tb, Intel i7 processor
            //large cabinet,display 30' and one gammer mouse.
            GammerPC = new CompositeProduct("Gammer PC");
            GammerPC.AddProduct(Ram8gb);
            GammerPC.AddProduct(Disk1tb);
            GammerPC.AddProduct(CpuIntel);
            GammerPC.AddProduct(BigCabinete);
            GammerPC.AddProduct(Monitor30inch);
            GammerPC.AddProduct(GammerMouse);

            //Home PC with RAM 4gb, HDD 500gb, AMD Phenon processor
            //small Cabinet, dsplay 20' and simple mouse.
            HomePC = new CompositeProduct("Home PC");
            HomePC.AddProduct(Ram4gb);//
            HomePC.AddProduct(Disk500gb);
            HomePC.AddProduct(CpuAMD);
            HomePC.AddProduct(SmallCabinete);
            HomePC.AddProduct(Monitor20inch);
            HomePC.AddProduct(SimpleMouse);

            //Package consisting of two packages, Gammer PC + Home PC
            Pc2x1 = new CompositeProduct("Pack PC Gammer + Home PC");
            //Pc2x1.AddProduct(GammerPC);
            //Pc2x1.AddProduct(HomePC);
        }

        private void OrderSimpleProducts()
        {
            SaleOrder simpleProductOrder = new SaleOrder(random.Next(), "Customer A");
            simpleProductOrder.AddProduct(Ram4gb);
            simpleProductOrder.AddProduct(Disk1tb);
            simpleProductOrder.AddProduct(SimpleMouse);
            simpleProductOrder.PrintOrder();
        }

        private void OrderGammerPC()
        {
            SaleOrder gammerOrder = new SaleOrder(1, "Customer B");
            //gammerOrder.AddProduct(GammerPC);
            gammerOrder.PrintOrder();
        }

        private void OrderHomePC()
        {
            SaleOrder homeOrder = new SaleOrder(2, "Customer C");
            //homeOrder.AddProduct(HomePC);
            homeOrder.PrintOrder();
        }

        private void OrderCombo()
        {
            SaleOrder comboOrder = new SaleOrder(3, "Paquete 2x1 en PC");
            //comboOrder.AddProduct(Pc2x1);
            comboOrder.PrintOrder();
        }

        private void OrderBig()
        {
            SaleOrder customOrder = new SaleOrder(4, "Customer D");
            //customOrder.AddProduct(HomePC);
            customOrder.AddProduct(Ram8gb);
            customOrder.AddProduct(Ram4gb);
            customOrder.AddProduct(Monitor30inch);
            customOrder.AddProduct(GammerMouse);
            customOrder.PrintOrder();
        }

        static void Main(string[] args)
        {
            Program main = new Program();
            main.BuildProducts();

            main.OrderSimpleProducts();
            main.OrderGammerPC();
            main.OrderHomePC();
            main.OrderBig();
            main.OrderCombo();            
        }
    }
}
