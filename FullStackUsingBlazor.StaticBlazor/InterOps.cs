using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackUsingBlazor.StaticBlazor
{
    public class InterOps
    {
        private readonly IJSRuntime _jsRuntime;

        public InterOps(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task SaveAs(string filename, byte[] data)
        {
            return _jsRuntime.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }
}
