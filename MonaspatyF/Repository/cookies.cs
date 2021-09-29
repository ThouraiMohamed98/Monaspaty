using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonaspatyF.Repository
{
    public class cookies
    {
        IHttpContextAccessor _HttpContextAccessor;
        public cookies(IHttpContextAccessor _HttpContextAccessor)
        {
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public void setCooke(string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
            {
                option.Expires = DateTime.Now.AddDays(expireTime.Value);
            }
            else
            {
                option.Expires = DateTime.Now.AddMinutes(10);
            }
            //read cookie from IHttpContextAccessor
            //read cookie from Request object
            _HttpContextAccessor.HttpContext.Response.Cookies.Append("OwnerId", value, option);
        }

        public string GetCookie()
        {
            return _HttpContextAccessor.HttpContext.Request.Cookies["OwnerId"];
        }

        public void deleteCookie()
        {
            _HttpContextAccessor.HttpContext.Response.Cookies.Delete("OwnerId");
        }
    }
}
