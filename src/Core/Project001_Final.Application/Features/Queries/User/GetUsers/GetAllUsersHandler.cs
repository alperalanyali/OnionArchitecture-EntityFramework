using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.User.GetUsers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery,ServiceResponse<List<UserDto>>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetAllUsersHandler(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<UserDto>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.ListAsync(request);
            var dtos = _mapper.Map<List<UserDto>>(users);

            return new ServiceResponse<List<UserDto>>(dtos);


        }
    }
}
