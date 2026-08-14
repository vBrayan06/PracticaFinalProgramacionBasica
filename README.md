# Sistema de Gestión de Pacientes

## Integrantes

* **[Nombre completo del integrante 1]** — Matrícula: **[Matrícula]**
* **[Nombre completo del integrante 2]** — Matrícula: **[Matrícula]**

## Descripción

Este proyecto consiste en un sistema sencillo para la gestión de pacientes de una clínica.

La aplicación fue desarrollada en C# utilizando Windows Forms. El programa permite registrar pacientes, mostrar todos los pacientes registrados, buscar por cédula o nombre, actualizar sus datos y eliminar pacientes.

La información se guarda temporalmente en una lista mientras el programa está abierto, por lo que no se utiliza una base de datos.

## Datos de entrada

Los datos que se introducen en el sistema son:

* Cédula del paciente.
* Nombre completo.
* Edad.
* Sexo.
* Diagnóstico.
* Estado del paciente.
* Fecha de ingreso.

Para el sexo y el estado del paciente se utilizan opciones previamente definidas mediante enumeraciones.

## Datos que procesa el programa

El programa realiza diferentes operaciones con la información de los pacientes.

Entre ellas se encuentran:

* Validación de campos obligatorios.
* Validación de que la edad sea un número válido.
* Verificación de que no existan dos pacientes con la misma cédula.
* Búsqueda de pacientes por cédula.
* Búsqueda de pacientes por nombre.
* Actualización de la información de un paciente.
* Eliminación de pacientes.
* Manejo de errores mediante excepciones.
* Uso de una excepción personalizada cuando no se encuentra un paciente.
* Almacenamiento de los pacientes mediante una lista dinámica.

## Datos de salida

Los resultados se muestran principalmente mediante los formularios del programa.

Los pacientes registrados pueden visualizarse en un DataGridView, donde se muestran datos como la cédula, nombre, edad, sexo, diagnóstico, estado y fecha de ingreso.

También se utilizan MessageBox para mostrar mensajes de confirmación, advertencias y errores, por ejemplo cuando:

* Un paciente se registra correctamente.
* Se intenta registrar una cédula que ya existe.
* Se deja un campo obligatorio vacío.
* La edad introducida no es válida.
* No se encuentra un paciente.
* Se actualiza un paciente.
* Se elimina un paciente.
* Se pide confirmación antes de eliminar.

## Funcionalidades principales

El sistema cuenta con las siguientes opciones:

1. Registrar un nuevo paciente.
2. Listar todos los pacientes.
3. Buscar pacientes por cédula o nombre.
4. Actualizar los datos de un paciente.
5. Eliminar un paciente.
6. Salir del sistema.

## Estructura general del programa

El proyecto está dividido principalmente en:

* **Paciente:** representa la información de cada paciente.
* **GestorPacientes:** se encarga de guardar y administrar la lista de pacientes.
* **PacienteNoEncontradoException:** excepción personalizada utilizada cuando no se encuentra un paciente.
* **Menú principal:** permite entrar a las diferentes funciones del sistema.
* **Formulario de registro:** permite agregar pacientes.
* **Formulario de búsqueda:** permite buscar por cédula o nombre.
* **Formulario de listado:** muestra todos los pacientes.
* **Formulario de actualización:** permite buscar y modificar los datos de un paciente.
* **Formulario de eliminación:** permite buscar y eliminar un paciente con confirmación previa.

## Capturas de pantalla

En esta sección se deben colocar las capturas del programa funcionando.

### Menú principal

**[captura del menú principal]**

### Registro de paciente

**[captura registrando un paciente]**

### Listado de pacientes

**[captura de la lista de pacientes]**

### Búsqueda de paciente

**[captura de una búsqueda por cédula o nombre]**

### Actualización de paciente

**[captura actualizando los datos de un paciente]**

### Eliminación de paciente

**[captura de la eliminación y su mensaje de confirmación]**

### Validaciones

**[una o varias capturas mostrando mensajes de error o advertencia]**

## Tecnologías utilizadas

* C#
* Windows Forms
* .NET
* Visual Studio
* Git y GitHub

## Nota

Los pacientes se almacenan solamente mientras el programa está en ejecución. Al cerrar completamente la aplicación, la información de la lista se pierde porque el proyecto utiliza almacenamiento temporal en memoria.
