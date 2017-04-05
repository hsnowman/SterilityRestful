using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public class OperationRepository : IOperationRepository
    {
        OperationMethod OperationMethod = new OperationMethod();
        public int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, string OperationNo, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId)
        {
            return OperationMethod.OpEquipmentSetData(pclsCache, EquipmentId, OperationNo, OperationTime, OperationCode, OperationValue, OperationResult, TerminalIP, TerminalName, revUserId);
        }
    }
}
