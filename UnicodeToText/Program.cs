using System.Text.RegularExpressions;
// Make console input up to 100_000~(may be changed) symbols.
Console.SetIn(new StreamReader(Console.OpenStandardInput(), Console.InputEncoding, false, 100_000));

while (true)
{
	WriteTitle();

	string? str = Console.ReadLine();
	if (str == null)
		return;

	string text = Regex.Unescape(str);

	Console.WriteLine(text);
}
static void WriteTitle()
{
	Console.Write("Write unicode text like this(");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write(@"\u041F\u043E\u043F\u0440\u043E\u0433\u0430\u0442\u044C \u002B(\u0447\u0430\u0441\u043E\u0432)");
	Console.ResetColor();
	Console.WriteLine("):");
}