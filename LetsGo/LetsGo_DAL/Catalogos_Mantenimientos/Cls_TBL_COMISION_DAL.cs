namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_COMISION_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iID_Comision; private byte _bComision; private string _sDescripcion;

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

        public byte BComision
        {
            get
            {
                return _bComision;
            }

            set
            {
                _bComision = value;
            }
        }

        public string SDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }
        #endregion
    }
}
