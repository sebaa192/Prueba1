namespace apiPOO
{

    public record EmpleadoDTO(int codEmpleado, string Nombre, string Apellido, int codJefe,int idcargo);
    public record RegionDTO(int codigoRegion, string nombreRegion);
    public record JefeDTO(int codJefe, string nombre);
    public record CargoDTO(int idcargo,string nombrecargo);
    public record SucursalDTO(int codigoSucursal, string nombre, int codigoRegion);
    public record DepartamentoDTO(int codigodepa, string nombredepa, int codJefe, int codigoSucursal);
    
    


}
