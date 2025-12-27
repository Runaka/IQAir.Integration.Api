using IQAir.Integration.Api.Sample.Console.ViewModels;
using Spectre.Console;

namespace IQAir.Integration.Api.Sample.Console.Services;

public class TableDataOutputService : ITableDataOutputService
{
    private Table _table { get; set; }
    
    public void Initialize()
    {
        _table = new Table()
        .Border(TableBorder.Rounded)
        .BorderColor(Color.Grey)
        .AddColumn("Time")
        .AddColumn("AqiUs")
        .AddColumn("MainPollutantUs");
    }

    public void AddRow(TableRowViewModel viewModel)
    {
     AnsiConsole.Clear();
     AnsiConsole.Live(_table)
        .Start(ctx => 
        {
            _table.AddRow(viewModel.MeasuredAt.ToString(),$"[bold red]{viewModel.AqiUs.ToString()}[/]", viewModel.MainPollution);
            ctx.Refresh();
        });
    }
}