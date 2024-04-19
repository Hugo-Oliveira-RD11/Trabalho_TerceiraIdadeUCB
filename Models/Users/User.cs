using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Users.User;

public class User
{
    [Required(ErrorMessage = "Precisamos do seu nome")]
    [DisplayName("Nome")]
    [StringLength(3, ErrorMessage = "digite um nome maior que {0}")]
    [MaxLength(55)]
    public string? Name { get; set; }

    [Key]
    [Required(ErrorMessage = "Precisamos do seu CPF para a inscrição")]
    [DisplayName("CPF")]
    public int Id { get; set; }

    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public EmailAddressAttribute? Email { get; set; }

    [Required(ErrorMessage = "É obrigatorio um meio de contato por algum numero")]
    [DataType(DataType.PhoneNumber)]
    public PhoneAttribute? phone { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [DisplayName("Senha")]
    public string? password { get; set; }

    [Required]
    [DisplayName("Idade")]
    [Range(45, 151, ErrorMessage = "o valor de entrada {0} precisa estar entre {1} e {2}.")]
    public ushort Old { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DataType ReleaseUser { get; set; }
}
