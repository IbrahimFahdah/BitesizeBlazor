using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace CallingJSFromNet
{
    public static class FileUtil
    {
        public async static Task DownloadFile(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "download",
                filename,
                Convert.ToBase64String(data));
        }


    }
}
