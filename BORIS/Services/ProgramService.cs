using BORIS.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace BORIS.Services
{
    public class ProgramService : IProgramService
    {
        private List<ProgramInfo> _base =
        [
            new ProgramInfo("Umschulung", new Dictionary<string, string> {
                {"Dauer", "2 Jahre"},
                {"Abschluss", "IHK-Berufsabschluss" },
                {"Interessenten", "Fachkräfte aus anderen Bereichen, die in die IT wechseln möchten, Studienabbrecher, " +
                    "Quereinsteiger und Fachkräfte aus dem Ausland, die einen in Deutschland anerkannten Abschluss erwerben möchten."}
            }),

            new ProgramInfo("Weiterbildung", new Dictionary<string, string> {
                {"Dauer", "2 Jahre"},
                {"Abschluss", "IHK-Berufsabschluss" },
            }),
        ];

        private List<ProgramInfo> _umschulungen = 
        [
            new ProgramInfo("FIAE", new Dictionary<string, string> {
                {"Dauer", "2 Jahre"},
                {"Abschluss", "Fachinformatiker*in Anwendungsentwicklung" } }),
            
            new ProgramInfo("FISI", new Dictionary<string, string> {
                {"Dauer", "2 Jahre"},
                {"Abschluss", "Fachinformatiker*in Systemintegration" } })
        ];


        public List<ProgramInfo> GetDefaults() => _base;

        public List<ProgramInfo> GetUmschulungen() => _umschulungen;


        // TODO: implement dynamic loading and filtering of courses
        public List<ProgramInfo> GetProgramList(string programKeys)
        {
            if (programKeys == "Umschulungen")
                return GetUmschulungen();
            else
                return GetDefaults();
        }

        public ProgramInfo GetProgramDescription(string programKey)
        {

        }
    }
}
