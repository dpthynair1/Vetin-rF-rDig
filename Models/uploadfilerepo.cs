﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Doctor_MVC_Miniproject3.Models
{
    public class uploadfilerepo: UploadInterface
    {
        private IHostingEnvironment hostingEnvironment;
        public uploadfilerepo(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public async void uploadfilemultiple(IList<IFormFile> files)
        {
            long totalBytes = files.Sum(f => f.Length);

            foreach(IFormFile item in files)
            {
                string filename = item.FileName.Trim('"');
              //  string filepath;
                byte[] buffer = new byte[16 * 1024];

                //string path = this.hostingEnvironment.WebRootPath + "/uploads/";
                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}

                    
                //filepath= path + filename;

                  using (FileStream output = System.IO.File.Create(this.GetpathAndFileName(filename)))
             //   using (FileStream output = System.IO.File.Create(filepath))
                {
                    using (Stream input = item.OpenReadStream())
                    {
                        long totalReadBytes = 0;
                        int readBytes;
                        while ((readBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            await output.WriteAsync(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                    }
                }
            }
           
        }

        private string GetpathAndFileName(string filename)
        {
            string path = this.hostingEnvironment.WebRootPath + "/uploads/";
            if(!Directory.Exists(path))
            
                Directory.CreateDirectory(path);
                return path + filename;
            
        }
    }
}
