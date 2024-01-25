# WebTransportBackEnd

Proyecto Backend en el cual se administra el acceso a la informacion de las rutas,conductores vehiculos y calendario de la empresa

#Paquetes Requeridos
microsoft.aspnetcore.authentication.jwtbearer
microsoft.aspnetcore.components.quickgrid.entityframeworkadapter
microsoft.entityframeworkcore
microsoft.entityframeworkcore.sqlserver
microsoft.entityframeworkcore.tools
microsoft.visualstudio.web.codegeneration.design
swashbuckle.aspnetcore
system.identitymodel.tokens.jwt

#Configuracion 
Debe adaptar el archivo appsetting.json y especificar la cadena de conexion de su configuracion de su servidor sqlserver

en la seccion ConecctionString en la sub seccion CadenaSql
{
  "ConnectionStrings": {
    "CadenaSQL": "Server=(local); DataBase=dbtransporte;Integrated Security=true;TrustServerCertificate=True"},
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
  "AllowedHosts": "*",
  "settings": {
    "secretkey": "Pass123456**"
  }
}

