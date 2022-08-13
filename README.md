# MusicApp

Aplicación que muestra un listado de canciones con la siguiente información: Titulo, Grupo, Año, Genero. La cual se podrá agregar, editar y eliminar.

# Indice

- [MusicApp](#musicapp)
- [WireFrame](#wireframe)
  - [Inicio](#inicio)
  - [Modal Agregar](#modal-agregar)
  - [Modal Editar](#modal-editar)
  - [Modal Eliminar](#modal-eliminar)
- [Mockups](#mockups)
  - [Mockups de navegador](#mockups-de-navegador)
    - [Inicio](#inicio-1)
    - [Modal Agregar](#modal-agregar-1)
    - [Modal Editar](#modal-editar-1)
    - [Modal Eliminar](#modal-eliminar-1)
  - [Mockups de celular](#mockups-de-celular)
    - [Inicio](#inicio-2)
    - [Navbar Desplegada](#navbar-desplegada)
    - [Modal Agregar](#modal-agregar-2)
    - [Modal Editar](#modal-editar-2)
    - [Modal Eliminar](#modal-eliminar-2)
- [Guía de uso](#guía-de-uso)
  - [Requerimientos](#requerimientos)
  - [Conexión a base de datos](#conexión-a-base-de-datos)

# WireFrame

Para la realización de esta aplicación se creó varios wireframes que tienen como objetivo ser un diseño primitivo en cual basarse a la hora de programar.
En caso de que las imagenes no se muestren correctamente puedes dar click en el siguiente enlace para ver un pdf con todos los mockups. --> [link a los mockups](https://drive.google.com/file/d/1oPp1BJl4PU_M8HDV-jSZUDSHQ181NJYs/view?usp=sharing) <--

## Inicio

El inicio contara con una navbar que contara con el logo de la aplicación, un botón para poder seguir agregando canciones y un cuadro de búsqueda para poder encontrar más fácil las canciones.

![Inicio](http://drive.google.com/uc?export=view&id=1_DW5za_SUPEE31BaB0JEzA2ggtrz6WCp)

## Modal Agregar

Este modal se abre al dar en el botón de agregar canción, una vez desplegada muestra 5 que se llenan de la siguiente forma:

1. El primer recuadro permite al usuario ingresar el link de una imagen que posteriormente se mostrar en las tarjetas que listan a las canciones agregadas, en caso de que el usuario desconozca como realizar esto, se mostrar un icono de información que le permite tener una mejor idea de cómo llenar este campo, si el campo no es llenado se colocara una imagen por default.
2. El segundo recuadro requiere del título de la canción, este recuadro debe ser llenado de manera obligatoria al igual que los recuadros siguientes.
3. El tercer recuadro se llena con el grupo de la canción.
4. El cuarto recuadro requiere el año de la canción.
5. El quinto recuadro se llena con el género de la canción.

![Modal para agregar canciones](http://drive.google.com/uc?export=view&id=1kpLXh8Ce6TB3MHmQ7ovCDVyMXDB2SsYU)

## Modal Editar

En este modal el usuario podrá editar cualquier canción listada que haya sido agregada con anterioridad, al igual que en el modal de agregar se mostraran 5 recuadros de texto que se llenaran de la misma manera, a diferencia del modal agregar aquí los recuadros se llenaran automáticamente con la información de la canción seleccionada, para que de esta manera el usuario solo modifique los datos que necesita.

![Modal para editar canciones](http://drive.google.com/uc?export=view&id=1Udo5BaQOoI3PaOCMGqYytAzp8CCYp-lV)

## Modal Eliminar

Por último se mostrara un modal de confirmación en el caso de que el usuario quiera eliminar una canción, este modal es para que el usuario no vaya a eliminar una canción por accidente y sea consciente de sus acciones.

![Modal para eliminar canciones](http://drive.google.com/uc?export=view&id=1MyMhUByCap85IfMy4GHQad8taKkQiRG7)

# Mockups

## Mockups de navegador

A continuacion se mostrara el diseño pre-codigo para tener una guía.

### Inicio

![Inicio](http://drive.google.com/uc?export=view&id=1n8Kxml3Wd40FtRP84zP42pdtJDQ3iUSR)

### Modal Agregar

![Modal para agregar canciones](http://drive.google.com/uc?export=view&id=1NtbUr5mp2NcVqwii8tq5kLRTQMrdmZBh)

### Modal Editar

![Modal para editar canciones](http://drive.google.com/uc?export=view&id=1w97Fi7YW0lqlim0IatDH-AmVwCot-cgj)

### Modal Eliminar

![Modal para eliminar canciones](http://drive.google.com/uc?export=view&id=1EEwIrJ5Pho8MON2K97kdVdMWPYsdXVgw)

## Mockups de celular

A continuacion se mostrara el diseño pre-codigo para tener una guía.

### Inicio

![Inicio](http://drive.google.com/uc?export=view&id=1GhHE22rXNK0vf5di-UDQqwnkL7AENDU-)

### Navbar Desplegada

![Navbar deslpegada en el inicio](http://drive.google.com/uc?export=view&id=1UXGdnMBswNQa18uIT7L9zKcLU-FEa3ZC)

### Modal Agregar

![Modal para agregar canciones](http://drive.google.com/uc?export=view&id=177g34GYq5aMvMVCfOfoCTMTMTWDEXeh7)

### Modal Editar

![Modal para editar canciones](http://drive.google.com/uc?export=view&id=1OBUMxKqaTv60v3SOPIRd-1Bp_Px-wtTZ)

### Modal Eliminar

![Modal para eliminar canciones](http://drive.google.com/uc?export=view&id=1TnBDjCfbU-IViXvjLcMSfBAVeielzM1g)

# Guía de uso
## Requerimientos
Estos son los programas que se requieren para poder ejecutar el programa de manera local

- SSMS 16 o superior
- Visual Studio 2019 o superior
- Asp.Net Core 6.x

## Conexión a base de datos
Primero debes ejecutar el query dentro de SSMS, una vez que lo hayas ejecutado con éxito tendrás que abrir la solución del proyecto y en el explorador de soluciones de visual studio buscar la carpeta Models y posteriormente dirigirse a MusicAppDBContext donde se debe buscar la linea que cuenta con el string de conexión donde se debe intercambiar por tu string de conexión. Al terminar podrás ejecutar la solución y modificarla a tu gusto.
