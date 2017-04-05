using System;
using System.Web;

namespace WebApplication1.DataModels
{
    public class ItemInfo
    {
    }

    public class IsolatorInfo
    {
        public string IsolatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class IncubatorInfo
    {
        public string IncubatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class ReagentInfo
    {
        public string ReagentId { get; set; }
        public DateTime ProductDay { get; set; }
        public string ReagentType { get; set; }
        public DateTime ExpiryDay { get; set; }
        public string ReagentName { get; set; }
        public string ReagentTest { get; set; }
        public string SaveCondition { get; set; }
        public string Description { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class SampleInfo
    {
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string SamplingPeople { get; set; }
        public DateTime SamplingTime { get; set; }
        public string SamplingWay { get; set; }
        public string SamplingTool { get; set; }
        public string SamAmount { get; set; }
        public string DevideWay { get; set; }
        public string SamContain { get; set; }
        public string Warning { get; set; }
        public string SamSave { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class IncubatorEnv
    {
        public string IncubatorId { get; set; }
        public DateTime MeaTime { get; set; }
        public int Temperature { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class IsolatorEnv
    {
        public string IsolatorId { get; set; }
        public string CabinId { get; set; }
        public DateTime MeaTime { get; set; }
        public string IsoCode { get; set; }
        public string IsoValue { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }
}
