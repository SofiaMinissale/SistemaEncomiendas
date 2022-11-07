# SistemaEncomiendas - PROTOTIPO. 
Se detallan a continuación las opciones válidas para reproducir el "camino feliz".


### INICIO DE SESIÓN

**- Numero de Cuit:** 20306578636768

**- Usuario:** NicolasMartinez

**- Contraseña:** usuario1

(Los datos corresponden al unico usuario habilitado para operar en el sistema)


### MENU PRINCIPAL

**- 1. Solicitar servicio	

	*-TIPO ENVIO
	1- Correspondencia
	2- Encomienda (aún no desarrollado. Siempre que sea encomienda se le pedirá 
	al usuario el peso de la misma para poder, de acuerdo al resto de las
	opciones, calcular la tarifa del servicio).
	
	*-PRIORIDAD ENVIO
	1- Normal
	2- Urgente (aún no desarrollado. Afectará al incremento de la tarifa por ser 
	un servicio adicional) 

	DATOS ORIGEN:
	
	*-ORIGEN ENVIO
	1- Sucursal (se da por supuesto que existe una sucursal por localidad con su
	identificador, direccion y altura almacenados en archivo de texto)
	2- Domicilio (aún no desarrollado. Siempre que el usuario seleccione domicilio
	tanto para origen como para destino, el sistema pedirá el ingreso de la 
	dirección y altura)

	*-SELECCION PROVINCIA (listado de provincias argentinas)
	1- Buenos Aires
	...

	*-LOCALIDAD (abrá 10 localidad asignadas a cada una de las provincias)
	1- Martinez
	...
	
	DATOS DESTINO:
	
	*-TIPO ENVIO
	1- Nacional
	2- Internacional (aún no desarrollado. Siempre que el usuario seleccione destino
	internacional el sistema le solicita ingresar pais, validando el ingreso contra
	archivo de texto con paises y determinando la región a la cual aplica para
	poder calcular la tarifa del servicio. El sistema siempre adiciona un costo fijo
	equivalente a un envio a CABA por regla de negocio.
	Paso siguiente, el usuario ingresa los datos de localidad y domicilio)

	*-DESTINO ENVIO
	1- Sucursal (se da por supuesto que existe una sucursal por localidad con su
	identificador, direccion y altura almacenados en archivo de texto)
	2- Domicilio (aún no desarrollado. Siempre que el usuario seleccione domicilio
	tanto para origen como para destino, el sistema pedirá el ingreso de la 
	dirección y altura)

	*-SELECCION PROVINCIA (listado de provincias argentinas)
	1- Buenos Aires
	...

	*-SELECCION LOCALIDAD
	1- Bahia Blanca


	DATOS DESTINATARIO:

	*-NOMBRE DESTINATARIO: campo libre alfabetico
	*-APELLIDO DESTINATARIO: campo libre alfabetico
	*-DNI: admite 8 dígitos 
	
	El sistema muestra resumen de la solicitud y le pide al usuario:
	1- Confirmar (el sistema almacena los datos de solicitud en archivo de texto
	y genera un Numero de Orden. Paso siguiente se confirma la solicitud y se 
	muestra el Numero de Orden asignado --> 30541).
	2- Rechazar (se retorna al menú principal)
	
	

**- 2. Consultar estado de servicio
	
	"Ingrese el número de orden de servicio que desea consultar": 30541
	
	El sistema muestra el estado de servicio con los siguientes datos:
	- Fecha de solicitud 
	- Numero de orden de servicio (30541)
	- Estado de servicio ("En centro de distribucion" definido para prototipo)
	- Nombre y apellido del receptor
	- Destino (se encuentra hardcodeado al momento para los fines del prototipo)
	
**- 3. Consultar estado de cuenta

	El sistema muestra el resumen de cuenta con los siguientes datos:

	- Fecha de solicitud)
	- Numero orden de servicio
	- Importe
	- Estado del pago (A PAGAR solo definido para el prototipo)
	- Total envios pendientes de facturación (sumatoria de solicitudes pendientes)
	- Total envios impagos (sumatoria de solicitudes impagas)
	- Total envios pagos (sumatoria de solicitudes pagas)
	

**- 4. Cerrar sesion
	
	Se notifica el cierre de sesión y se pide presionar una tecla para continuar. El sistema vuelve al inicio de sesión.
	

**- 5. Salir del programa

	Se notifica la salida al usuario y se pide presionar una tecla para cerrar la consola.

	
-----------------------------------------------------

