using PostAway.API.Entities;
using PostAway.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PostAway.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PostsController : ControllerBase
  {
    private readonly PostService _postService;

    public PostsController(PostService postService)
    {
      _postService = postService;
    }

    [HttpGet]
    public ActionResult<List<Post>> Get()
    {

      var postsFromRepo = _postService.GetPosts();
      return new JsonResult(postsFromRepo);
    }


    [HttpGet("{id:length(24)}", Name = "GetPost")]
    public ActionResult<Post> Get(string id)
    {
      var post = _postService.Get(id);

      if (post == null)
      {
        return NotFound();
      }

      return post;
    }

    [HttpPost]
    public ActionResult<Post> Create(Post post)
    {
      _postService.Create(post);

      return CreatedAtRoute("GetPost", new { id = post.Id.ToString() }, post);
    }

    [HttpPut("{id:length(24)}")]
    public IActionResult Update(string id, Post bookIn)
    {
      var post = _postService.Get(id);

      if (post == null)
      {
        return NotFound();
      }

      _postService.Update(id, bookIn);

      return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
      var post = _postService.Get(id);

      if (post == null)
      {
        return NotFound();
      }

      _postService.Remove(post.Id);

      return NoContent();
    }
  }
}