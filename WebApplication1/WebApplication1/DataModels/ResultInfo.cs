using System;
using System.Web;

namespace WebApplication1.DataModels
{
    public class ResultInfo
    {
    }

    public class TestResultInfo
    {
        public string TestId { get; set; }
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string TestType { get; set; }
        public string TestStand { get; set; }
        public string TestEquip { get; set; }
        public string Description { get; set; }
        public DateTime CollectStart { get; set; }
        public DateTime CollectEnd { get; set; }
        public DateTime TestTime { get; set; }
        public string TestResult { get; set; }
        public string TestPeople { get; set; }
        public int ReStatus { get; set; }
        public string RePeople { get; set; }
        public string ReTime { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class ResIncubator
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string CultureId { get; set; }
        public string BacterId { get; set; }
        public string OtherRea { get; set; }
        public string IncubatorId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AnalResult { get; set; }
    }
}
