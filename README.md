# Sistema de Gestión de Pacientes

## Integrantes

* **Brayan Mateo Guerrero** — Matrícula: **2025-0224**
* **Michael Alberto Campechano Cueto** — Matrícula: **2025-0254**

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

En esta sección están las capturas del programa funcionando.

### Menú principal

<img width="738" height="537" alt="image" src="https://github.com/user-attachments/assets/aa48b2ab-a96a-4830-aa5d-e106323abec4" />

### Registro de paciente

<img width="680" height="674" alt="image" src="https://github.com/user-attachments/assets/39d02d96-002c-4497-a608-56c9cbbd3e47" />
<img width="628" height="637" alt="image" src="https://github.com/user-attachments/assets/0a5efb87-73e0-43b8-a40e-0bf9fc3a4efc" />
<img width="636" height="638" alt="image" src="https://github.com/user-attachments/assets/f2620d41-caca-4c99-9cb5-527acb8a6c71" />



### Listado de pacientes

<img width="994" height="771" alt="image" src="https://github.com/user-attachments/assets/f82ac9aa-e9f4-4983-9b34-3c2c500176e2" />


### Búsqueda de paciente

<img width="1030" height="617" alt="image" src="https://github.com/user-attachments/assets/9e2fddef-4b06-426b-98b2-c43f35da08a8" />
<img width="1032" height="607" alt="image" src="https://github.com/user-attachments/assets/7eea7002-1242-44d9-80bf-7c734f31d586" />
<img width="1009" height="628" alt="image" src="https://github.com/user-attachments/assets/fa7a512f-5aa1-4020-878a-7c04d884e642" />


### Actualización de paciente

<img width="669" height="806" alt="image" src="https://github.com/user-attachments/assets/25e8b5f3-13aa-4ba1-a389-c4e1b767531a" />
<img width="638" height="765" alt="image" src="https://github.com/user-attachments/assets/944029a5-80bc-4a3b-81d7-ad122123b0a4" />
<img width="688" height="793" alt="image" src="https://github.com/user-attachments/assets/2d6d0acc-095c-41da-848f-178008838401" />
<img width="668" height="779" alt="image" src="https://github.com/user-attachments/assets/ee8add41-d11d-4a46-9d99-17c37167b07d" />
<img width="1029" height="794" alt="image" src="https://github.com/user-attachments/assets/eaa1db00-3de0-4718-ba83-956ffce6ad93" />

### Eliminación de paciente

<img width="690" height="614" alt="image" src="https://github.com/user-attachments/assets/e975ada3-1681-4be1-a768-6dcfe483c7f7" />
<img width="694" height="619" alt="image" src="https://github.com/user-attachments/assets/82103be0-a1e7-4117-aeed-1e0e914473fd" />
<img width="1009" height="797" alt="image" src="https://github.com/user-attachments/assets/e7a06930-a0f7-487d-91dd-c7281757bf40" />


## Tecnologías utilizadas

* C#
* Windows Forms
* .NET
* Visual Studio
* Git y GitHub

## Nota

Los pacientes se almacenan solamente mientras el programa está en ejecución. Al cerrar completamente la aplicación, la información de la lista se pierde porque el proyecto utiliza almacenamiento temporal en memoria.
