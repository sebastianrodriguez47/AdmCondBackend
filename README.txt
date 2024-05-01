#Hola, bienvenido a mi proyecto

1.- Primero que todo dentro de la raiz de este proyecto cree una carpeta llamada
"ArchivosRevision" en ella está el diagrama de clases, otro llamado "Pruebas",
y un archivo sql llamado "Query Prueba Base 2", el contiene todas las querys de 
sql server para crear la base datos y tablas del proyecto. Deberás ejecutarlo en 
sql management studio.

2.- Una vez creada la base de datos, debemos irnos al proyecto de Backend y ajustar
el conection string con los valores de tu servidor, e iniciamos el el proyecto.

3.-Nos vamos al front, primero que todo ejecutamos el comando "npm instal react-scripts", 
para traernos todas las librerias y luego colocamos el comando "npm start" para que se despliegue
la interfaz de usuario. Dentro de la interfaz de usuario tenemos un listado de casas,
las cuales se pueden filtrar a través de la lupa, en este caso, las casas 89 y 105,
tienen jefes de hogar registrados, las demas casas no, de esta manera, si buscamos 
las casas mencionadas anteriormente, y apretamos la fila donde se encuentra, se abrirá
un modal, el cual mostrará el detalle de los jefes de hogar asignados.
