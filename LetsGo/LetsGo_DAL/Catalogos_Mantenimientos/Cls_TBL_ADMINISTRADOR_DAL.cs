namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_ADMINISTRADOR_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Administrador; private int _iID_Cuenta; private byte _bID_Estado; private int _iID_Cedula_Juridica;

        public int IID_Administrador
        {
            get
            {
                return _iID_Administrador;
            }

            set
            {
                _iID_Administrador = value;
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

        public int IID_Cedula_Juridica
        {
            get
            {
                return _iID_Cedula_Juridica;
            }

            set
            {
                _iID_Cedula_Juridica = value;
            }
        }
        #endregion
    }
}
