using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface IRealtorCRUD
    {
        public void CreateRealtor(string name, string phoneNR);

        public Realtor ReadRealtor(int ID);

        public void UpdateRealtor(int ID, string name, string phoneNR);

        public void DeleteRealtor(int ID);
    }
}
