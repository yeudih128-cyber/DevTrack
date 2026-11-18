using System;
using System.Collections.Generic;

namespace DevTrack;

// Estructura de datos para almacenar la información de cada proyecto.
public class ProyectoDato
{
    public string Codigo { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public DateTime Inicio { get; set; }
    public DateTime Fin { get; set; }
    public string Estado { get; set; } = "";
}

// Estructura de datos para almacenar la información de cada tarea.
public class TareaDato
{
    public string Codigo { get; set; } = "";
    public string Titulo { get; set; } = "";
    public string Proyecto { get; set; } = "";
    public string Responsable { get; set; } = "";
    public string Prioridad { get; set; } = "";
    public DateTime Limite { get; set; }
    public string Estado { get; set; } = "Pendiente";
    public string Observacion { get; set; } = "";
    public string Resultado { get; set; } = "";
}

// Estructura de datos para los usuarios del sistema.
public class UsuarioDato
{
    public string Nombre { get; set; } = "";
    public string Rol { get; set; } = "";
}

public static partial class Almacen
{
    // Estructuras existentes para proyectos y tareas.
    public static List<ProyectoDato> Proyectos { get; } = new();
    public static List<TareaDato> Tareas { get; } = new();
    public static string[] EstadosTarea = { "Pendiente", "En desarrollo", "En revisión QA", "Aprobada", "Rechazada" };
    public static string[] Prioridades = { "Alta", "Media", "Baja" };
    public static string[] EstadosProyecto = { "Pendiente", "En desarrollo", "Finalizado" };

    // Estructuras adicionales: usuarios, roles, permisos y registro de actividad.
    public static List<UsuarioDato> Usuarios { get; } = new();
    public static string[] Roles = { "Administrador", "Líder", "Desarrollador", "QA" };
    public static Dictionary<string, HashSet<string>> PermisosPorRol { get; } = new()
    {
        ["Administrador"] = new HashSet<string> { "Proyectos", "CrearTareas", "ActualizarTareas", "EliminarTareas", "Calidad", "Seguimiento" },
        ["Líder"] = new HashSet<string> { "Proyectos", "CrearTareas", "ActualizarTareas", "EliminarTareas", "Seguimiento" },
        ["Desarrollador"] = new HashSet<string> { "ConsultarTareas", "ActualizarTareas", "Seguimiento" },
        ["QA"] = new HashSet<string> { "ConsultarTareas", "Calidad", "Seguimiento" }
    };
    public static List<string> RegistroActividad { get; } = new();

    public static event Action? Cambios;

    public static void Registrar(string mensaje)
    {
        RegistroActividad.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {Sesion.UsuarioActual?.Nombre ?? "Sistema"}: {mensaje}");
        try
        {
            Guardar();
        }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException)
        {
            MessageBox.Show("El cambio sigue en memoria. No se pudo guardar en disco: " + error.Message,
                "DevTrack", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        Cambios?.Invoke();
    }
}

// Mantiene el usuario que inició la sesión y comprueba sus permisos.
public static class Sesion
{
    public static UsuarioDato? UsuarioActual { get; private set; }

    public static void Iniciar(string nombre, string rol)
    {
        UsuarioActual = new UsuarioDato { Nombre = nombre.Trim(), Rol = rol };
        if (!Almacen.Usuarios.Exists(u => u.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase) && u.Rol == rol))
            Almacen.Usuarios.Add(UsuarioActual);
        Almacen.Registrar("Inicio de sesión con rol " + rol);
    }

    public static bool TienePermiso(string permiso)
    {
        if (UsuarioActual == null) return false;
        return Almacen.PermisosPorRol.TryGetValue(UsuarioActual.Rol, out var permisos)
            && permisos.Contains(permiso);
    }
}

