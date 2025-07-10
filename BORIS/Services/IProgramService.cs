using BORIS.Models;

namespace BORIS.Services
{
    public interface IProgramService
    {
        abstract List<ProgramInfo> GetDefaults();
        abstract List<ProgramInfo> GetUmschulungen();
        abstract List<ProgramInfo> GetProgramList(string programKeys);
        abstract ProgramInfo GetProgramDescription(string programKey);
    }
}