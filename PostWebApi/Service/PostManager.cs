using PostsWebApi.Models;
using PostsWebApi.Repository;

namespace PostsWebApi.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Post> _repository;
        public PostManager(IGenericRepository<Post> repository)
        {
            _repository = repository;
        }
        public Post Create(Post post)
        {
            return _repository.Add(post);
        }

        public Post DeletePost(int id)
        {
            var post = _repository.GetById(id);
            return _repository.Delete(post);
        }

        public List<Post> GetAllPosts()
        {
            return _repository.GetAll();
        }

        public Post GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Post Update(int id, Post post)
        {
            return _repository.UpdateById(post, id);
        }
    }
}
