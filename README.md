# Simulador zonal de Vigo

Simulador automático de 1 millón de temporadas para comprobar las posibilidades de ascenso de cada equipo.

## Índice

* [Cómo ejecutar el programa](#cómo-ejecutar-el-programa)
* [Cómo se simulan los partidos](#cómo-se-simulan-los-partidos)
* [Cómo se simula una temporada](#cómo-se-simula-una-temporada)
* [Seguimiento de resultados](#seguimiento-de-resultados)

## Cómo ejecutar el programa

En línea de comandos ejecutar:

```
dotnet run
```

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

## Seguimiento de resultados

Aquí voy añadiendo jornada a jornada los resultados parciales obtenidos por el simulador.

### Índice

* [Postjornada 22](#postjornada-22)
* [Postjornada 23](#postjornada-23)
* [Postjornada 24](#postjornada-24)

### Postjornada 22

Después de 1000002 simulaciones

1. Novobasket clasifica el 99,73% de las veces
2. Redeiras clasifica el 43,22% de las veces
3. Nigrán clasifica el 28,19% de las veces
4. PBB clasifica el 18,34% de las veces
5. Illas Cíes clasifica el 7,69% de las veces
6. Puerto Vigo clasifica el 2,31% de las veces
7. Mar de Vigo clasifica el 0,32% de las veces
8. Caselas clasifica el 0,20% de las veces
9. Condado clasifica el 0,00% de las veces

> [!NOTE]
>
> Partidos aplazados:
>
> * Nigrán - Redeiras | Jornada 15
> * Puerto Vigo - Redeiras | Jornada 20

### Postjornada 23

Después de 1000002 simulaciones

1. Novobasket clasifica el 97,64% de las veces (-2,1%)
2. Redeiras clasifica el 46,23% de las veces (+3%)
3. Nigrán clasifica el 39,86% de las veces (+11,6%)
4. Illas Cíes clasifica el 11,98% de las veces (+4,4%)
5. Puerto Vigo clasifica el 3,40% de las veces (+1,1%)
6. PBB clasifica el 0,49% de las veces (-17,9%)
7. Caselas clasifica el 0,36% de las veces (+0,16%)
8. Mar de Vigo clasifica el 0,04% de las veces (-0,28%)

> [!NOTE]
>
> Partidos aplazados:
>
> * Nigrán - Redeiras | Jornada 15
> * Puerto Vigo - Redeiras | Jornada 20
> * Mos - Rodaballo | Jornada 23

### Postjornada 24

Después de 1000002 simulaciones

1. Novobasket clasifica el 96,43% de las veces (-1,2%)
2. Nigrán clasifica el 54,12% de las veces (+14,12%)
3. Redeiras clasifica el 40,84% de las veces (-5,5%)
4. Illas Cíes clasifica el 8,56% de las veces (-3,5%)
5. PBB clasifica el 0,04% de las veces (-0,45%)
6. Mar de Vigo clasifica el 0,00% de las veces (-0,04%)
7. Puerto Vigo clasifica el 0,00% de las veces (-3,40%)

> [!NOTE]
>
> Partidos aplazados:
>
> * Nigrán - Redeiras | Jornada 15
> * Puerto Vigo - Redeiras | Jornada 20
> * Mos - Rodaballo | Jornada 23
> * Apostol - Novobasket | Jornada 24
