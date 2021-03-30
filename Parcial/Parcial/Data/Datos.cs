public class CEDULA
{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string FechaNacimiento { get; set; }
    public string LugarNacimiento { get; set; }
    public string foto { get; set; }
}

public class provincia
{
    public string NOMBRE { get; set; }
}

public class MENSAJE
{
    public string mensaje { get; set; }
}

public class ROBOS
{
    public int ID { get; set; }
    public string CEDULA { get; set; }
    public string NOMBRE { get; set; }
    public string APELLIDO { get; set; }
    public string LATITUD { get; set; }
    public string LONGITUD { get; set; }
}
