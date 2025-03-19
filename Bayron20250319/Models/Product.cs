using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Bayron20250319.Models;

public partial class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio debe estar entre 0.01 y 99999999.99")]
    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }
}
