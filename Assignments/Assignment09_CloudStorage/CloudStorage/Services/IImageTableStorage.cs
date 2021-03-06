﻿using CloudStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorage.Services
{
    public interface IImageTableStorage
    {
        Task Startup();

        Task<ImageTableEntity> GetAsync(string id);

        Task<ImageTableEntity> AddOrUpdateAsync(ImageTableEntity image);

        Task<bool> DeleteAsync(string id);

        string GetUploadUrl(string fileName);

        string GetDownloadUrl(ImageTableEntity image);

        Task<List<ImageTableEntity>> GetAllImagesAsync();

        Task PurgeAsync();
    }
}
