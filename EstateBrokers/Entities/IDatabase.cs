using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public interface IDatabase
    {
        public void Create();

        public void Read();

        public void Update();

        public void Delete();
    }
}
