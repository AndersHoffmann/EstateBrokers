using System;
using System.IO;
using System.Text;
using Database;
using Entities;
using Gateways;

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
        public void WriteToFile(PrintEntriesRequestModel Request)
        {
            var request = GetDataForPrint(Request);
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
        public PrintObject GetDataForPrint(PrintEntriesRequestModel request)
        {
            IAddressCRUD addressCRUD = new AddressCRUD();
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IRealtorCRUD realtorCRUD = new RealtorCRUD();
            PrintObject printObject = new PrintObject();
            CalculateAverageWithIntegerInput calc = new CalculateAverageWithIntegerInput();
            Entities.Case workingCase = caseCRUD.ReadCase(request.CaseID);

            Entities.Realtor workingRealtor = realtorCRUD.ReadRealtor(workingCase.Realtor.RealtorID);

            Entities.Property workingProperty = propertyCRUD.ReadProperty(request.CaseID);

            Entities.Address workingAddress = addressCRUD.ReadAddress(workingProperty.PostalCode, workingProperty.AddressLine1);

            printObject.RealtorName = workingRealtor.Name;
            printObject.RealtorPhone = workingRealtor.PhoneNR;

            printObject.CaseID = workingCase.CaseID;
            printObject.CreationDate = workingCase.CreationDate;
            printObject.ClosedDate = (DateTime)workingCase.ClosedDate;
            printObject.Price = workingCase.Price;

            printObject.PostalCode = workingProperty.PostalCode;
            printObject.AddressLine1 = workingProperty.AddressLine1;
            printObject.EstimatedPrice = workingProperty.EstimatedPrice;


            printObject.AddressLine2 = workingAddress.AddressLine2;
            printObject.ExteriorArea = workingAddress.ExteriorArea;
            printObject.InteriorArea = workingAddress.InteriorArea;
            printObject.BuildYear = workingAddress.BuildYear;

            printObject.AverageAreaPrice = calc.Calculate(workingProperty.PostalCode);

            return printObject;
        }
    }

}