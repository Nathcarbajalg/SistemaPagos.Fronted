using System;
using System.IO;
using System.Text.Json;

namespace SistemaPagos.Fronted
{
    public static class SesionHelper
    {
        private static string ArchivoSesion => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SistemaPagos",
            "sesion.json");

        public static void GuardarSesion(string identificacion, string rol, string nombre, DateTime expiracion)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ArchivoSesion)!);
            var data = new { Identificacion = identificacion, Rol = rol, Nombre = nombre, Expiracion = expiracion };
            File.WriteAllText(ArchivoSesion, JsonSerializer.Serialize(data));
        }

        public static (string? Id, string? Rol, string? Nombre, DateTime? Exp) CargarSesion()
        {
            if (!File.Exists(ArchivoSesion)) return (null, null, null, null);
            var json = File.ReadAllText(ArchivoSesion);
            var data = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            if (data != null && data.ContainsKey("Identificacion"))
            {
                return (data["Identificacion"].ToString(),
                        data["Rol"].ToString(),
                        data["Nombre"].ToString(),
                        DateTime.Parse(data["Expiracion"].ToString()!));
            }
            return (null, null, null, null);
        }

        public static void EliminarSesion()
        {
            if (File.Exists(ArchivoSesion)) File.Delete(ArchivoSesion);
        }
    }
}