using AltaApi.DTOs;

namespace AltaApi.UseCasesPorts
{
    public interface ICreateHeartBeatInitiateInputPort
    {
        Task Handle(dynamic data, string applicationAccess);

    }
}
