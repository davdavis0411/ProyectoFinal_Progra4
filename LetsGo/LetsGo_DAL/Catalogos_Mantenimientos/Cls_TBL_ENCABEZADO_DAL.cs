using System;

namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_ENCABEZADO_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Encabezado; private DateTime _DFecha; private int _iID_Viaje;

        public int IID_Encabezado
        {
            get
            {
                return _iID_Encabezado;
            }

            set
            {
                _iID_Encabezado = value;
            }
        }

        public DateTime DFecha
        {
            get
            {
                return _DFecha;
            }

            set
            {
                _DFecha = value;
            }
        }

        public int IID_Viaje
        {
            get
            {
                return _iID_Viaje;
            }

            set
            {
                _iID_Viaje = value;
            }
        }
        #endregion
    }
}
