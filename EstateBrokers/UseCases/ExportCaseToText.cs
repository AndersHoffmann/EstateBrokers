using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entities;
namespace UseCases
{
    class ExportCaseToText
    {
        //Recieves all the relevant information through method parameters and prints it to a text file on the users desktop. 
        public static void Write(string RealtorName, string RealtorPhone, int CaseID, DateTime CreationDate, DateTime ClosedDate , double Price, int PostalCode, string AddressLine1, string AdressLine2, int ExteriorArea, int InteriorArea, int BuildYear, int AverageAreaPrice)
        {
            var outputFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                             $"Case /{CaseID} Details.txt";

            double M2price = Price / InteriorArea;

            using (StreamWriter sw = File.CreateText(outputFilePath))
            {
                sw.WriteLine($"Printed at: {DateTime.Now}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($" Your Realtor was {RealtorName} ");
                sw.WriteLine($" Phone: {RealtorPhone} ");
                sw.WriteLine(" ");
                sw.WriteLine($"Case number {CaseID}");
                sw.WriteLine($"Current price {Price}");
                sw.WriteLine($"Adresss {AddressLine1}, {AdressLine2}");
                sw.WriteLine($"Postal code {PostalCode}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($"The listing was created on {CreationDate}");
                if (ClosedDate == null)
                {
                    sw.WriteLine(" ");
                    sw.WriteLine($"The listing was finalized on {ClosedDate}");
                }
                sw.WriteLine($"The building was built in {BuildYear}");
                sw.WriteLine(" ");
                sw.WriteLine($"The insde area of the property is {InteriorArea} m2");
                sw.WriteLine($"The outside area of the property is {ExteriorArea} m2");
                sw.WriteLine(" ");
                sw.WriteLine($"This property cost {M2price} per m2, and the average for the area is {AverageAreaPrice}");


                sw.Close();
            }
        }
    }
}
