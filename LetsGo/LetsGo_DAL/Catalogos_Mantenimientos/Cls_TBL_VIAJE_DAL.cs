namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_VIAJE_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Viaje; private int _iID_Conductor; private short _sID_Solicitud_Viaje; private byte _bID_Estado;

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
        #endregion
    }
}
