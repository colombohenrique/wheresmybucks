using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Identity.DTO
{
    public record UserDto
    (
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        string Name,

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        string Email
    );
}
