using System.Globalization;
using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CreateLineMovementHandler : IRequestHandler<CreateLineMovementQuery>
{
 private readonly IRepository<LineMovement> repository;
 private readonly IMapper mapper;
 private readonly IRepository<LostTime> _repository;
 private readonly IRepository<DailyPlanProduction> __repository;
 private readonly IRepository<Employee> repository3;

 public CreateLineMovementHandler(IMapper mapper,IRepository<LineMovement> repository,IRepository<LostTime> _repository,IRepository<DailyPlanProduction> __repository,IRepository<Employee> repository3)
 {
  this.repository = repository;
  this.mapper = mapper;
  this._repository = _repository;
  this.__repository = __repository;
  this.repository3 = repository3;
 }


 public async Task<Unit> Handle(CreateLineMovementQuery request, CancellationToken cancellationToken)
 {
  var lostime = await this._repository.GetByFilterAsync(x => x.Name == "Aktif");
  
  var currentDate = DateTime.Now.Date;
 
  var dailyPlanProduction = await this.__repository.GetByFilterAsync(x =>  x.Prod_Date.Date.Equals(currentDate.Date));


   var linemovement = await this.repository.GetByFilterAsync(x => x.EmployeeId == request.EmployeeId);

   if (linemovement == null && dailyPlanProduction != null)
   {
    await this.repository.CreateAsync(new LineMovement()
    {
     EmployeeId = request.EmployeeId,
     lineId = request.LineId,
   
     lostTimeId = lostime.Id,
     EmployeeStartTime = TimeSpan.Parse(request.startTime),
     DailyProductionPlanId = dailyPlanProduction.Id,
     EmployeeEndTime = TimeSpan.Parse("18:30")




    });

   }

  

  
  
    
  
 


  

  return Unit.Value;
  
 }  
 
}