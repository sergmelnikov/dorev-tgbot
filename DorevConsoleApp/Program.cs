﻿using DorevConsoleApp;
using DorevLibrary;

const string usageText = """
Usage: dorev [option] [word]

Options:
    -b    search in the beginning of a word (default)
    -e    search in the end of a word
    -a    search anywhere in a word
""";

const string connectionString = 
    "Data Source=/Users/sergeymelnikov/dorev/dorev.db";
var rep = new SqliteDbRepository(connectionString);

try


{
    var arguments = ArgumentsParser.GetArguments(args);
    Console.WriteLine(rep.Translate(arguments.Word!, arguments.Option!));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(usageText);
}
