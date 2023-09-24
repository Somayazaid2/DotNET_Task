using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.DAL.Manager
{
    public static class FileManager
    {
        public static async Task<byte[]> UploadFileAsync(IFormFile file)
        {
            using var dataStreem = new MemoryStream();
            await file.CopyToAsync(dataStreem);
            return dataStreem.ToArray();

        }
    }
}
