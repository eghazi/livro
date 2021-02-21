using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace livraria.Models
{
    public class livro
    {
        #region Atributos
        
        public int LivroID { get; set; }
        public string sISBN { get; set; }
        public string sAutor { get; set; }
        public string sNome { get; set; }
        public decimal dPreco { get; set; }
        public DateTime? dtPublicacao { get; set; }
        public string sImagemCapa { get; set; }
        public string sDescImagemCapa { get; set; }
        public DateTime? dtCadastro { get; set; }

        #endregion
    }
}