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

    public class MyEntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Oluşturma Tarihi"), Required]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Güncelleme Tarihi"), Required]
        public DateTime ModifiedOn { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Güncelleyen"), Required, StringLength(30)]
        public string ModifiedUsername { get; set; }
    }
}
