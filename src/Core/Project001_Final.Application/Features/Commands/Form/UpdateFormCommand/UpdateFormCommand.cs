using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Form.UpdateFormCommand
{
    public class UpdateFormCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string FormCode { get; set; }
        public string FormName { get; set; }
        public bool IsActive { get; set; }
    }
}
