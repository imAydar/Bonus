using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bonus.Data.Models
{
    public class Customer
    {
        // ID 
        public int Id { get; set; }
        // Фамилия Имя Отчество
        [Required]
        [Display(Name = "Фамилия Имя Отчество")]
        [MaxLength(100, ErrorMessage = "Превышена максимальная длина записи")]
        public string Name { get; set; }
       
        [Display(Name = "Телефон")]
        [MaxLength(15, ErrorMessage = "Превышена максимальная длина записи")]
        public string Phone { get; set; }

        [Display(Name = "Почта")]
        [MaxLength(100, ErrorMessage = "Превышена максимальная длина записи")]
        public string Mail { get; set; }

        public DateTime DateOfBirth{get;set;}
        
       /* public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(property => property.Name).HasMaxLength(100);
        }*/
    }
}