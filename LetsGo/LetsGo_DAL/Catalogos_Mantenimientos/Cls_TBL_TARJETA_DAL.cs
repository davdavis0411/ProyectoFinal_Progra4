using System;

namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_TARJETA_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private Int64 _IID_Numero_Tarjeta; private byte _bID_Tipo_Tarjeta; private byte _bID_Banco; private Int64 _INumero_Cuenta; private byte _bCVV;

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

        public byte BID_Tipo_Tarjeta
        {
            get
            {
                return _bID_Tipo_Tarjeta;
            }

            set
            {
                _bID_Tipo_Tarjeta = value;
            }
        }

        public byte BID_Banco
        {
            get
            {
                return _bID_Banco;
            }

            set
            {
                _bID_Banco = value;
            }
        }

        public long INumero_Cuenta
        {
            get
            {
                return _INumero_Cuenta;
            }

            set
            {
                _INumero_Cuenta = value;
            }
        }

        public byte BCVV
        {
            get
            {
                return _bCVV;
            }

            set
            {
                _bCVV = value;
            }
        }
        #endregion
    }
}
