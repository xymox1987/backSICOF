# Entity Framework Migracion
## Generar Migracion

dotnet ef --startup-project SICOFAPI migrations add MigracionInicial -c DataBaseContext

## Generar Script en carpeta Documentacion

dotnet ef migrations script --project SICOFAPI -o documentacion/01_scriptInicial.sql

# EndPoint Versiones
https://localhost:44367/api/GestionVersion/ConsultarVersionSICOF

# restaurar sql por cmd

1. en una terminal de CMD , ejecutar el siguiente comando . 

~~~
  sqlcmd -S localhost -U sa -i X:\SICOF\backSICOF\documentacion\01_scriptInicial.sql
~~~

