using System.IO;
using Newtonsoft.Json;

namespace Reservation_App
{
    public class HTMLReportBuilder : ReservationReportBuilderBase
    {
        private string fileLoc;
        private string html;
        private string body;
        public HTMLReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
            fileLoc = getDirectoryName.Remove(getDirectoryName.Length - (@"\bin\Debug").Length) + @"\Files\rapor.html";
        }

        public override string BuildGeneralInfo()
        { 
            var table =
            $@"<table style='margin: 20px;width: 50%'>
                <tr>
                    <th> Gidiş Tarihi </th>
                    <th> Dönüş Tarihi </th>
                    <th> Nereden </th>
                    <th> Nereye </th>
                    <th> Ad </th>
                    <th> Adres </th>
                    <th> Kimlik Numarası </th>
                    <th> Telefon Numarası </th>
                </tr>
                <tr>
                    <td>{Info.GeneralInfo.DepartureDate} </td>
                    <td>{Info.GeneralInfo.ReturnDate} </td>
                    <td>{Info.GeneralInfo.WhereFrom} </td>
                    <td>{Info.GeneralInfo.WhereTo} </td>
                    <td>{Info.GeneralInfo.CustomerInfo.Name} </td>
                    <td>{Info.GeneralInfo.CustomerInfo.Address} </td>
                    <td>{Info.GeneralInfo.CustomerInfo.IdentificationNo} </td>
                    <td>{Info.GeneralInfo.CustomerInfo.PhoneNumber} </td>
                </tr>
                
            </table>";
            return table;
            
        }
        public override string BuildDetailInfo()
        {
            var table =
                $@"<table style='margin: 20px;width: 25%'>
                <tr>
                    <th> Konaklama </th>
                    <th> Ulaşım </th>
                </tr>
                <tr>
                    <td>{Info.DetailInfo.AccommodationInfo} </td>
                    <td>{Info.DetailInfo.TransportationInfo} </td>
                </tr>
                
            </table>";
            return table;
        }

        public override string BuildPriceInfo()
        {
            var table =
                $@"<table style='margin: 20px;width: 25%'>
                <tr>
                    <th> Toplam Fiyat </th>
                </tr>
                <tr>
                    <td>{Info.TotalPrice} </td>
                </tr>
                
            </table>";
            return table;
        }
        public override void CloseFile()
        {
            body += "</body>";
            html += body + "</html>";
        }
        public override void WriteFile(string data)
        {
            html = @"<html>";

            const string head = @"
                <head>
                        <style>
                table, th, td {
                border: 1px solid black;
                border-collapse: collapse;
                }
                        </style>
                </head>";
            html += head;

            body = @"<body>";
            body += data;
            CloseFile();


            File.WriteAllText(fileLoc, html);
        }
    }
}