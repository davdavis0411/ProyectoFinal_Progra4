namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_TIPO_VEHICULO_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bID_Tipo_Vehiculo; private string _sDescripcion;

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
