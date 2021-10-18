using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Central
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Central()
        {
            this.listaDeLlamadas = new List<Llamada>(); 
        }
        public Central(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciaPorLocal
        {
            get 
            {
                return CalcularGanancia(TipoLlamada.Local); 
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial); 
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas; 
            }
        }
        private void AgregarLlamada(Llamada nuveaLlamada)
        {
            this.Llamadas.Add(nuveaLlamada); 
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0; 
            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada; 
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                        else 
                        {
                            if (item is Provincial)
                            {
                                ganancia += ((Provincial)item).CostoLlamada;
                            }
                        }
                        break;
                }
            }
            return ganancia; 
        }
        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Razon Social: {this.razonSocial}, Ganancia total: {this.GananciaPorTotal}, " +
                                 $"Ganacia por Locales: {this.GananciaPorLocal}, " +
                                 $"Ganancia por Provinciales: {this.GananciaPorProvincial}");
            foreach (Llamada item in this.Llamadas)
            {
                stringBuilder.AppendLine(item.ToString()); 
            }

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion); 
        }
        public static bool operator ==(Central c, Llamada llamada)
        {
            bool rta = false;
            if (!(c is null) && !(llamada is null))
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if (item == llamada)
                    {
                        rta = true;
                        break;
                    }
                } 
            }
            return rta;
        }
        public static bool operator !=(Central c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Central operator +(Central c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada); 
            }
            return c; 
        }

    }
}
