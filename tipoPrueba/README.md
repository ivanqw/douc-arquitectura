## Importante

| Capas | Descripcion |
| ------------------- | ----------------------------------------------------- |
| **CapaConexion**    | Encargada de realizar la conexion a la base de datos |
| **CapaEscritorio**  | Aplicacion de escritorio, es quien contiene la clase `main` |
| **CapaModelo**      | Contiene las clases que se conectan a la base de datos (cada clase es una tabla) |
| **CapaNegocio**     | Realiza los `select` `insert` `update`, etc... |

para ejecutar el programa en visual estudio es necesario **Establecer como proyecto de inicio** la **CapaEscritorio**
