using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Gateways;
using System.Linq;
namespace UseCases
{
    public sealed class CaseCRUDInstance
    {
        private CaseCRUDInstance()
        {

        }

        private static ICaseCRUD instance = new CaseCRUD;
        public static CaseCRUDInstance Instance;

            {

            if (instance == null)
            {
            instance = new CaseCRUDInstance();
    }

            return instance;
       }
    }
}