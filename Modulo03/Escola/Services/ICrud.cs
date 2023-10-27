using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services
{
    public interface ICrud<T> where T : BaseModel
    {
        T Create(T model);
        List<T> Read();
        void Update(T model);
        void Delete(int id);
    }
}
