using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.SystemEntities
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string NickName { get; set; }

        public string Password { get; set; }
    }
}
