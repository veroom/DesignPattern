using System;

namespace Visitor
{
    /// <summary>
    /// 例外処理のクラス
    /// </summary>
    class FileTreatmentExceprion:Exception
    {
        public FileTreatmentExceprion()
        {
        }

        public FileTreatmentExceprion(string msg) : base(msg)
        {
        }
    }
}
