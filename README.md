# Simulador zonal de Vigo

Simulador automático de 1 millón de temporadas para comprobar las posibilidades de ascenso de cada equipo.

## Índice

* [Cómo ejecutar el programa](#cómo-ejecutar-el-programa)
* [Cómo se simulan los partidos](#cómo-se-simulan-los-partidos)
* [Cómo se simula una temporada](#cómo-se-simula-una-temporada)

## Cómo ejecutar el programa

En línea de comandos ejecutar:

```dotnet run```

En un AMD Ryzen 5 7600X 6-Core Processor usando el PC de forma normal tarda unos 20 segundos.

En Program.cs se puede modificar fácilmente el número de hilos y de simulaciones por hilo.

## Cómo se simulan los partidos

Para los partidos que se vayan a jugar se hace un resultado pronóstico en base a las medias de los equipos que se enfrentan.

Ejemplo: Si equipo A tiene un promedio de 60-50 (puntos anotados y recibidos por partido) y se enfrenta a equipo B con 55-55 el resultado pronóstico es:

Equipo A anota 60 y Equipo B recibe 55 = La media de las dos 57.5

Equipo B anota 55 y Equipo A recibe 50 = La media de las dos 52.5

Con el resultado pronóstico a cada equipo se el aplica de forma aleatoria un número de -6 a +6 (los locales +7). Ese es el resultado del partido.

- En caso de prórroga se vuelve a aplicar un número aleatorio de 0 a +9 para visitantes y 0 a +10 para locales.

## Cómo se simula una temporada

Para simular una temporada se simulan todos los partidos pendientes siguiendo el método anterior.