using System.Collections.Generic;

namespace inovayt.Models
{
    public class Users
    {
        public IList<VMUser> users { get; set; }
        public IList<Asset> assets { get; set; }
    }
}
