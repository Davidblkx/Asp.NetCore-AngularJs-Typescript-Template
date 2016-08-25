using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore_AngularJs_Typescript_VS2015_Template.Model
{
    public class ModelLogin
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public bool IsPersistent { get; set; }
        public string ReturnUrl { get; set; }
    }
}
