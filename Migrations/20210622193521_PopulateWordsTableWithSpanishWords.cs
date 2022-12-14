using Microsoft.EntityFrameworkCore.Migrations;

namespace Translator_app.Migrations
{
    public partial class PopulateWordsTableWithSpanishWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Word",
            columns: new[] { "TextId", "Text", "LanguageId" },
            values: new object[,] {
                {"1","Nombre del titular de la cuenta", "ES"},
                {"2","Contabilidad y Finanzas", "ES"},
                {"3","Activo", "ES"},
                {"4","Agregar nueva tarifa", "ES"},
                {"5","Agregar nuevo comentario", "ES"},
                {"6","Agregar nueva entrada", "ES"},
                {"7","Agregar nuevo proveedor", "ES"},
                {"8","Asignaciones adicionales del editor/ Administración", "ES"},
                {"9","Administración", "ES"},
                {"10","Manejo de pagos publicitarios", "ES"},
                {"11","Agencia", "ES"},
                {"12","Cuenta de Alipay", "ES"},
                {"13","Análisis", "ES"},
                {"14","Anuncios", "ES"},
                {"15","Cierre anual, declaración de impuestos y auditoría", "ES"},
                {"16","Comentarios de la revisión anual", "ES"},
                {"17","Id. De administrador de Apollo: Data Quality", "ES"},
                {"18","ID de administrador de Apollo: Resource", "ES"},
                {"19","Aplicar pagos en Caspian", "ES"},
                {"20","Seguimiento de IA", "ES"},
                {"21","Informe automatizado", "ES"},
                {"22","Bamboo", "ES"},
                {"23","Número de cuenta bancaria", "ES"},
                {"24","Dirección del banco", "ES"},
                {"25","Nombre del banco", "ES"},
                {"26","BI - Ayudar a otro departamento", "ES"},
                {"27","BI - Asistencia otras oficinas", "ES"},
                {"28","BI - Diseño, Ilustraciones, Maquetación gráfica, CSS", "ES"},
                {"29","BI - Archivos de soluciones de desarrollo", "ES"},
                {"30","BI - Análisis específicos (Nivel, Ruta, Costo, etc.)", "ES"},
                {"31","Facturación", "ES"},
                {"32","Soporte BR", "ES"},
                {"33","Nombre / Id. De sucursal", "ES"},
                {"34","Funciones de Bravo", "ES"},
                {"35","Usuario Bravo", "ES"},
                {"36","Preparación del presupuesto", "ES"},
                {"37","Administración de Empresas", "ES"},
                {"38","Llamar a nuevos compradores", "ES"},
                {"39","Llamadas: compradores", "ES"},
                {"40","Llamadas / reuniones - Cliente, SM", "ES"},
                {"41","Llamadas / reuniones - Internas", "ES"},
                {"42","Llamadas de proveedores de publicidad", "ES"},
                {"43","Llamadas de correos electrónicos", "ES"},
                {"44","Cancelar", "ES"},
                {"45","Previsión de efectivo", "ES"},
                {"46","Caspian", "ES"},
                {"47","Caspian (ingresar, administrar clientes potenciales)", "ES"},
                {"48","Usuarios de la oficina del Caspian", "ES"},
                {"49","Usuario principal de Caspian", "ES"},
                {"50","Roles del Caspian", "ES"},
                {"51","Solicitudes de cambio", "ES"},
                {"52","Elige uno ...", "ES"},
                {"53","Soporte CL", "ES"},
                {"54","Cliente", "ES"},
                {"55","Creación y seguimiento del acuerdo con el cliente", "ES"},
                {"56","Comunicación con el cliente", "ES"},
                {"57","Informes de Excel del cliente", "ES"},
                {"58","Comunicación relacionada con el cliente", "ES"},
                {"59","Informes de clientes", "ES"},
                {"60","Cliente / prospecto - seguimiento", "ES"},
                {"61","Reunión cliente / prospecto", "ES"},
                {"62","Soporte CN", "ES"},
                {"63","Llamadas en frío", "ES"},
                {"64","Comentario", "ES"},
                {"65","Comentario:", "ES"},
                {"66","Comentarios", "ES"},
                {"67","Nombre de empresa", "ES"},
                {"68","El contrato finaliza", "ES"},
                {"69","Fecha de vencimiento del contrato", "ES"},
                {"70","Copiar", "ES"},
                {"71","Coste, RFP", "ES"},
                {"72","Códigos de país ...", "ES"},
                {"73","Crear nuevo proveedor", "ES"},
                {"74","Creado", "ES"},
                {"75","Creando propuesta de cliente", "ES"},
                {"76","Creación de procesos / procedimientos", "ES"},
                {"77","Ingreso de memos de crédito/aprovando", "ES"},
                {"78","Soporte transversal departamental - BI", "ES"},
                {"79","Soporte interdepartamental - DQ", "ES"},
                {"80","Apoyo interdepartamental: finanzas", "ES"},
                {"81","Apoyo interdepartamental - RRHH", "ES"},
                {"82","Soporte interdepartamental: TI", "ES"},
                {"83","Soporte transversal departamental - KAM", "ES"},
                {"84","Soporte interdepartamental - MKTG", "ES"},
                {"85","Soporte interdepartamental - RM", "ES"},
                {"86","Soporte transversal departamental - Ventas", "ES"},
                {"87","Divisa", "ES"},
                {"88","Verificación de datos en Excel", "ES"},
                {"89","Limpieza, verificación y comparación de datos", "ES"},
                {"90","Fecha", "ES"},
                {"91","Borrar", "ES"},
                {"92","Departamento", "ES"},
                {"93","Supervisor DQ", "ES"},
                {"94","Editar", "ES"},
                {"95","Editar entrada de parte de horas", "ES"},
                {"96","Edición de informes (edición de primera línea)", "ES"},
                {"97","Asignaciones de editor", "ES"},
                {"98","Facturación del editor", "ES"},
                {"99","Correo electrónico", "ES"},
                {"100","Correo electrónico", "ES"},
                {"101","Control de asistencia de los empleados", "ES"},
                {"102","Pago de beneficios para empleados", "ES"},
                {"103","Comentarios de los empleados", "ES"},
                {"104","Final", "ES"},
                {"105","Fecha final:", "ES"},
                {"106","Hora de finalización:", "ES"},
                {"107","Introducción de datos en el software de contabilidad", "ES"},
                {"108","La entrada se superpone a una entrada existente:", "ES"},
                {"109","Apoyo de la UE", "ES"},
                {"110","Exportar", "ES"},
                {"111","Tarifa", "ES"},
                {"112","Tipo de tarifa", "ES"},
                {"113","Tarifa", "ES"},
                {"114","Socio de trabajo de campo", "ES"},
                {"115","Primer nombre", "ES"},
                {"116","Primer nombre", "ES"},
                {"117","Seguimiento", "ES"},
                {"118","Viernes", "ES"},
                {"119","Nivel completo", "ES"},
                {"120","Trabajo grupal global de lucha contra el fraude", "ES"},
                {"121","Soporte global", "ES"},
                {"122","Asistencia sanitaria", "ES"},
                {"123","Ocultar comentario nuevo", "ES"},
                {"124","Contratación / Entrevista", "ES"},
                {"125","Contratación / Proceso de incorporación", "ES"},
                {"126","Gestión Hold-A", "ES"},
                {"127","Gestión de Hold-B", "ES"},
                {"128","Casa", "ES"},
                {"129","Código IBAN / Número de cuenta bancaria", "ES"},
                {"130","ID", "ES"},
                {"131","En apoyo", "ES"},
                {"132","Usuario independiente", "ES"},
                {"133","Comunicación interna", "ES"},
                {"134","Consultas internas", "ES"},
                {"135","Informes internos", "ES"},
                {"136","Comunicación entre oficinas", "ES"},
                {"137","Facturación", "ES"},
                {"138","Comunicación IO", "ES"},
                {"139","Es socio de trabajo de campo", "ES"},
                {"140","IsAgency?", "ES"},
                {"141","Tareas de IT_Admin", "ES"},
                {"142","Supervisor de KAM", "ES"},
                {"143","Cálculo de KPI", "ES"},
                {"144","Último acceso", "ES"},
                {"145","Apellido", "ES"},
                {"146","Apellido", "ES"},
                {"147","Investigación principal", "ES"},
                {"148","Enumerar las entradas de la hoja de horas", "ES"},
                {"149","Vista de la lista", "ES"},
                {"150","Cerrar sesión", "ES"},
                {"151","Gestión de contratistas, proveedores", "ES"},
                {"152","Creación de material", "ES"},
                {"153","Modificado", "ES"},
                {"154","Lunes", "ES"},
                {"155","Más", "ES"},
                {"156","Nombre", "ES"},
                {"157","Eventos de networking", "ES"},
                {"158","Contratación nueva: formación", "ES"},
                {"159","Nueva entrada de parte de horas", "ES"},
                {"160","Próximo", "ES"},
                {"161","No", "ES"},
                {"162","Oficina", "ES"},
                {"163","Gestión de oficinas", "ES"},
                {"164","Puesto oficial del trabajo", "ES"},
                {"165","Cálculo de OH y atributos", "ES"},
                {"166","La tarifa Opt solo se aplica si el estado inicial es Revisado.", "ES"},
                {"167","Opt Tarifa", "ES"},
                {"168","Organizar datos, hacer plantilla", "ES"},
                {"169","Otros proyectos / Varios", "ES"},
                {"170","Preparación de pérdidas y ganancias", "ES"},
                {"171","Comunicación con socios", "ES"},
                {"172","Problemas de pago", "ES"},
                {"173","Método de pago", "ES"},
                {"174","Desarrollo de las personas", "ES"},
                {"175","Gestión de personas", "ES"},
                {"176","Seguimiento de desempeño", "ES"},
                {"177","Soporte PH", "ES"},
                {"178","Número de teléfono", "ES"},
                {"179","Número de teléfono", "ES"},
                {"180","El número de teléfono no es correcto.", "ES"},
                {"181","Pitching", "ES"},
                {"182","Planificación de la carga de trabajo", "ES"},
                {"183","Por favor seleccione", "ES"},
                {"184","Publicar anuncio", "ES"},
                {"185","Idioma preferido", "ES"},
                {"186","Preparación para reuniones", "ES"},
                {"187","Preparar informes mensuales", "ES"},
                {"188","Preparar informes semanales", "ES"},
                {"189","Previos", "ES"},
                {"190","Solicitudes de precios", "ES"},
                {"191","Control de procesos, revisión", "ES"},
                {"192","La mejora de procesos", "ES"},
                {"193","Perfil", "ES"},
                {"194","Diseño de proyecto", "ES"},
                {"195","Revisión del proyecto con ops / PM", "ES"},
                {"196","Configuración del proyecto / Preparar pautas / Briefing", "ES"},
                {"197","Proporcionar formación", "ES"},
                {"198","PTO", "ES"},
                {"199","Control de calidad (edición de segunda línea)", "ES"},
                {"200","Recibiendo entrenamiento", "ES"},
                {"201","Reclutamiento", "ES"},
                {"202","Automatización de informes", "ES"},
                {"203","Informes / Seguimiento de estado / Seguimiento", "ES"},
                {"204","Restablecer la contraseña de Caspian", "ES"},
                {"205","Confirmación de ingresos", "ES"},
                {"206","Revisar el cuestionario / guía del comprador", "ES"},
                {"207","Retrabajo - Analista", "ES"},
                {"208","Retrabajo - Cliente", "ES"},
                {"209","Retrabajo - KAM", "ES"},
                {"210","Supervisor de RM", "ES"},
                {"211","Roles", "ES"},
                {"212","Rulez", "ES"},
                {"213","Transición de ventas a operaciones", "ES"},
                {"214","Sábado", "ES"},
                {"215","Ahorrar", "ES"},
                {"216","Guardar comentario", "ES"},
                {"217","Guardar tarifa", "ES"},
                {"218","Asignación", "ES"},
                {"219","Buscar", "ES"},
                {"220","Seleccione", "ES"},
                {"221","Seleccionar agencia", "ES"},
                {"222","Seleccionar tarea", "ES"},
                {"223","Autoasignado", "ES"},
                {"224","Soporte SG", "ES"},
                {"225","Medios de comunicación social", "ES"},
                {"226","Horas pasadas", "ES"},
                {"227","Comienzo", "ES"},
                {"228","Inicio fin", "ES"},
                {"229","Fecha de inicio:", "ES"},
                {"230","Hora de inicio:", "ES"},
                {"231","Domingo", "ES"},
                {"232","Nombre del supervisor", "ES"},
                {"233","Apoyo", "ES"},
                {"234","Surfmerchants", "ES"},
                {"235","Encuesta", "ES"},
                {"236","Cambiar a", "ES"},
                {"237","Tarea", "ES"},
                {"238","Tarea:", "ES"},
                {"239","El formato correcto es 'hh: mm'", "ES"},
                {"240","¡Este campo no puede estar vacío!", "ES"},
                {"241","Jueves", "ES"},
                {"242","Nivel", "ES"},
                {"243","Nivel 1", "ES"},
                {"244","Nivel 2", "ES"},
                {"245","Hoja de horas", "ES"},
                {"246","Nombre de Usuario de Timesheet Usuario ", "ES"},
                {"247","Hoy", "ES"},
                {"248","Manejo del rastreador", "ES"},
                {"249","Entrenamiento - Auto", "ES"},
                {"250","Capacitación: autónoma / miembro del equipo de coaching / externa", "ES"},
                {"251","Comprador de formación / información", "ES"},
                {"252","Miembro del equipo de formación / coaching / externo", "ES"},
                {"253","Traducción", "ES"},
                {"254","Traducción de directrices, otros documentos, etc.", "ES"},
                {"255","Martes", "ES"},
                {"256","Escriba aquí su comentario...", "ES"},
                {"257","Escribe para buscar…", "ES"},
                {"258","Apoyo de EE. UU.", "ES"},
                {"259","Utilice las teclas de flecha del teclado (arriba, abajo) para cambiar la selección. Las columnas se pueden cambiar de tamaño por las líneas oblicuas en el encabezado, las filas se pueden cambiar por las líneas oblicuas en la primera celda.", "ES"},
                {"260","ID de Usuario", "ES"},
                {"261","Nombre de usuario", "ES"},
                {"262","Tipo de usuario", "ES"},
                {"263","Usuario con Agencia", "ES"},
                {"264","Preparación y presentación de impuestos de IVA / GST", "ES"},
                {"265","Vendedor", "ES"},
                {"266","Tarifas de proveedores", "ES"},
                {"267","Id del proveedor", "ES"},
                {"268","Facturación de proveedores", "ES"},
                {"269","Nombre del vendedor", "ES"},
                {"270","Pagos a proveedores", "ES"},
                {"271","Wave", "ES"},
                {"272","Miércoles", "ES"},
                {"273","Días laborables", "ES"},
                {"274","Dirección de Western Union", "ES"},
                {"275","Toda la semana", "ES"},
                {"276","Sí", "ES"}
            });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
