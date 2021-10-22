using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.Domain
{
    public class ErrorMessages
    {
        public const string ErrorNames = "Debe ingresar nombre";
        public const string ErrorSurnames = "Debe ingresar Apellido";
        public const string ErrorEmail = "Debe ingresar un correo valido";
        public const int MaxLengthPassword = 18;
        public const int MinLengthPassword = 6;
        public const string ErrorTitle = "Debe ingresar titulo";
        public const string ErrorKeyword = "Debe ingresar palabras claves";
        public const string ErrorContent = "Debe ingresar contenido";
    }

    public enum StatusUser { activo, bloqueado, pendiente };
}
