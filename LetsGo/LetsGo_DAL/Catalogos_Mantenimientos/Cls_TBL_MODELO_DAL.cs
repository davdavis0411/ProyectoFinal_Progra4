namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_MODELO_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bID_Modelo; private byte _bID_Marca; private string _sModelo;

        public byte BID_Modelo
        {
            get
            {
                return _bID_Modelo;
            }

            set
            {
                _bID_Modelo = value;
            }
        }

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

        public string SModelo
        {
            get
            {
                return _sModelo;
            }

            set
            {
                _sModelo = value;
            }
        }
        #endregion
    }
}
