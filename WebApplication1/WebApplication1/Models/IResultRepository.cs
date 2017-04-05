using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public interface IResultRepository
    {
        int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string Description, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId);

        int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string StartTime, string EndTime, string AnalResult);
    }
}
