using System.IO;
using System.Windows.Forms;

namespace Reservation_App
{
    public abstract class ReservationReportBuilderBase
    {
        protected ReportInfo Info;
        protected string getDirectoryName;
        public ReservationReportBuilderBase(ReportInfo reportInfo)
        {
            Info = reportInfo;
            getDirectoryName = Path.GetDirectoryName(Application.ExecutablePath);

        }

        public string BuildOutput()
        {
            string output = BuildGeneralInfo();
            output += BuildDetailInfo();
            output += BuildPriceInfo();
            return output;
        }

        public abstract string BuildPriceInfo();

        public abstract string BuildDetailInfo();

        public abstract string BuildGeneralInfo();
        public abstract void CloseFile();
        public abstract void WriteFile(string data);
    }
}