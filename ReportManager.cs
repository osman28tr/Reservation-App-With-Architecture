namespace Reservation_App
{
    public class ReportManager
    {
        private readonly ReservationReportBuilderBase _builder;

        public ReportManager(ReservationReportBuilderBase builder)
        {
            _builder = builder;
        }

        public void FileWriter(string data)
        {
            _builder.WriteFile(data);
        }
        public string BuildGDT()
        {
            var output = _builder.BuildOutput();
            return output;
        }
        public string BuildGTD()
        {
            var output = _builder.BuildGeneralInfo();
            output += _builder.BuildPriceInfo();
            output += _builder.BuildDetailInfo();
            return output;
        }
        public string BuildDGT()
        {
            var output = _builder.BuildDetailInfo();
            output += _builder.BuildGeneralInfo();
            output += _builder.BuildPriceInfo();
            return output;
        }
        public string BuildDTG()
        {
            var output = _builder.BuildDetailInfo();
            output += _builder.BuildPriceInfo();
            output += _builder.BuildGeneralInfo();
            return output;
        }
        public string BuildTGD()
        {
            var output = _builder.BuildPriceInfo();
            output += _builder.BuildGeneralInfo();
            output += _builder.BuildDetailInfo();
            return output;
        }

        public string BuildTDG()
        {
            var output = _builder.BuildPriceInfo();
            output += _builder.BuildDetailInfo();
            output += _builder.BuildGeneralInfo();
            return output;
        }
    }
}