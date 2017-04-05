using System;
using System.Web;

namespace WebApplication1.DataModels
{
    public class Operation
    {
    }

    public class OperationInfo
    {
        public string EquipmentId { get; set; }
        public string OperationNo { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperationCode { get; set; }
        public string OperationValue { get; set; }
        public string OperationResult { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }
}
