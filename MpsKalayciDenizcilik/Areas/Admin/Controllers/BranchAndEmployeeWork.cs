using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MpsService.EntityService.IService;

namespace MpsKalayciDenizcilik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BranchAndEmployeeWork : Controller
    {

        private readonly IBranchService _branchService;
        private readonly IEmployeeWorkService _EmployeeWorkService;

        public BranchAndEmployeeWork(IBranchService branchService, IEmployeeWorkService EmployeeWorkService)
        {
            _branchService=branchService;
            _EmployeeWorkService= EmployeeWorkService;
        }



        [HttpGet]
        public async Task<IActionResult> BranchList()
        {
            ICollection<BranchViewModel> model = await _branchService.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> BranchEmployees(uint Id)
        {// burda performans testi yapılacaktır.Öğrenme ve gelişim için
            //1. alternatif  branştan include ile personeller getirilecek.
            ICollection<EmployeeViewModel> model = await _branchService.GetBranchPersonelListWithInclude(Id);
            //2. alternatif Personelleri branş id ile sorgulayıp getirilecek.
            ICollection<EmployeeViewModel> model2 = await _branchService.GetBranchPersonelListWithQuery(Id);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddBranch()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBranch([FromForm] BranchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Sgk Branş Eklenemiyor Bilgi işlemle Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }

            var result = await _branchService.CreateAsync(model);
            if (result.Item1)
            {
                TempData["Message"] = "Branş Ekleme başarılı";
                TempData["MessageColor"] = "alert-success";

                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["Message"] = "Gerekli Alanları Uygun şekilde Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> ModifiedBranch(uint Id)
        {

            var model = await _branchService.GetAsync(Id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ModifiedBranch([FromForm] BranchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Sgk Branş Güncellenemiyor Bilgi işlemle Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }

            var result = await _branchService.ModifiedAsync(model);
            if (result.Item1)
            {
                TempData["Message"] = "Sgk Branş Ekleme başarılı";
                TempData["MessageColor"] = "alert-success";

                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["Message"] = "Gerekli Alanları Uygun şekilde Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> PassiveBranch(uint Id)
        {
            (bool, string) result = await _branchService.PassiveAsync(Id);

            if (result.Item1)
            {
                TempData["Message"] = $"{result.Item2} Sgk Branşı Pasife alınmıştır.";
                TempData["MessageColor"] = "alert-success";
                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["Message"] = $"{result.Item2} Sgk Branş Pasife Alınamıyor Bilgi işleme Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return RedirectToAction("BranchList");
            }

        }
        [HttpPost]
        public async Task<IActionResult> DeleteBranch(uint Id)
        {
            (bool, string) result = await _branchService.RemoveAsync(Id);

            if (result.Item1)
            {
                TempData["Message"] = $"{result.Item2} Sgk Branşı Silinmiştir";
                TempData["MessageColor"] = "alert-success";
                return RedirectToAction("BranchList");
            }
            else
            {
                TempData["Message"] = $"{result.Item2} Sgk Branşı Silinemiyor Bilgi işleme Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return RedirectToAction("BranchList");
            }
        }





        /// <summary>
        /// Processes related to EmployeeWork are below.
        /// </summary>
        /// <returns></returns>

 


        [HttpGet]
        public async Task<IActionResult> EmployeeWorkList()
        {
            ICollection<EmployeeWorkViewModel> model = await _EmployeeWorkService.GetAllAsync();
            return View(model);
        }


    
        [HttpGet]
        public async Task<IActionResult> EmployeeWorkEmployees(uint Id)
        {// burda performans testi yapılacaktır.Öğrenme ve gelişim için
            //1. alternatif  branştan include ile personeller getirilecek.
            ICollection<EmployeeViewModel> model = await _EmployeeWorkService.GetEmployeeWorkPersonelListWithInclude(Id);
            //2. alternatif Personelleri branş id ile sorgulayıp getirilecek.
            ICollection<EmployeeViewModel> model2 = await _EmployeeWorkService.GetEmployeeWorkPersonelListWithQuery(Id);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddEmployeeWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployeeWork([FromForm] EmployeeWorkViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Şirket Branşı Eklenemiyor Bilgi işlemle Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }

            var result = await _EmployeeWorkService.CreateAsync(model);
            if (result.Item1)
            {
                TempData["Message"] = "Şirket Branşı Ekleme başarılı";
                TempData["MessageColor"] = "alert-success";

                return RedirectToAction("EmployeeWorkList");
            }
            else
            {
                TempData["Message"] = "Gerekli Alanları Uygun şekilde Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> ModifiedEmployeeWork(uint Id)
        {
            var model = await _EmployeeWorkService.GetAsync(Id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ModifiedEmployeeWork([FromForm] EmployeeWorkViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Şirket Branşı Güncellenemiyor Bilgi işlemle Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }

            var result = await _EmployeeWorkService.ModifiedAsync(model);
            if (result.Item1)
            {
                TempData["Message"] = "Şirket Branşı Ekleme başarılı";
                TempData["MessageColor"] = "alert-success";

                return RedirectToAction("EmployeeWorkList");
            }
            else
            {
                TempData["Message"] = "Gerekli Alanları Uygun şekilde Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }
        }
       
        
        [HttpPost]
        public async Task<IActionResult> PassiveEmployeeWork(uint Id)
        {
            (bool, string) result = await _EmployeeWorkService.PassiveAsync(Id);

            if (result.Item1)
            {
                TempData["Message"] = $"{result.Item2} Şirket Branşı Pasife alınmıştır.";
                TempData["MessageColor"] = "alert-success";
                return RedirectToAction("EmployeeWorkList");
            }
            else
            {
                TempData["Message"] = $"{result.Item2} Şirket Branş Pasife Alınamıyor Bilgi işleme Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return RedirectToAction("EmployeeWorkList");
            }

        }
        [HttpPost]
        public async Task<IActionResult> DeleteEmployeeWork(uint Id)
        {
            (bool, string) result = await _EmployeeWorkService.RemoveAsync(Id);

            if (result.Item1)
            {
                TempData["Message"] = $"{result.Item2} Şirket Branşı Silinmiştir";
                TempData["MessageColor"] = "alert-success";
                return RedirectToAction("EmployeeWorkList");
            }
            else
            {
                TempData["Message"] = $"{result.Item2} Şirket Branşı Silinemiyor Bilgi işleme Başvurunuz.";
                TempData["MessageColor"] = "alert-danger";
                return RedirectToAction("EmployeeWorkList");
            }
        }




    }
}
