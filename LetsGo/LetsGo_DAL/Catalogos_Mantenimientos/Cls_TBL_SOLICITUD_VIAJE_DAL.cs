namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_SOLICITUD_VIAJE_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sID_Solicitud_Viaje; private int _iID_Cliente; private byte _bID_Tipo_Vehiculo; private string _sRuta_Inicial; private string _sRuta_Final; private decimal _dCantidad_Km; private decimal _dCosto_Inicial;

        public short SID_Solicitud_Viaje
        {
            get
            {
                return _sID_Solicitud_Viaje;
            }

            set
            {
                _sID_Solicitud_Viaje = value;
            }
        }

        public int IID_Cliente
        {
            get
            {
                return _iID_Cliente;
            }

            set
            {
                _iID_Cliente = value;
            }
        }

        public byte BID_Tipo_Vehiculo
        {
            get
            {
                return _bID_Tipo_Vehiculo;
            }

            set
            {
                _bID_Tipo_Vehiculo = value;
            }
        }

        public string SRuta_Inicial
        {
            get
            {
                return _sRuta_Inicial;
            }

            set
            {
                _sRuta_Inicial = value;
            }
        }

        public string SRuta_Final
        {
            get
            {
                return _sRuta_Final;
            }

            set
            {
                _sRuta_Final = value;
            }
        }

        public decimal DCantidad_Km
        {
            get
            {
                return _dCantidad_Km;
            }

            set
            {
                _dCantidad_Km = value;
            }
        }

        public decimal DCosto_Inicial
        {
            get
            {
                return _dCosto_Inicial;
            }

            set
            {
                _dCosto_Inicial = value;
            }
        }
        #endregion
    }
}
