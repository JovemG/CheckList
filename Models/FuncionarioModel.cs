using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckList.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Matricula { get; set; }
        public string Nome { get; set; }
    }


}
