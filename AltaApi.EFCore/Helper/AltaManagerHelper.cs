using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.Helper
{
    public class AltaManagerHelper
    {
        /// <summary>
        /// TRANDT
        /// </summary>
        /// <returns></returns>
        public static string GetDateTimeNow()
        {
            DateTime now = DateTime.Now;
            StringBuilder _builder = new StringBuilder();
            _builder.Append(now.Year);
            if (now.Month <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Month);
            if (now.Day <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Day);
            if (now.Hour <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Hour);
            if (now.Minute <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Minute);
            if (now.Second <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Second);


            while (_builder.Length < 14)
            {
                _builder.Append('0');
            }

            return _builder.ToString();
        }

        /// <summary>
        /// TRANID
        /// </summary>
        /// <returns></returns>
        public static string GetDateTimeNowWithMiliseconds()
        {
            DateTime now = DateTime.Now;
            StringBuilder _builder = new StringBuilder();
            if (now.Month <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Month);
            if (now.Day <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Day);
            if (now.Hour <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Hour);
            if (now.Minute <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Minute);
            if (now.Second <= 9)
            {
                _builder.Append('0');
            }
            _builder.Append(now.Second);
            _builder.Append(now.Millisecond);

            while (_builder.Length < 18)
            {
                _builder.Append('0');
            }

            return _builder.ToString();
        }
    }
}
