﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApp.Models;
using TestApp.Library.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace TestApp.Controllers
{
    public class CustomFilesController : BaseController
    {
        private readonly TestAppEntities _ctx;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CustomFilesController(TestAppEntities ctx, IWebHostEnvironment hostingEnvironment)
        {
            _ctx = ctx;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await CustomFiles.GetList(_ctx);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await CustomFiles.GetItem(_ctx, id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await CustomFiles.GetItem(_ctx, id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CustomFiles model)
        {
            var path = await CustomFiles.GetItem(_ctx, model.customfile_id);
            var result = CustomFiles.Delete(_ctx, model.customfile_id);
            System.IO.File.Delete(path.path);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new CustomFilesCreateViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomFilesCreateViewModel model)
        {
            if(model.file != null && model.file.Length > 0)
            {
                string fileName = String.Empty;
                string filePath = String.Empty;
                byte[] bytes;
                var fileExtension = "pdf";

                fileName = String.Format("CustomFile_{0}.{1}", Guid.NewGuid().ToString(), fileExtension);
                filePath = Path.Combine(Path.Combine(_hostingEnvironment.ContentRootPath, "customfiles"), fileName);

                using (var ms = new MemoryStream())
                {
                    model.file.CopyTo(ms);
                    bytes = ms.ToArray();
                }

                await System.IO.File.WriteAllBytesAsync(filePath, bytes);

                await CustomFiles.Add(_ctx, new CustomFiles()
                {
                    description = model.description,
                    path = filePath
                });

                return RedirectToAction(nameof(CustomFilesController.Index));
            }
            else
            {
                ModelState.AddModelError(String.Empty, "File is required.");
                return View(model);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await CustomFiles.GetItem(_ctx, id);
            var model = new CustomFilesCreateViewModel();
            model.customfile_id = item.customfile_id;
            model.description = item.description;
            model.isActive = item.is_active ?? false;
            model.created_at = item.created_at;
            model.path = item.path;
            return View(model);
        }
        public async Task<IActionResult> DownloadFile(int id)
        {
            var item = await CustomFiles.GetItem(_ctx,id);
            
            var filesPath = Path.Combine(_hostingEnvironment.ContentRootPath, "customfiles");

       
         
         

            if (System.IO.File.Exists(item.path))
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(item.path);
                return File(fileBytes, "application/pdf", item.description+ ".pdf");
            }
            else
            {
                // Mostrar error.
                ViewBag.ErrorMessage = "File not found.";
            }

            return RedirectToAction("index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CustomFilesCreateViewModel model)
        {
            if (model.file != null && model.file.Length > 0)
            {
                string fileName = String.Empty;
                string filePath = String.Empty;
                byte[] bytes;
                var fileExtension = "pdf";

                fileName = String.Format("CustomFile_{0}.{1}", Guid.NewGuid().ToString(), fileExtension);
                filePath = Path.Combine(Path.Combine(_hostingEnvironment.ContentRootPath, "customfiles"), fileName);

                using (var ms = new MemoryStream())
                {
                    model.file.CopyTo(ms);
                    bytes = ms.ToArray();
                }

                await System.IO.File.WriteAllBytesAsync(filePath, bytes);

                await CustomFiles.Add(_ctx, new CustomFiles()
                {
                    description = model.description,
                    path = filePath
                });

                return RedirectToAction(nameof(CustomFilesController.Index));
            }
            else
            {
                ModelState.AddModelError(String.Empty, "File is required.");
                return View(model);
            }
            model.is_active = model.isActive;
             
            var result = await CustomFiles.Update(_ctx, model);

            return RedirectToAction("Index");
            }
        }
    }
