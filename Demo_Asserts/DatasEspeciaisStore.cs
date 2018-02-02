using System;

namespace Demo_Asserts
{
    public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch (datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    return new DateTime(2017, 1, 1, 0, 0, 0);

                case DatasEspeciais.AniversarioRioJaneiro:
                        return new DateTime(2017, 1, 21, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(datasEspeciais));
            }
        }
    }
}