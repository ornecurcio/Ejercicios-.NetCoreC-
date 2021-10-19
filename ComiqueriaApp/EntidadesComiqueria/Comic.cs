using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComiqueria
{
    public class Comic:Producto
    {
        public enum TipoComic { Occidental, Oriental }

        TipoComic tipoComic;
        string autor;
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) :
                        base(descripcion, stock, precio)
        {
            this.autor=autor;
            this.tipoComic = tipoComic; 
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine(""); 
            stringBuilder.AppendLine($"Autor: {this.autor}");
            stringBuilder.AppendLine($"Tipo Comic: {this.tipoComic}");

            return stringBuilder.ToString();
        }
    }
}
