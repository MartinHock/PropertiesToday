using Application.Models;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequest : IRequest<
        bool
    >
    {
        public NewPropertyRequest? NewPropertyRequest { get; set; }

        public CreatePropertyRequest(NewPropertyRequest? newPropertyRequest)
        {
            NewPropertyRequest = newPropertyRequest;
        }

       
    }
}