using System;
using AutoMapper;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Features.Commands;
using Project001_Final.Application.Features.Commands.Form;
using Project001_Final.Application.Features.Commands.Form.CreateForm;
using Project001_Final.Application.Features.Commands.Form.UpdateFormCommand;
using Project001_Final.Application.Features.Commands.Language.CreateLanguage;
using Project001_Final.Application.Features.Commands.Language.UpdateLanguage;
using Project001_Final.Application.Features.Commands.NavigationItem.CreateNavigationItem;
using Project001_Final.Application.Features.Commands.NavigationItem.UpdateNavigationItemCommand;
using Project001_Final.Application.Features.Commands.NavigationItemRole.CreateNavigationItemRole;
using Project001_Final.Application.Features.Commands.NavigationItemRole.UpdateNavigationItemRoleCommand;
using Project001_Final.Application.Features.Commands.Post;
using Project001_Final.Application.Features.Commands.PostComment.CreatePostCommentCommand;
using Project001_Final.Application.Features.Commands.PostComment.UpdatePostCommentCommand;
using Project001_Final.Application.Features.Commands.PostLike;
using Project001_Final.Application.Features.Commands.Role.CreateRoleCommand;
using Project001_Final.Application.Features.Commands.Role.UpdateRoleCommand;
using Project001_Final.Application.Features.Commands.SavedPost.CreateSavedPost;
using Project001_Final.Application.Features.Commands.Status.CreateStatusCommand;
using Project001_Final.Application.Features.Commands.Status.UpdateStatusCommand;
using Project001_Final.Application.Features.Commands.User.CreateUserCommand;
using Project001_Final.Application.Features.Commands.User.UpdateUserCommand;
using Project001_Final.Application.Features.Commands.UserRole;
using Project001_Final.Application.Features.Commands.UserRole.UpdateUserRoleCommand;

namespace Project001_Final.Application.Mapping
{
    public class GeneralMapping:Profile
    {

        public GeneralMapping()
        {
            //    CreateMap<Domain.Entities.Student, Dtos.StudentDto>()
            //        .ReverseMap();
            //     CreateMap<Domain.Entities.Student, CreateStudentCommand>()
            //.ReverseMap()
            #region List
            CreateMap<Domain.Entities.User, Dtos.UserDto>().ForMember(x => x.FullName,y => y.MapFrom(z => z.Name + " " + z.Surname)).ReverseMap();
            
            CreateMap<Domain.Entities.Status, Dtos.StatusDto>().ReverseMap();

            CreateMap<Domain.Entities.Role, Dtos.RoleDto>().ForMember(x => x.StatusName,(Action<IMemberConfigurationExpression<Domain.Entities.Role, Dtos.RoleDto, string>>)(y => y.MapFrom((System.Linq.Expressions.Expression<Func<Domain.Entities.Role, string>>)(z => (string)z.Status.Name)))).ReverseMap();
            
            CreateMap<Domain.Entities.UserRole, Dtos.UserRoleDto>()              
               // .ForMember(x =>x.UserName,y => y.MapFrom(z=> z.User.LoginId))               
                .ForMember(x => x.RoleName,y => y.MapFrom(z=> z.Role.Name))
                .ReverseMap();
            CreateMap<Domain.Entities.Form, Dtos.FormDto>().ReverseMap();
            CreateMap<Domain.Entities.NavigationItem, Dtos.NavigationItemDto>()
                .ForMember(x => x.FormName, y => y.MapFrom(z => z.Form.FormName))
                .ReverseMap();
            CreateMap<Domain.Entities.NavigationItemRole, Dtos.NavigationItemRoleDto>()
            .ForMember(x => x.NavigationName, y => y.MapFrom(z => z.NavigationItem.NavigationName))
            .ForMember(x => x.RoleName, y => y.MapFrom(z => z.Role.Name))
            .ReverseMap();

            CreateMap<Domain.Entities.Language, Dtos.LanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.Post, Dtos.PostDto>()
                .ForMember(x => x.FullName,y => y.MapFrom(z => z.User.LoginId))
                .ForMember(x => x.Likes,y => y.MapFrom(z => z.PostLikes.Count))
                .ForMember(x => x.PostLikes,y=>y.MapFrom(z => z.PostLikes))
                .ForMember(x => x.PostCommentCount,y => y.MapFrom(z => z.PostComments.Count))
                .ForMember(x => x.PostComments,y => y.MapFrom(z => z.PostComments))
                .ReverseMap();
            CreateMap<Domain.Entities.PostLike, Dtos.PostLikeDto>()
                .ForMember(x => x.PostId,y=> y.MapFrom(z => z.PostId))
                .ForMember(x => x.UserId,y=> y.MapFrom(z => z.UserId))
                .ReverseMap();
            CreateMap<Domain.Entities.PostComment, Dtos.PostCommentDto>()
                .ForMember(x => x.UserId, y => y.MapFrom(z => z.UserId))
                .ForMember(x => x.PostId, y => y.MapFrom(z => z.PostId))
                .ReverseMap();
            CreateMap<Domain.Entities.SavedPost, Dtos.SavedPostDto>()
                .ForMember(x => x.PostId,y => y.MapFrom(z => z.PostId))
                .ForMember(x => x.UserId,y => y.MapFrom(z => z.UserId))
                .ReverseMap();
            #endregion

            #region  Create New Data
            CreateMap<Domain.Entities.User, CreateUserCommand>().ReverseMap();
            CreateMap<Domain.Entities.Role, CreateRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.Status, CreateStatusCommand>().ReverseMap();
            CreateMap<Domain.Entities.UserRole, CreateUserRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.Form, CreateFormCommand>().ReverseMap();
            CreateMap<Domain.Entities.NavigationItem, CreateNavigationItemCommand>().ReverseMap();
            CreateMap<Domain.Entities.NavigationItemRole, CreateNavigationItemRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.Language, CretaLanguageCommand>().ReverseMap();
            CreateMap<Domain.Entities.Post, CreatePostCommand>().ReverseMap();
            CreateMap<Domain.Entities.PostLike, CreatePostLikeCommand>().ReverseMap();
            CreateMap<Domain.Entities.PostComment, CreatePostCommentCommand>().ReverseMap();
            CreateMap<Domain.Entities.SavedPost, CreateSavedPostCommand>().ReverseMap();
            #endregion

            #region Update Data
            CreateMap<Domain.Entities.User, UpdateUserCommand>().ReverseMap();
            CreateMap<Domain.Entities.Role, UpdateRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.UserRole, UpdateUserRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.User, UpdateStatusCommand>().ReverseMap();   
            CreateMap<Domain.Entities.Form, UpdateFormCommand>().ReverseMap();
            CreateMap<Domain.Entities.NavigationItem, UpdateNavigationItemCommand>().ReverseMap();           
            CreateMap<Domain.Entities.NavigationItem, UpdateNavigationItemCommand>().ReverseMap();
            CreateMap<Domain.Entities.NavigationItemRole, UpdateNavigationItemRoleCommand>().ReverseMap();
            CreateMap<Domain.Entities.Language, UpdateLanguageCommand>().ReverseMap();
            CreateMap<Domain.Entities.PostComment, UpdatePostCommentCommand>().ReverseMap();
            #endregion

        }
    }
}
