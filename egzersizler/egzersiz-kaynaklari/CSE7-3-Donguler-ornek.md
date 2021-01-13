CSE7-3 Donguler egzersizi
Asagida ornegi verilmis tum ucgenleri ciziniz;

Bu orneklerde kullanilan sembol 'f' ve satir sayisi 5'tir.

1)Sola dayanmis dik ucgen
```
f
f f
f f f
f f f f
f f f f f
```

2)Saga dayanmis dik ucgen
```
        f
      f f
    f f f
  f f f f
f f f f f
```

3)Yukari ikizkenar ucgen
```
        f
      f f f
    f f f f f
  f f f f f f f
f f f f f f f f f
```

4)Asagi ikizkenar ucgen
```
f f f f f f f f f
  f f f f f f f
    f f f f f
      f f f
        f
```

5)Sola dayanmis ikizkenar ucgen
```
f
f f
f f f
f f
f
```


6)Saga dayanmis ikizkenar ucgen
```
    f
  f f
f f f
  f f
    f
```

7)45 derece dondurulmus kare
```
    f
  f f f
f f f f f
  f f f
    f
```

```cs
string symbol = "f";
int count = 5;

//i satir sayisi
for (int i = 1; i <= count; i++)
{
    //s ve j kolon sayisinin toplamini vermeli
    //cunku s ve j nin kullanildigi dongulerin amaci
    //aslinda kolonlari yazdirmak

    //s bosluk sayisi
    for (int s = 0; s < count-i; s++)
    {
      //create new string that represent space based on user input length for
      //multiple character inputs
        Console.Write(new string(' ', symbol.Length + 1));
    }

    //j kolon sayisi
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" " + symbol);
    }

    Console.WriteLine();
}

Console.ReadKey();
```
