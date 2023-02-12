using PostsWebApi.Models;

namespace PostsWebApi.Service
{
    public interface IPostService
    {
        Post Create(Post post);

        Post GetPost(int id);

        List<Post> GetAllPosts();

        Post DeletePost(int id);

        Post Update(int id, Post post);
    }
}
