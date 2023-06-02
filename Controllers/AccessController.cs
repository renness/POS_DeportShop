using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using POS_DeportShop.Models;
using POS_DeportShop.Models;

using POS_DeportShop.Data;

namespace POS_DeportShop.Controllers
{
    public class AccessController : Controller
    {

        POS_DeportShopContext ctx;

        public AccessController(POS_DeportShopContext _context)
        {
            ctx=_context;
        }

        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuario modelLogin)
        {
            
            var usuario = ctx.Usuario.Where(u => u.Email == modelLogin.Email && u.PassWord == modelLogin.PassWord)
                    .FirstOrDefault<Usuario>();
            if(usuario != null)
            { 
                List<Claim> claims = new List<Claim>() 
                { 
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties","Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme );

                AuthenticationProperties properties = new AuthenticationProperties()
                {     
                    AllowRefresh = true,
                    IsPersistent = modelLogin.MantenerActivo
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
                
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Credenciales incorrectas o cuenta no registrada.";
            //ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
