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
        IPrintEntriesOutput _printEntriesOutput;
        IAddressCRUD _addressCRUD;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;
        IRealtorCRUD _realtorCRUD;
        

        public PrintEntry(IPrintEntriesOutput printEntriesOutput, IAddressCRUD addressCRUD, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IRealtorCRUD realtorCRUD)
        {
            _printEntriesOutput = printEntriesOutput;
            _addressCRUD = addressCRUD;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _realtorCRUD = realtorCRUD;

        }

        //Recieves all the relevant information through method parameters and prints it to a text file on the users desktop. 
        public void WriteToFile(PrintEntriesRequestModel Request)
        {
            PrintEntriesResponseModel response = new PrintEntriesResponseModel();
            PrintObject po = GetDataForPrint(Request.CaseID);
            var outputFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                             $"/Case_{po.CaseID}_Details.txt";
            

            double M2price = po.Price / po.InteriorArea;

            using (StreamWriter sw = File.CreateText(outputFilePath))
            {
                sw.WriteLine($"Printed at: {DateTime.Now}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($" Your Realtor was {po.RealtorName} ");
                sw.WriteLine($" Phone: {po.RealtorPhone} ");
                sw.WriteLine(" ");
                sw.WriteLine($"Case number {po.CaseID}");
                sw.WriteLine($"Current price {po.Price}");
                sw.WriteLine($"Adresss {po.AddressLine1}, {po.AddressLine2}");
                sw.WriteLine($"Postal code {po.PostalCode}");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine($"The listing was created on {po.CreationDate}");
                if (po.ClosedDate != null)
                {
                    sw.WriteLine(" ");
                    sw.WriteLine($"The listing was finalized on {po.ClosedDate}");
                }
                sw.WriteLine($"The building was built in {po.BuildYear}");
                sw.WriteLine(" ");
                sw.WriteLine($"The insde area of the property is {po.InteriorArea} m2");
                sw.WriteLine($"The outside area of the property is {po.ExteriorArea} m2");
                sw.WriteLine(" ");
                sw.WriteLine($"This property cost {M2price} per m2, and the average for the area is {po.AverageAreaPrice}");

                response.success = true;
                sw.Close();
            }
            _printEntriesOutput.PrintSuccess(response);
        }
        public PrintObject GetDataForPrint(int caseId)
        {
            PrintObject printObject = new PrintObject();
            CalculateAverageWithIntegerInput calc = new CalculateAverageWithIntegerInput(_caseCRUD);

            Entities.Case workingCase = _caseCRUD.ReadCase(caseId);

            Entities.Realtor workingRealtor = _realtorCRUD.ReadRealtor(_caseCRUD.ReturnRealtorIDOnCase(caseId));

            Entities.Property workingProperty = _propertyCRUD.ReadProperty(caseId);

            Entities.Address workingAddress = _addressCRUD.ReadAddress(workingProperty.PostalCode, workingProperty.AddressLine1);

            printObject.RealtorName = workingRealtor.Name;
            printObject.RealtorPhone = workingRealtor.PhoneNR;

            printObject.CaseID = workingCase.CaseID;
            printObject.CreationDate = workingCase.CreationDate;
            if (workingCase.ClosedDate != null)
            {
                printObject.ClosedDate = (DateTime)workingCase.ClosedDate;
            }
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