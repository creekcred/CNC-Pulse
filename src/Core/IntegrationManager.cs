namespace CNCPulse.Core
{
    public class IntegrationManager
    {
        private readonly MESConnector mesConnector;
        private readonly ERPConnector erpConnector;
        private readonly CNCMachineConnector cncMachineConnector;

        public IntegrationManager()
        {
            mesConnector = new MESConnector();
            erpConnector = new ERPConnector();
            cncMachineConnector = new CNCMachineConnector();
        }

        public void SyncAllData(MachineData machineData)
        {
            mesConnector.SyncDataWithMES(machineData);
            erpConnector.SyncDataWithERP(machineData);
        }

        public MachineData GetMachineData(string machineId)
        {
            return cncMachineConnector.GetMachineData(machineId);
        }
    }
}
