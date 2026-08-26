# Pseudokode

## Programflyt

1. Start programmet.
2. ASP.NET Core starter webapplikasjonen.
3. DataController opprettes.
4. CsvReader leser dataset.csv med File.ReadAllLines().
5. Headerlinjen hoppes over.
6. Hver resterende linje deles opp med Split().
7. Verdiene konverteres til riktige datatyper.
8. Hver linje mappes til et DataRow-objekt.
9. Objektene lagres i en liste.
10. Controlleren bruker LINQ til å spørre mot listen.
11. Resultatet returneres som HTTP-respons.

## Select

Hent alle DataRow-objekter.

For hvert objekt:

- Hent Species-property.

Returner alle Species.

## Where

Hent alle DataRow-objekter.

Filtrer objektene der PetalLengthCm er større enn 5.

Returner resultatet.

## OrderBy

Hent alle DataRow-objekter.

Sorter objektene etter SepalLengthCm.

Returner resultatet.

## Flytskisse

```text
        START
          |
          v
   ASP.NET Core starter
          |
          v
     DataController
          |
          v
       CsvReader
          |
          v
   File.ReadAllLines()
          |
          v
     Hopp over header
          |
          v
       Split(",")
          |
          v
    Map til DataRow
          |
          v
     List<DataRow>
          |
          v
     LINQ-spørring
       /   |   \
      /    |    \
 Select  Where  OrderBy
      \    |    /
       \   |   /
          v
      HTTP-respons
          |
          v
         SLUTT
```
