namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_CONDUCTOR_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Conductor; private int _iID_Cuenta; private byte _bID_Estado; private byte _bID_Vehiculo;

        public int IID_Conductor
        {
            get
            {
                return _iID_Conductor;
            }

            set
            {
                _iID_Conductor = value;
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

        public byte BID_Vehiculo
        {
            get
            {
                return _bID_Vehiculo;
            }

            set
            {
                _bID_Vehiculo = value;
            }
        }
        #endregion
    }
}
