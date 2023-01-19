using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;
using Project001_Final.Application.Helpers;

namespace Project001_Final.Application.Features.Commands.User.CreateUserCommand
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ServiceResponse<int>>
    {
        IUserRepository _userRepository;
        IMapper _mapper;

        public CreateUserCommandHandler(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            
            var user = _mapper.Map<Domain.Entities.User>(request);
            user.Password = PasswordEncryptDecrypt.EncryptPassword(user.Password);
            await _userRepository.AddAsync(user);
            return new ServiceResponse<int>(user.Id);
        }
    }
}
