namespace LetsGo_DAL.Catalogos_Mantenimientos
{
    public class Cls_TBL_VEHICULO_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bID_Vehiculo; private byte _bID_Modelo; private string _sMatricula; private int _iANNO;

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

        public string SMatricula
        {
            get
            {
                return _sMatricula;
            }

            set
            {
                _sMatricula = value;
            }
        }

        public int IANNO
        {
            get
            {
                return _iANNO;
            }

            set
            {
                _iANNO = value;
            }
        }
        #endregion
    }
}
