
int num, resultado = 0;

Console.WriteLine("Ingrese el valor deseado");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El resultado del valor ingresado " + num + " es:");

for (int i=1; i<=12; i++){
    resultado = num * i;
    Console.WriteLine(num + "*"+ i + "="+ resultado);
}

Console.Read();