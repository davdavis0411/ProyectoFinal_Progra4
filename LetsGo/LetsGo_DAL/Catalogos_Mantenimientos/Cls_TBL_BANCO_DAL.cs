namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_BANCO_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bID_Banco; private string _sNombre_Banco;

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

        public string SNombre_Banco
        {
            get
            {
                return _sNombre_Banco;
            }

            set
            {
                _sNombre_Banco = value;
            }
        }
        #endregion
    }
}
