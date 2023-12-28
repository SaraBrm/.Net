
// Generation Operators (Range, Repeat, Empty)

//var result = Enumerable.Range(1, 20).Where(x => x % 2 == 1);
//var result = Enumerable.Range(1, 20).Select(x => x * x);

//var result = Enumerable.Repeat("Hello", -1);


//var result = Enumerable.Empty<int>();


static IEnumerable<string> GetNames()
{
    return null;
}

//var result = GetNames();
//if (result != null)
//{
//    foreach (var item in result)
//        Console.WriteLine(item);
//}


var result = GetNames() ?? Enumerable.Empty<string>();   // null-coalescing operator
foreach (var item in result)
    Console.WriteLine(item);




Console.ReadKey();