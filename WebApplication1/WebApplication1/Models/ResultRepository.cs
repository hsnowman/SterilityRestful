using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public class ResultRepository : IResultRepository
    {
        ResultMethod ResultMethod = new ResultMethod();
        public int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string Description, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId)
        {
            return ResultMethod.ResTestResultSetData(pclsCache, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, Description, CollectStart, CollectEnd, TestTime, TestResult, TestPeople, ReStatus, RePeople, ReTime, TerminalIP, TerminalName, revUserId);
        }

        public int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string StartTime, string EndTime, string AnalResult)
        {
            return ResultMethod.ResIncubatorSetData(pclsCache, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, StartTime, EndTime, AnalResult);
        }
    }
}
