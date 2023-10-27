namespace Modulo03.Escola.Services
{
    public interface ICrud<T>
    {
        T Create(T model);
        List<T> Read();
        void Update(T model);
        void Delete(int id);
    }
}
