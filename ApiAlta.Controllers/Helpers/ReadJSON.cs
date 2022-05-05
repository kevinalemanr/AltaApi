using Microsoft.AspNetCore.Mvc;
using AltaApi.Adapters;
using AltaApi.Adapters.Folders;
using Newtonsoft.Json;


namespace AltaApi.Controllers.Helpers
{
    public static class ReadJSON
    {
        public static CreateLineInventoryAdapter  ReadInventory(string value)
        {
           var newIline = JsonConvert.DeserializeObject<CreateLineInventoryAdapter>(value);

            Console.WriteLine($"TrainId : {newIline.CreateLineInventoryInIfd.CtrlSeg.Tranid}");

            return newIline;
        }

        public static HeartBeatInitiateAdapter ReadHeartBeat(string value)
        {
            var newHBI = JsonConvert.DeserializeObject<HeartBeatInitiateAdapter>(value);
            Console.WriteLine($"TranId: {newHBI.HeartBeat.CtrlSeg.Tranid} from ");

            return newHBI;
        }

        public static RequestInitiateAdapter ReadRequestInitiate(string value)
        {
            var newRI = JsonConvert.DeserializeObject<RequestInitiateAdapter>(value);
               Console.WriteLine($"TranId: {newRI.Request.CtrlSeg.Tranid.ToString()}");

            return newRI;   
        }

        public static MovementConfirmAdapter ReadMovementConfirm(string value)
        {
            var newMC = JsonConvert.DeserializeObject<MovementConfirmAdapter>(value);
            Console.WriteLine($"TranId {newMC.MovimentConfirm.CtrlSeg.Tranid.ToString()}");
            return newMC;
        }
    }
}
