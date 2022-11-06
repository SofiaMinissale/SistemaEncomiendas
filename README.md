# SistemaEncomiendas - PROTOTIPO. 
Se detallan a continuación las opciones válidas para reproducir el "camino feliz".


### INICIO DE SESIÓN

**- Numero de Cuit:** 20306578636768

**- Usuario:** NicolasMartinez

**- Contraseña:** usuario1

(Los datos corresponden al unico usuario habilitado para operar en el sistema)


### MENU PRINCIPAL

**- 1. Solicitar servicio
	
	*- DATOS DE ORIGEN	
	"Ingrese peso del paquete (KG)": validado >= 0 & <=30 (decimal separado con ",")
	"Seleccione la prioridad del envío": 1-Normal
	"Seleccione el tipo de envío": 1-Nacional
	"Seleccione si el origen del envío es una sucursal o domicilio particular": 1-Domicilio 
	"Seleccione region de origen": 2-Metropolitana
	"Seleccione provincia de origen": 1-Buenos Aires
	"Seleccione sucursal de origen": 1-Martinez
	"Ingrese domicilio de origen": NO debe ser vacío

	*- DATOS DE DESTINO
	"Seleccione el tipo de envío": 1-Nacional
	"Seleccione si el destino del envío es una sucursal o domicilio particular": 1-Domicilio
	"Seleccione region de destino": 2-Metropolitana
	"Seleccione provincia de destino": 2-Cordoba
	"Seleccione localidad destino": 1-Cosquin

	*- DATOS DEL DESTINATARIO
	"Ingrese domicilio del destino": falta subdividir al docmicilio en "Dirección" (alfabetico) y "Altura" (numerico).
	"Ingrese nombre del destinatario": se valida campo alfabetico ok.
	"Ingrese apellido del destinatario": se valida campo alfabetico ok.
	"Ingrese DNI": se valida que sea numerico y de 8 digitos ok.

**- 2. Consultar estado de servicio
	
	"Ingrese el número de orden de servicio que desea consultar": 30541
	"¿Desea consultar otra orden de servicio?": esta opción no fue desarrollada ya que carece de sentido la funcionalidad tratandose unicamente de una orden de servicio en este prototipo.
	
**- 3. Consultar estado de cuenta

	Se visualiza resumen de cuenta con los siguientes datos:
	*- "Resumen a la fecha" (fecha actual de la consulta)
	*- "Monto total" (definido por 1 solicitud a realizar o ya realizada)
	*- "Estado" (A PAGAR solo definida para el prototipo)

**- 4. Cerrar sesion
	
	Se notifica el cierre de sesión y se pide presionar una tecla para continuar. El sistema vuelve al inicio de sesión.
	

**- 5. Salir del programa

	Se notifica la salida al usuario y se pide presionar una tecla para cerrar la consola.

	
-----------------------------------------------------

