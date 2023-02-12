using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostsWebApi.Models;
using PostsWebApi.Service;

namespace PostWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            var response = _postService.Create(post);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _postService.GetAllPosts();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            return Ok(_postService.DeletePost(id));
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, Post post)
        {
            return Ok(_postService.Update(id, post));
        }
    }
}
