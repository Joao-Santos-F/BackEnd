using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_curtidas")]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tb_curti__F0961F6F0ADEA62D", IsUnique = true)]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tb_curti__F0961F6F11064A6F", IsUnique = true)]
public partial class TbCurtidas
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TbCurtidas")]
    public virtual TbPublicacao IdPublicacaoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbCurtidas")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
