﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlarim101.Entity
{
    [Table("tblNotlarimUsers")]
    public class NotlarimUser : MyEntityBase
    {
        [DisplayName("Adı"), StringLength(30, ErrorMessage = "{0} alanı max{1} karakter olmalıdır.")]
        public string Name { get; set; }
        [DisplayName("Soyadı"), StringLength(30, ErrorMessage = "{0} alanı max{1} karakter olmalıdır.")]
        public string Surname { get; set; }
        [DisplayName("KulanıcıAdı"), StringLength(30, ErrorMessage = "{0} alanı max{1} karakter olmalıdır."), Required]
        public string Username { get; set; }
        [DisplayName("Eposta"), StringLength(100, ErrorMessage = "{0} alanı max{1} karakter olmalıdır."), Required]
        public string Email { get; set; }
        [DisplayName("Şifre"), StringLength(100, ErrorMessage = "{0} alanı max{1} karakter olmalıdır."), Required]
        public string Password { get; set; }
        [ScaffoldColumn(false)]
        [StringLength(30, ErrorMessage = "{0} alanı max{1} karakter olmalıdır.")]
        public string ProfileImageFilename { get; set; }
        public bool IsActive { get; set; }
        [ScaffoldColumn(false)]
        [Required]
        public Guid ActivateGuid { get; set; }
        public bool IsAdmin { get; set; }
        public virtual List<Note> Notes { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }
        //[NotMapped]
        //public string nameSurname
        //{
        //    get { return nameSurname; }
        //    set {nameSurname=Name+" " + Surname }
        //}

    }
}
