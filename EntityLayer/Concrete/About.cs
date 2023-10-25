﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace EntityLayer.Concrete
{
	public class About
	{
        [Key]
        public int AboutID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image1{ get; set; }

        public string Title2 { get; set; }

        public string Description2 { get; set; }

        public bool Status { get; set; }


    }
}

