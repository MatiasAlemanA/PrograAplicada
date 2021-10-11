﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public enum SexType
{
    Female = 0,
    Male = 1,
}
public class Person
{
    [Key]
    public int PersonId { get; set; }
    [Required(ErrorMessage = "El campo nombre es requerido")]
    [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener entre 5 y 60 caracteres ")]
    [Display(Name = "Nombre completo")]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Sexo")]

    public SexType Sex { get; set; }
    [Display(Name = "Pasatiempos ")]
    public string Hobbie { get; set; }
}
