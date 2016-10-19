using Business;
using Domain;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class ReportsMethods
    {

        public ReportsMethods() {}

        public void generatePhoneSaleReport()
        {
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            string filename = Path.GetFullPath("C:/Users/gollo/Source/Repos/CoreVises/ReportsPDF/Report" + Guid.NewGuid().ToString().Substring(0, 7) + "_" + DateTime.Today.Date.ToString("yyyy-MM-dd") + ".pdf");
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(doc, file);
            doc.Open();

            Paragraph pTitle = new Paragraph(new Phrase("Kegg Phones", FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
            pTitle.Alignment = Element.ALIGN_CENTER;

            Paragraph pReport = new Paragraph(new Phrase("Report: Top sales of the week", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pReport.Alignment = Element.ALIGN_JUSTIFIED;

            Paragraph pDate = new Paragraph(new Phrase("Date Report: " + DateTime.Now.ToString("d"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pDate.Alignment = Element.ALIGN_JUSTIFIED;

            Image waterMaker = Image.GetInstance("C:/Users/gollo/Source/Repos/CoreVises/Reports/KeggPhonesImage.png");
            waterMaker.SetAbsolutePosition(100, 300);
            waterMaker.ScalePercent(75);

            Paragraph pSpace = new Paragraph(" ");

            PdfPTable informationTable = new PdfPTable(4);
            informationTable.WidthPercentage = 100;

            PdfPCell clPhone = new PdfPCell(new Phrase("Phone", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clPhone.BorderWidth = 0.75f;

            PdfPCell clCharacteristics = new PdfPCell(new Phrase("Characteristics phone", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clCharacteristics.BorderWidth = 0.75f;

            PdfPCell clPrice = new PdfPCell(new Phrase("Price", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clPrice.BorderWidth = 0.75f;

            PdfPCell clQuantity = new PdfPCell(new Phrase("Quantity sale", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clQuantity.BorderWidth = 0.75f;

            informationTable.AddCell(clPhone);
            informationTable.AddCell(clCharacteristics);
            informationTable.AddCell(clPrice);
            informationTable.AddCell(clQuantity);

            PhoneSaleBusiness psb = new PhoneSaleBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            Object[] values = psb.getTop5PhoneSaleWeek();
            List<Phone> phones = (List<Phone>) values[0];
            List<int> quantities = (List<int>)values[1];

            for (int i=0; i<phones.Count; i++)
            {
                Phone phoneTemp = phones[i];

                clPhone = new PdfPCell(new Phrase(phoneTemp.Brand.Name + " " + phoneTemp.Model, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clPhone.BorderWidth = 0.75f;

                string flash = "";
                if (phoneTemp.Flash.ToString() == "True")
                    flash = "Yes";
                else
                    flash = "Not";
                    string characteristics = "OS: " + phoneTemp.OS + "\n Network: " + phoneTemp.NetworkMode + "\n Internal memory: " + phoneTemp.InternalMemory +
                        "\n External memory: " + phoneTemp.ExternalMemory + "\n Camera pixels: " + phoneTemp.Pixels + "\n Camera flash: " + flash +
                        "\n Resolution screen: " + phoneTemp.Resolution;

                clCharacteristics = new PdfPCell(new Phrase(characteristics, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clCharacteristics.BorderWidth = 0.75f;

                clPrice = new PdfPCell(new Phrase("$" + phoneTemp.Price, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clPrice.BorderWidth = 0.75f;

                clQuantity = new PdfPCell(new Phrase(quantities[i] + "", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clQuantity.BorderWidth = 0.75f;

                informationTable.AddCell(clPhone);
                informationTable.AddCell(clCharacteristics);
                informationTable.AddCell(clPrice);
                informationTable.AddCell(clQuantity);
            }

            doc.Add(pTitle);
            doc.Add(pReport);
            doc.Add(pDate);
            doc.Add(waterMaker);
            doc.Add(pSpace);
            doc.Add(pSpace);
            doc.Add(informationTable);

            doc.Close();
            Process.Start(filename);
        }

        public void generateClientReport()
        {
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            string filename = Path.GetFullPath("C:/Users/gollo/Source/Repos/CoreVises/ReportsPDF/Report" + Guid.NewGuid().ToString().Substring(0, 7) + "_" + DateTime.Today.Date.ToString("yyyy-MM-dd") + ".pdf");
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(doc, file);
            doc.Open();

            Paragraph pTitle = new Paragraph(new Phrase("Kegg Phones", FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
            pTitle.Alignment = Element.ALIGN_CENTER;

            Paragraph pReport = new Paragraph(new Phrase("Report: Best clients of the month", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pReport.Alignment = Element.ALIGN_JUSTIFIED;

            Paragraph pDate = new Paragraph(new Phrase("Date Report: " + DateTime.Now.ToString("d"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL)));
            pDate.Alignment = Element.ALIGN_JUSTIFIED;

            Image waterMaker = Image.GetInstance("C:/Users/gollo/Source/Repos/CoreVises/Reports/KeggPhonesImage.png");
            waterMaker.SetAbsolutePosition(100, 300);
            waterMaker.ScalePercent(75);

            Paragraph pSpace = new Paragraph(" ");

            PdfPTable informationTable = new PdfPTable(3);
            informationTable.WidthPercentage = 100;

            PdfPCell clName = new PdfPCell(new Phrase("Client name", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clName.BorderWidth = 0.75f;

            PdfPCell clEmail = new PdfPCell(new Phrase("Email", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clEmail.BorderWidth = 0.75f;

            PdfPCell clPurcahsing = new PdfPCell(new Phrase("Tales purchases", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            clPurcahsing.BorderWidth = 0.75f;

            informationTable.AddCell(clName);
            informationTable.AddCell(clEmail);
            informationTable.AddCell(clPurcahsing);

            SaleBusiness psb = new SaleBusiness("Data Source = 163.178.107.130; Initial Catalog = KeggPhones; User Id = sqlserver; Password = saucr.12");
            Object[] values = psb.getBestClients();
            List<Client> clients = (List<Client>)values[0];
            List<int> quantities = (List<int>)values[1];

            for (int i = 0; i < clients.Count; i++)
            {
                Client clientTemp = clients[i];

                clName = new PdfPCell(new Phrase(clientTemp.Name + " " + clientTemp.LastName_1 + " " + clientTemp.LastName_2, 
                    FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clName.BorderWidth = 0.75f;

                clEmail = new PdfPCell(new Phrase(clientTemp.Email, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clEmail.BorderWidth = 0.75f;

                clPurcahsing = new PdfPCell(new Phrase("$" + quantities[i], FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL)));
                clPurcahsing.BorderWidth = 0.75f;

                informationTable.AddCell(clName);
                informationTable.AddCell(clEmail);
                informationTable.AddCell(clPurcahsing);
            }

            doc.Add(pTitle);
            doc.Add(pReport);
            doc.Add(pDate);
            doc.Add(waterMaker);
            doc.Add(pSpace);
            doc.Add(pSpace);
            doc.Add(informationTable);

            doc.Close();
            Process.Start(filename);
        }

        
    }
}
