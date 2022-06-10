using System.IO;
using System.Xml.Serialization;
using Reservation_App.ReservationInformations;

namespace Reservation_App
{
    public class XMLReportBuilder : ReservationReportBuilderBase
    {
        private string fileLoc;
        private string XmlBody;
        public XMLReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
            fileLoc = getDirectoryName.Remove(getDirectoryName.Length - (@"\bin\Debug").Length) + @"\Files\rapor.xml";

        }

        public override string BuildPriceInfo()
        {
            var XmlText = $@"
    <TotalPrice>13232</TotalPrice>";
            return XmlText;

        }

        public override string BuildDetailInfo()
        {
            var XmlText = $@"
    <DetailInfo>
        <TransportationInfo>{Info.DetailInfo.TransportationInfo}</TransportationInfo>
        <AccommodationInfo>{Info.DetailInfo.AccommodationInfo}</AccommodationInfo>
    </DetailInfo>";

            return XmlText;
        }

        public override string BuildGeneralInfo()
        {
            var XmlText = $@"
    <GeneralInfo>
        <WhereFrom> {Info.GeneralInfo.WhereFrom} </WhereFrom>
        <WhereTo> {Info.GeneralInfo.WhereTo} </WhereTo>
    
        <DepartureDate> 2022 - 05 - 09T00: 00:00 </DepartureDate>        
        <ReturnDate> 2022 - 05 - 12T00: 00:00 </ReturnDate>
        
        <CustomerInfo>
        
            <Name> asd </Name >
        
            <Address > aqe </Address >
        
            <PhoneNumber > 123 </PhoneNumber >
        
            <IdentificationNo > 333 </IdentificationNo >
        
            </CustomerInfo>
        
    </GeneralInfo> ";
            return XmlText;
        }

        public override void CloseFile()
        {
            XmlBody += "</ReportInfo>";
        }

        public override void WriteFile(string data)
        {
            XmlBody = "<ReportInfo>";
            XmlBody += data;
            CloseFile();

            File.WriteAllText(fileLoc, XmlBody);
        }
    }
}