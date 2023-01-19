using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Language.CreateLanguage
{
    public class CretaLanguageCommand:IRequest<ServiceResponse<int>>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
