namespace Day10P4
{
    internal class Program
    {
        static async Task ReadFileAsync(string fileName)
        {
            string content = await File.ReadAllTextAsync(fileName);

            Console.WriteLine($"Processing {fileName}");

            await Task.Delay(2000); 

            await File.WriteAllTextAsync($"{fileName}", content);
        }
        static async Task Main(string[] args)
        {
            //    Console.WriteLine("Hello, World!");

            //string content = await File.ReadAllTextAsync("file.txt");

            //// Write file asynchronously
            //await File.WriteAllTextAsync("file1.txt", content);

            // Process multiple files in parallel

            //string basePath = AppContext.BaseDirectory;
            //string[] files =
            //{
            //Path.Combine(basePath, "file1.txt"),
            //Path.Combine(basePath, "file2.txt"),
            //Path.Combine(basePath, "file3.txt")
            //};

            string[] files = { "file1.txt", "file2.txt", "file3.txt" };
            var tasks = files.Select(f => ReadFileAsync(f));
            await Task.WhenAll(tasks);
        }
    }
}
