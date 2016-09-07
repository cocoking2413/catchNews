using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codeTemplate
{
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

    public class dbList {
        public int ID { get; set; }
        public string Name { get; set; }
        public string connectStr { get; set; }
    }
}
