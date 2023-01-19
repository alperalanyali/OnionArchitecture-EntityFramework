using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Language.GetAllLanguage
{
    public class GetAllLanguageQuery:BaseListQuery<LanguageDto>
    {
        //public int? Id { get; set; }
        //public string Code { get; set; }
        //public string Name { get; set; }


        //Eski hali class'a bağlanmadan önceki hali
        //public string SearchInput { get; set; }
    }
}
