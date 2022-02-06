using System;

namespace Composite
{
    class FileTreatmentException : Exception
    {

        // コンストラクタ
        public FileTreatmentException() : base()
        {
        }

        // コンストラクタ
        public FileTreatmentException(string message) : base(message)
        {
        }

        // コンストラクタ
        public FileTreatmentException(string message, Exception innnerException) : base(message, innnerException)
        {
        }
    }
}