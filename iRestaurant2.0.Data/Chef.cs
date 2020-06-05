﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRestaurant2._0.Data
{
    public class Chef
    {
        [Key]
        public int ChefID { get; set; }
        [Required]
        public string Full_Name { get; set; }

        public string Speciality { get; set; }

        public Signature_Dish SignatureDish { get; set; }


    }
}