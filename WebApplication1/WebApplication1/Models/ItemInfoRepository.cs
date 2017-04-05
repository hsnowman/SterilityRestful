using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public class ItemInfoRepository : IItemInfoRepository
    {
        ItemInfoMethod ItemInfoMethod = new ItemInfoMethod();
        public int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemIsolatorSetData(pclsCache, IsolatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId);
        }

        public int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemIncubatorSetData(pclsCache, IncubatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId);
        }

        public int ItemReagentSetData(DataConnection pclsCache, string ReagentId, DateTime ProductDay, string ReagentType, DateTime ExpiryDay, string ReagentName, string ReagentTest, string SaveCondition, string Description, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemReagentSetData(pclsCache, ReagentId, ProductDay, ReagentType, ExpiryDay, ReagentName, ReagentTest, SaveCondition, Description, TerminalIP, TerminalName, revUserId);
        }

        public int ItemSampleSetData(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string SamplingWay, string SamplingTool, string SamAmount, string DevideWay, string SamContain, string Warning, string SamSave, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemSampleSetData(pclsCache, ObjectNo, ObjCompany, ObjIncuSeq, ObjectName, ObjectType, SamplingPeople, SamplingTime, SamplingWay, SamplingTool, SamAmount, DevideWay, SamContain, Warning, SamSave, TerminalIP, TerminalName, revUserId);
        }

        public int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, int Temperature, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.EnvIncubatorSetData(pclsCache, IncubatorId, MeaTime, Temperature, TerminalIP, TerminalName, revUserId);
        }

        public int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.EnvIsolatorSetData(pclsCache, IsolatorId, CabinId, MeaTime, IsoCode, IsoValue, TerminalIP, TerminalName, revUserId);
        }
    }
}
