namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_DETALLE_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Detalle; private int _iID_Encabezado; private int _iID_Comision; private decimal _dTotal;

        public int IID_Detalle
        {
            get
            {
                return _iID_Detalle;
            }

            set
            {
                _iID_Detalle = value;
            }
        }

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

        public int IID_Comision
        {
            get
            {
                return _iID_Comision;
            }

            set
            {
                _iID_Comision = value;
            }
        }

        public decimal DTotal
        {
            get
            {
                return _dTotal;
            }

            set
            {
                _dTotal = value;
            }
        }
        #endregion
    }
}
