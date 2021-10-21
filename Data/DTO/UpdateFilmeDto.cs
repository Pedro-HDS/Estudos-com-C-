using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTO
{
    public class UpdateFilmeDto
    {
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Campo diretor é obrigatorio")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter entre 1 e 600 minutos")]
        public string Duracao { get; set; }
    }
}
