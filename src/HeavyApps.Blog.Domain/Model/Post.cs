using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeavyApps.Blog.Domain.Enum;

namespace HeavyApps.Blog.Domain.Model
{
    public class Post : EntityBase
    {
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Corpo { get; set; }
        public DateTime DataPublicacao { get; }
        public string Fonte { get; set; }
        public Autor Autor { get; set; }
        public string Imagem { get; set; }
        public string Categoria { get; set; }
        public string Resumo { get; set; }
        public string Link { get; set; }

        public StatusPostEnum Status { get; set; }


        public Post()
        {
            Status = StatusPostEnum.Pendente;
        }

    }
}
