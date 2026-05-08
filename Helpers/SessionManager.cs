using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Assessment_2.Models;

namespace IT_Assessment_2.Helpers
{
    public class SessionManager
    {

        public Staff? => _CurrentUser;

        public static Staff? _CurrentUser => _CurrentUser;

        public bool IsLoggedIn { get; set; }

        


    }
}
