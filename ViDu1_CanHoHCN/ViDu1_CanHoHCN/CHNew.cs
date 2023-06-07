using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu1_CanHoHCN
{
    internal class CHNew:CH
    {
        string HuongBC;
        public CHNew() : base()
        {
            HuongBC = "Huong Nam";
        }
        public string HuongBanCong
        {
            set { HuongBC = value; }
            get { return HuongBC; }
        }
        public void nhapCHNew()
        {
            base.nhapch();
            Console.Write("nhap huong ban cong:");
            HuongBC = Console.ReadLine();
        }
        public void xuatCHNew()
        {
            base.xuatch();
            Console.WriteLine("huong ban cong:" + HuongBC);
        }

    }
}
