using ConsoleUI;

ColumnContainer table = new();

void AddRow(string col1, string col2)
{
    RowContainer row = new();
    row.AddChild(new Label(col1));
    row.AddChild(new Label("  ")); 
    row.AddChild(new Label(col2));
    table.AddChild(row);
}


AddRow("ID", "Name");

AddRow("1", "Jhon Doe");
AddRow("2", "Jane Doe");
AddRow("3", "Alice Smith");
AddRow("4", "Bob Johnson");

RowContainer buttonRow = new();
buttonRow.AddChild(new Label("  "));
buttonRow.AddChild(new Button("Save"));
table.AddChild(buttonRow);

Console.Clear();
Console.CursorLeft = 1;
Console.CursorTop = 1;

table.Render();
Console.ReadKey();
// Program.cs