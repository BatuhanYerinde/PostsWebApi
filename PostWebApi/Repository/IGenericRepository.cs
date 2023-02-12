namespace PostsWebApi.Repository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        T Add(T entity);

        T Delete(T entity);

        T GetById(int id);

        List<T> GetAll();

        T UpdateById(T entity, int id);
    }
}
