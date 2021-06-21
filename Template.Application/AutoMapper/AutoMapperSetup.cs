﻿using AutoMapper;
using Template.Application.ViewModels;
using Template.Domain.Entities;

namespace Template.Application.AutoMapper
{
    public class AutoMapperSetup : 
        Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
