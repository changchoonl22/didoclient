using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoginNRegister
{
    class Register
    {
        public Register(String txtId, String txtPwd)
        {
            id = txtId;
            pwd = txtPwd;
        }
        public String id { get; set; }

        public String pwd { get; set; }
    }
}
