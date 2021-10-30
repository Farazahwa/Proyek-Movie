using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSCMovie.Models;
using System.Text.Encodings.Web;
using NSCMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

namespace NSCMovie.Controllers
{
    public class ProfileController : Controller
    {
        public async Task<IActionResult> Avatar(string fileName)
        {
            var avatarFile = Path.Combine(Directory.GetCurrentDirectory(), "Avatars", fileName);
            new FileExtensionContentTypeProvider().TryGetContentType(avatarFile, out var contentType);
            var fileBytes = await System.IO.File.ReadAllBytesAsync(avatarFile);
            return File(fileBytes, contentType ?? "application/octet-stream");
        }
    }
}