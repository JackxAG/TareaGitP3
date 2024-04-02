using System.ComponentModel.DataAnnotations.Schema;
public class Inventarios
{
    [Key]
    public int InventarioId { get; set; }
    [Required(ErrorMessage = "Es necesario introducir el ID valido")]
    public int ProductoId { get; set; }
    public int CantidadAumentada { get; set; }
    [Required(ErrorMessage = "Introduzca el codigo de barra existente")]
    public string CodigoBarra { get; set; } = string.Empty;
    [Required(ErrorMessage = "La fecha a introducir es necesaria.")]
    [NotMapped]
    public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public bool Status { get; set; } = true;
    public int Existencia { get; set; }
}