using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class DeleteLineEmployeeQuery : IRequest
{
    public int Id { get; set; }

   public DeleteLineEmployeeQuery(int Id)
   {
       this.Id = Id;
   }
}