using System;
using System.IO;
using System.Threading.Tasks;

//var lines = File.ReadAllLines("TextFile1.txt");
//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}

//File.ReadAllLinesAsync("TextFile1.txt")
//    .ContinueWith(t =>
//    {
//        if (t.IsFaulted)
//        {
//            Console.Error.WriteLine(t.Exception);
//            return;
//        }
//        // task will be complited!
//        var lines = t.Result;
//        foreach (var line in lines)
//        {
//            Console.WriteLine(line);
//        }
//    });
//Console.ReadKey();

async Task ReadFile()
{
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}

await ReadFile();

static async Task<int> GetDataFromNetworkAsync()
{ 
    // simulate a network call
    await Task.Delay(150);
    var result = 42;

    return result;
}

var networkResult = await GetDataFromNetworkAsync();

Func<Task<int>> getDataFromNetworkViaLambda = async () =>
{
    // simulate a network call
    await Task.Delay(150);
    var result = 42;

    return result;
};