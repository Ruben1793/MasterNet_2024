using MasterNet.Domain;

namespace MasterNet.Application.Interfaces;

public interface IReportService<T> where T : BaseEntity
{
    Task<MemoryStream> GetCsvReportList(List<T> records);
}