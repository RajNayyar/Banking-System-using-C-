using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class AccHolder
    {
        private int AccountId;
        public string name;
        public void SetAccHolderId(int id)
        {
            this.AccountId = id;
        }
        public int GetAccHolderId()
        {
            return this.AccountId;
        }
    }
}
