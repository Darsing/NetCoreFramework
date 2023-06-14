using Identity_gestione.DB.Entities;
using Identity_gestione.DB;
using Identity_gestione.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_gestione.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SignInManager<User> signInManager;
        private UserManager<User> userManager;
        private UserDBContext dbContext;

        public HomeController(ILogger<HomeController> logger,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            UserDBContext dbContext)
        {
            _logger = logger;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult HiddenPage()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage()
        {
            return View();
        }
        //questi 2 endpoint [Authorize],[Authorize(Roles = "Admin")] 
        //Hanno un attributo Authorize significa che per accedere a questa tu devi essere loggato
        //qualsiasi la tua utenza tu devi essere loggato
        //Con l altro per potter entrare tu devi avere il Roles Admin
        public IActionResult Login()
        {
            return View();
        }

        // [HttpPost] questa è un endpoint mvc e return una view Redirect("Index");
        // perche ereditano da controller e non da controller base invece questi sono delle get
        //public IActionResult Index()
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                //prima istruzione è trovare utente sul Db tramite il userManager
                //dopo fa il controllo se user != null =>chiama questa funzionalità
                //signInManager.PasswordSignInAsync(loggarti con la password)
                User user = await userManager.FindByNameAsync(loginModel.UserName);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, lockoutOnFailure: true);
                    if (result.Succeeded)
                    {
                        //qui posso fare un altro controllo tipo se la login non è andato bene faccio
                        //qualcosa .....
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Redirect("Index");
        }

        //questa controlla se c'è loggato di slogga(Logout)
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            try
            {
                if (signInManager.IsSignedIn(User))
                {
                    await signInManager.SignOutAsync();
                }
            }
            catch (Exception ex)
            {
            }
            return Redirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}