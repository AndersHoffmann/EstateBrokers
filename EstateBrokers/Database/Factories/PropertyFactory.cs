using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    static class PropertyFactory
    {
        public static IProperty CreateProperty(IProperty Property = null)
        {

            if (Property is Database.Property) 
            {

            }
            if (Property is Entities.Property)
            {

            }
            if (Property is null)
            {

            }

        }

    }
}
