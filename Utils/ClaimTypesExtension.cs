using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public static class ClaimTypesExtension
    {
        public static int ObterUsuarioId(this ClaimsPrincipal user)// método modificado!!!
        {
            var id = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
            return int.Parse(id);
        }

        
    }
}