using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace npoiTest {
	public class Log {
		private static ILog log = LogManager.GetLogger("myLogger");

		public static void WriteLog(string str) {
			if ( log.IsDebugEnabled ) {
				log.Debug(str);
			}
		}
	}
}
