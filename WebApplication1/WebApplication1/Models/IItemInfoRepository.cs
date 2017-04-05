using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public interface IItemInfoRepository
    {
        int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId);

        int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId);

        int ItemReagentSetData(DataConnection pclsCache, string ReagentId, DateTime ProductDay, string ReagentType, DateTime ExpiryDay, string ReagentName, string ReagentTest, string SaveCondition, string Description, string TerminalIP, string TerminalName, string revUserId);

        int ItemSampleSetData(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string SamplingWay, string SamplingTool, string SamAmount, string DevideWay, string SamContain, string Warning, string SamSave, string TerminalIP, string TerminalName, string revUserId);

        int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, int Temperature, string TerminalIP, string TerminalName, string revUserId);

        int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId);
    }
}
