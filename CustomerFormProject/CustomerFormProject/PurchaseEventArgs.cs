using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFormProject
{
    public class PurchaseEventArgs : EventArgs
    {
        public Purchase Purchase { get; }

        public PurchaseEventArgs(Purchase purchase)
        {
            Purchase = purchase;
        }
    }
}
