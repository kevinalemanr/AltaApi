using AltaApi.DTOs;


namespace AltaApi.UseCasesPorts
{
    public interface ICreateRequestInitiateInputPort
    {
        Task Handle(dynamic value, string applicationAccess);

    }
}
