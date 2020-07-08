﻿using AutoMapper;
using Medium.Core.Contracts.V1.Request;
using Medium.Core.Domain;

namespace Medium.App.Mapping
{
    public class RequestToDomain : Profile
    {
        public RequestToDomain()
        {
            CreateMap<UserRegistrationRequest, Author>();
        }
    }
}
