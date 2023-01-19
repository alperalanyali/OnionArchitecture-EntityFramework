using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Form.CreateForm
{
    public class CreateFormCommand:IRequest<ServiceResponse<int>>
    {
        public string FormCode { get; set; }
        public string FormName { get; set; }
    }
}
