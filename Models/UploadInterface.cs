using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Doctor_MVC_Miniproject3.Models
{
    public interface UploadInterface
    {

        void uploadfilemultiple(IList<IFormFile> files);
    }
}
