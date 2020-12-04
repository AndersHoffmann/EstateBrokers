using System;
using System.IO;

namespace UseCases.PrintEntries
{
    public class PrintEntry : IPrintEntriesInput
    {
        public IPrintEntriesOutput PrintEntriesOutput { get; set; }

        public PrintEntry(IPrintEntriesOutput printEntriesOutput)
        {
            PrintEntriesOutput = printEntriesOutput;
        }

        //Recieves all the relevant information through method parameters and prints it to a text file on the users desktop. 
        public void WriteToFile(PrintEntriesRequestModel request)
        {
            PrintEntriesResponseModel response = new PrintEntriesResponseModel();
            var outputFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                             $"Case /{request.CaseID} Details.txt";

            double M2price = request.Price / request.InteriorArea;

            using (StreamWriter sw = File.CreateText(outputFilePath))
            {
                sw.WriteLine($"Printed at: {DateTime.Now}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($" Your Realtor was {request.RealtorName} ");
                sw.WriteLine($" Phone: {request.RealtorPhone} ");
                sw.WriteLine(" ");
                sw.WriteLine($"Case number {request.CaseID}");
                sw.WriteLine($"Current price {request.Price}");
                sw.WriteLine($"Adresss {request.AddressLine1}, {request.AddressLine2}");
                sw.WriteLine($"Postal code {request.PostalCode}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($"The listing was created on {request.CreationDate}");
                if (request.ClosedDate != null)
                {
                    sw.WriteLine(" ");
                    sw.WriteLine($"The listing was finalized on {request.ClosedDate}");
                }
                sw.WriteLine($"The building was built in {request.BuildYear}");
                sw.WriteLine(" ");
                sw.WriteLine($"The insde area of the property is {request.InteriorArea} m2");
                sw.WriteLine($"The outside area of the property is {request.ExteriorArea} m2");
                sw.WriteLine(" ");
                sw.WriteLine($"This property cost {M2price} per m2, and the average for the area is {request.AverageAreaPrice}");

                response.success = true;
                sw.Close();
            }
            PrintEntriesOutput.PrintSuccess(response);
        }
    }
}
