using System;
using System.Collections.Generic;
using System.Text;

namespace Agamin.Core.Models
{
    public class ResetPasswordModel
    {
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
