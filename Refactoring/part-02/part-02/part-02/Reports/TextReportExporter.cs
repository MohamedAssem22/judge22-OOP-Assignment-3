namespace part_02.Reports;

public class TextReportExporter : MakeReport
{
    protected override string Format(List<string[]> rows) => 
        string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));
}