namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_MARCA_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bID_Marca; private string _sDescripcion;

        public byte BID_Marca
        {
            get
            {
                return _bID_Marca;
            }

            set
            {
                _bID_Marca = value;
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
