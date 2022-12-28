﻿using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/user/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService) {
        _blogService = blogService;
    }

    [HttpGet("get-all-blog")]
    public IEnumerable<string> getAllBlog()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get-blog/{id:Guid}")]
    public string GetBlog(Guid id)
    {
        return "value";
    }
}
