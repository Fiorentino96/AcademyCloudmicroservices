// sono dentro al metodo main e posso scrivere solo il metodo main 
// vedi file di testo programcsLegacy.txt

Shapes.IRettangolo r = new Shapes.Quadrato(); 

//r può assumere il valore di qualsiasi istanza che implementa l'interfaccia IRettangolo

r.Base = 3.5f;
//ora il lato è r.Lato =3.5f;
r.Altezza = 2.0f;
//ora il r.Lato =2.0f;

Console.WriteLine("L' area è:");
Console.WriteLine(r.Area);
Console.WriteLine("Il perimetro è:");
Console.WriteLine(r.Perimetro);