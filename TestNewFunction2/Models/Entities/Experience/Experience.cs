﻿using Microsoft.EntityFrameworkCore;

namespace TestNewFunction2.Models.Entities.Experience
{
    [Keyless]
    public class Experience
    {
        public string ExprienceTitle { get; set; }
        public string ExprienceDuration { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string Url { get; set; }
    }
}