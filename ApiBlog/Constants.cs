using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBlog
{
    class Constants
    {
        public const string ErrorNames = "Debe ingresar nombre";
        public const string ErrorSurnames = "Debe ingresar Apellido";
        public const string ErrorEmail = "Debe ingresar un correo valido";
        public const int MaxLengthPassword = 18;
        public const int MinLengthPassword = 6;
        public const string ErrorTitle = "Debe ingresar titulo";
        public const string ErrorKeyword = "Debe ingresar palabras claves";
        public const string ErrorContent = "Debe ingresar contenido";

        public const string ConnectionStringsDB = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public enum StatusUser { activo, bloqueado, pendiente };
    }
}
