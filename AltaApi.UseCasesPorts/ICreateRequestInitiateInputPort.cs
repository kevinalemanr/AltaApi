using AltaApi.DTOs;


namespace AltaApi.UseCasesPorts
{
    public interface ICreateRequestInitiateInputPort
    {
        Task Handle(RequestInitiateCreationDTO requestInitiateCreationDTO);

    }
}
