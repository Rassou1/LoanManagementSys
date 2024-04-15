using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Managers
{
    internal class LoanManager
    {
        private List<LoanItem> loanItems = new();
        ProductManager pm;
        MemberManager mm;
        
       public LoanManager(ProductManager pm, MemberManager mm)
        {
            this.pm = pm;
            this.mm = mm;
        }
        Random rnd = new Random();

        public LoanItem Get(int index)
        {
            if (CheckIndex(index))
                return loanItems[index];
            else
                return null;
        }


        public void AddItem()
        {   
            LoanItem temp = new LoanItem(pm.products[rnd.Next(100,115)], mm.members[rnd.Next(10,20)]);
            loanItems.Add(temp);
        }
       

        public void Remove()
        {
            int tempindex = rnd.Next(0, 15);
            if (CheckIndex(tempindex))
            {
                loanItems.RemoveAt(tempindex);
            }
        }
        

        public int Count
        {
            get { return loanItems.Count; }
        }


        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < loanItems.Count);
        }


        public bool noLoanItemsAvailable()
        {
            return (loanItems == null) || (loanItems.Count <= 0);
        }

        public String[] getLoanItemInfo()
        {
            if(noLoanItemsAvailable())
            {
                return new String[] { "Products on loan", "" };
            }

            String[] loanItemInfo = new String[(loanItems.Count + 1)];

            loanItemInfo[0] = $"Products on loan: {loanItems.Count}";
            int j = 1;
            
            for (int i = 0; i>loanItems.Count; i++)
            {
                loanItemInfo[j++] = loanItems[i].Product.name;
            }


            return loanItemInfo;
        }
    }
}
