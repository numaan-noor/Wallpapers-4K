﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallpapers_4K.Models
{
    public class Categories
    {
        public Categories()
        {
            wallpapers = new HashSet<Wallpaper>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Wallpaper> wallpapers { get; set; }

        public static implicit operator Categories(List<SelectListItem> v)
        {
            throw new NotImplementedException();
        }
    }
}
