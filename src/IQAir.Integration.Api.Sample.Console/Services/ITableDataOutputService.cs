using IQAir.Integration.Api.Sample.Console.ViewModels;

namespace IQAir.Integration.Api.Sample.Console.Services;

public interface ITableDataOutputService
{
    void Initialize();
    void AddRow(TableRowViewModel  viewModel);
}