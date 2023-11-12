﻿Console.WriteLine("... ... ...Horas Extras ... ... ...\n");

Console.WriteLine($"salario-hora {10:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(10, 300, 0):C}");
Console.WriteLine($"salario-hora {12:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(12, 300, 20):C}");

Console.WriteLine($"salario-hora {20:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(20, 300, 0):C}");
Console.WriteLine($"salario-hora {24:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(24, 300, 20):C}");


double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    //formula para calculo das horas
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);

}