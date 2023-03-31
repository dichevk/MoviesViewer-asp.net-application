using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetProducers();
        Task<Producer> GetProducer(Producer producer);
        Task<Producer> GetProducerById(string id);
        void AddProducer(Producer producer);
        Producer UpdateProducer(string id, Producer producer);
        void DeleteProducer(Producer producer);
    }
}
