﻿using FluentAssertions;
using Medium.Core.Domain;
using Medium.Core.Repositories;
using Medium.Infrastructure.Data.Context;
using Medium.Infrastructure.Repositories;
using Medium.IntegrationTest.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Medium.IntegrationTest.Repositories
{
    public class PostRepositoryTest
    {
        private readonly DataContext _inMemoryDbContext;
        private readonly IPostRepository _postRepository;

        public PostRepositoryTest()
        {
            var configServices = ServicesConfiguration.Configure();

            _inMemoryDbContext = configServices
                .GetRequiredService<DataContext>()
                .SeedTestData();
            _postRepository = new PostRepository(_inMemoryDbContext);
        }

        [Fact]
        public void ShouldCanConnectInMemoryDatabase()
        {
            _inMemoryDbContext.Database.IsInMemory().Should().BeTrue();
            _inMemoryDbContext.Database.CanConnect().Should().BeTrue();
        }
    }

    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(DataContext context) : base(context) {}

        public Task CreatePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(Guid postId)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetByIdAsync(Guid postId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePostAsync(Post post)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(Guid postId);
        Task CreatePostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(Guid postId);
        Task DeletePostAsync(Post post);
    }
}
