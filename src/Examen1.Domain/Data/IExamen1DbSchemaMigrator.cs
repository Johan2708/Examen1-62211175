using System.Threading.Tasks;

namespace Examen1.Data;

public interface IExamen1DbSchemaMigrator
{
    Task MigrateAsync();
}
