using System;

namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_CLIENTE_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Cliente; private int _iID_Cuenta; private byte _bID_Estado; private Int64 _IID_Numero_Tarjeta;

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

        public int IID_Cuenta
        {
            get
            {
                return _iID_Cuenta;
            }

            set
            {
                _iID_Cuenta = value;
            }
        }

        public byte BID_Estado
        {
            get
            {
                return _bID_Estado;
            }

            set
            {
                _bID_Estado = value;
            }
        }

        public long IID_Numero_Tarjeta
        {
            get
            {
                return _IID_Numero_Tarjeta;
            }

            set
            {
                _IID_Numero_Tarjeta = value;
            }
        }
        #endregion
    }
}
