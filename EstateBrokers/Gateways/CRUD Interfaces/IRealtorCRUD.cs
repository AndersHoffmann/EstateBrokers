using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface IRealtorCRUD
    {
        public void Create(string name, string phoneNR);

        public Realtor Read(int ID);

        public void Update(int ID, string name, string phoneNR);

        public void Delete(int ID);
    }
}
