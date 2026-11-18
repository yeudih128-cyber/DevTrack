using System.Text.Json;

namespace DevTrack;

public sealed class DatosGuardados
{
    public List<ProyectoDato> Proyectos { get; set; } = new();
    public List<TareaDato> Tareas { get; set; } = new();
    public List<UsuarioDato> Usuarios { get; set; } = new();
    public List<string> RegistroActividad { get; set; } = new();
}

public static partial class Almacen
{
    private static readonly string Archivo = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "DevTrack", "datos.json");

    public static void Cargar()
    {
        if (!File.Exists(Archivo))
            return;

        var datos = JsonSerializer.Deserialize<DatosGuardados>(File.ReadAllText(Archivo))
            ?? throw new JsonException("El archivo de datos está vacío.");
        Proyectos.AddRange(datos.Proyectos);
        Tareas.AddRange(datos.Tareas);
        Usuarios.AddRange(datos.Usuarios);
        RegistroActividad.AddRange(datos.RegistroActividad);
    }

    public static void Guardar()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(Archivo)!);
        string temporal = Archivo + "." + Guid.NewGuid().ToString("N") + ".tmp";
        var datos = new DatosGuardados
        {
            Proyectos = Proyectos,
            Tareas = Tareas,
            Usuarios = Usuarios,
            RegistroActividad = RegistroActividad
        };
        try
        {
            File.WriteAllText(temporal, JsonSerializer.Serialize(datos));
            File.Move(temporal, Archivo, overwrite: true);
        }
        finally
        {
            if (File.Exists(temporal))
                File.Delete(temporal);
        }
    }
}
