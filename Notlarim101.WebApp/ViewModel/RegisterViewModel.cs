using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Notlarim101.WebApp.ViewModel
{
    public class RegisterViewModel
    {
        [DisplayName("Kullanici Adi"), 
         Required(ErrorMessage = "{0} alani bos gecilemez."),
         StringLength(30, ErrorMessage = "{0} max. {1} karakter olmali.")]

        public string Username { get; set; }
        [DisplayName("Email"),
         Required(ErrorMessage = "{0} alani bos gecilemez."),
         StringLength(100, ErrorMessage = "{0} max. {1} karakter olmali."),
        EmailAddress(ErrorMessage = "{0} alani icin gecerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [DisplayName("Sifre"),
         Required(ErrorMessage = "{0} alani bos gecilemez."),
         DataType(DataType.Password),
         StringLength(30, ErrorMessage = "{0} max. {1} karakter olmali.")]
        public string Password { get; set; }
        [DisplayName("Sifre Tekrar"),
         Required(ErrorMessage = "{0} alani bos gecilemez."),
         DataType(DataType.Password),
         StringLength(30, ErrorMessage = "{0} max. {1} karakter olmali."),Compare("Password",ErrorMessage = "{0} ile {1} uyusmuyor...")]
        public string RePassword { get; set; }

    }
}