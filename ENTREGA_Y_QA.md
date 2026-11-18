# DevTrack | Entrega y pruebas de QA

## Ejecutar en Visual Studio

1. Si Windows muestra la opción Desbloquear en Propiedades del ZIP y confías en su origen, aplícala antes de extraerlo.
2. Extrae el ZIP y abre DevTrack.slnx. Se necesita el SDK de .NET 10.
3. Para presentar la versión del PDF, elige DevTrack.Web como proyecto de inicio y pulsa F5. Abre en el navegador la dirección local que indique Visual Studio o la consola.
4. Para abrir la versión de escritorio, elige DevTrack como proyecto de inicio. Para editar el acceso, haz clic derecho en Acceso.cs y selecciona Ver diseñador (Mayús+F7).
5. Ambos proyectos guardan sus datos por separado en archivos JSON. Escritorio usa %LOCALAPPDATA%\DevTrack\datos.json. Web usa %LOCALAPPDATA%\DevTrackWeb\datos.json.
6. La selección de rol es para una demostración local. Los roles restringen operaciones, pero el nombre y el rol los elige quien usa la aplicación.

## Requerimientos y estructuras demostrables

La versión web registra, consulta y edita proyectos; registra tareas con responsable, prioridad y fecha; permite iniciar una revisión, registrar un resultado de QA y consultar el avance por proyecto. Persiste proyectos y tareas en JSON.

- Listas: administran los registros de proyectos y tareas.
- Arreglos: reúnen los roles, prioridades y estados válidos.
- Búsqueda lineal: localiza proyectos y tareas por identificador con List.Find.
- Ordenamiento: presenta tareas por prioridad y, dentro de cada prioridad, por fecha de entrega.

## Guion para QA

Completa cada caso con fecha, responsable, resultado real y captura. Los resultados de abajo son los esperados.

| Caso | Pasos | Resultado esperado |
| --- | --- | --- |
| Acceso | Abrir la versión web e ingresar con nombre y rol | Se muestra el nombre y el rol activo |
| Proyecto y tarea | Como Líder crear un proyecto y una tarea con fecha y prioridad | El proyecto muestra una tarea pendiente |
| Permisos | Ingresar como Desarrollador y enviar la tarea a En revisión QA | Puede actualizar la tarea y no tiene el botón Registrar revisión |
| Revisión QA | Entrar como QA, elegir Error reportado, registrar una observación y guardar | Aparecen el rechazo y la observación |
| Aprobación | Como Desarrollador reenviar a revisión y como QA aprobar | Seguimiento muestra una tarea completada |
| Persistencia | Detener la web, iniciarla de nuevo y volver a ingresar | El proyecto, la tarea y el resultado de QA siguen presentes |
| Renombrado | Cambiar el nombre del proyecto | La tarea sigue vinculada y conserva su avance |
| Diseñador | Abrir Acceso.cs con Ver diseñador en el proyecto de escritorio | Los controles se pueden seleccionar y modificar |
