using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Reservation_App
{
    public class JSONReportBuilder : ReservationReportBuilderBase
    {
        private string fileLoc;
        private string JsonBody;

        public JSONReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
            fileLoc = getDirectoryName.Remove(getDirectoryName.Length - (@"\bin\Debug").Length) + @"\Files\rapor.json";

        }

        public override string BuildPriceInfo()
        {               
            var jsonText = "\"PriceInfo\" : {" +
                           $"\"TotalPrice\" : {Info.TotalPrice}" + "},";

            return jsonText;
        }

        public override string BuildDetailInfo()
        {   
            var jsonText = "\"DetailInfo\" : {" +
                $"\"Konaklama\" : \"{Info.DetailInfo.AccommodationInfo}\"," +
                                $"\"Ulaşım\" : \"{Info.DetailInfo.TransportationInfo}\"" + "},";
            return jsonText;
        }

        public override string BuildGeneralInfo()
        {
            var jsonText = "\"GeneralInfo\" : {" +
                           $"\"Nereden\" : \"{Info.GeneralInfo.WhereFrom}\"," +
                           $"\"Nereye\" :\"{Info.GeneralInfo.WhereTo}\"," +
                           $"\"Gidiş Tarihi\" : \"{Info.GeneralInfo.DepartureDate}\"," +
                           $"\"Dönüş Tarihi\" : \"{Info.GeneralInfo.ReturnDate}\"," +
                           $"\"Müşteri\" :{JsonConvert.SerializeObject(Info.GeneralInfo.CustomerInfo)}" + "},";

            return jsonText;
        }

        public override void CloseFile()
        {
            JsonBody += "}}";

        }

        public override void WriteFile(string data)
        {
            JsonBody = "{\"Report Info\" :{";
            JsonBody += data;
            CloseFile();

            var jsonInfo = JObject.Parse(JsonBody);
            File.WriteAllText(fileLoc, jsonInfo.ToString()); 
        }
    }
}