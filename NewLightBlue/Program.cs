using LightBlue.Hosted;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLightBlue
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var blob = new HostedAzureBlockBlob(new Uri("https://devsectools.blob.core.windows.net/$web/android-chrome-512x512.png?sv=2023-01-03&st=2024-06-06T08%3A42%3A55Z&se=2024-06-07T08%3A42%3A55Z&sr=b&sp=r&sig=Non3v3MKuDCpkQyfgPXqWV52hB5lUU3gmBD3HJXhdgs%3D"));

            using (var ms = new MemoryStream())
            {
                await blob.DownloadToStreamAsync(ms);
                ms.Position = 0;

                //Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
            }
        }
    }
}
