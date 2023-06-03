using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    internal class ClsPromedio
    {
        //Atributos
        #region atributos 
        private string condicion;
        private string color;
        private string promedio;

        public string Condicion { get => condicion; set => condicion = value; }
        public string Color { get => color; set => color = value; }
        public string Promedio { get => promedio; set => promedio = value; }
        #endregion
    }
}
