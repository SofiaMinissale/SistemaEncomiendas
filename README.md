# SistemaEncomiendas

### DATOS USUARIO DE PRUEBA:

**- Numero de Cuit:** 20306578636768

**- Usuario:** NicolasMartinez

**- Contraseña:** usuario1

Los datos corresponden al unico usuario habilitado para operar en el sistema


### MENU PRINCIPAL

**- 1. Solicitar servicio
	
*- DATOS DE ORIGEN	
	"Ingrese peso del paquete (KG)": validado >= 0 & <=30
	"Seleccione la prioridad del envío": 1-Normal
	"Seleccione region de origen": 2-Metropolitana
	"Seleccione provincia de origen": 1-Buenos Aires

*- DATOS DE DESTINO
	"Seleccione region de destino": 2-Metropolitana
	"Seleccione provincia de destino": 1-Cordoba

*- DIRECCION
	"Ingrese dirección de destino": falta validar dirección (alfabetico) y altura (numerico).

	"Ingrese nombre del destinatario": se valida campo alfabetico ok.
	"Ingrese apellido del destinatario": se valida campo alfabetico ok.
	"Ingrese DNI": se valida que sea numerico y de 8 digitos ok.
	

	




------------------------------
* Inicio de sesión -> al ingresar los datos erroneos pondría el mensaje de error en la misma pantalla y color rojo, sin clean.

* Solicitud de servicio - Datos de origen -> al pone 3 (norte) me volvio a mostrar la misma pantalla con el mismo titulo "Sol. ser - datos de origen". Se repite con otras convinaciones.

* Solicitud de servicio - Prioridad -> cuando se marca la opción aun no desarrollada y luego se marca la correcta el sistema vuelve al mismo submenú de prioridad.


* Consultar estado de cuenta -> el paque del peso, origen y destino están vacíos. Solo se mantiene el monto total hardcodeado.



