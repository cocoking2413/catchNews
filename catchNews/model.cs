using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catchNews {
	public class model {


	}

	public class Channel {
		public string id { get; set; }
		public string channel { get; set; }
	}

	public class urlParam {
		public int id { get; set; }
		public string url { get; set; }
		public string param { get; set; }
	}
    public class myEnum
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// PermissionName
        /// </summary>
        public string PermissionName { get; set; }
        /// <summary>
        /// PermissionkeyName
        /// </summary>
        public string PermissionkeyName { get; set; }

    }
}
