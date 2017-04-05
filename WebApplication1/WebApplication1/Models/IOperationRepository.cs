using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public interface IOperationRepository
    {
        int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, string OperationNo, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId);
    }
}
