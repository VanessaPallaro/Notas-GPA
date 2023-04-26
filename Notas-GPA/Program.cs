using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notas_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nome do estudante e os nomes dos cursos//
            string nomeEstudante = "Sophia";
            string curso1 = "Inglês";
            string curso2 = "Português";
            string curso3 = "Matemática";
            string curso4 = "Filosofia";
            string curso5 = "Geografia";

            //Horas que cada curso tem//
            int horasCurso1 = 4;
            int horasCurso2 = 3;
            int horasCurso3 = 3;
            int horasCurso4 = 3;
            int horasCurso5 = 4;

            //Nota que a estudante tirou//
            int notaA = 4;
            int notaB = 3;
            int horasCursada1 = notaB;
            int horasCursada2 = notaB;
            int horasCursada3 = notaA;
            int horasCursada4 = notaA;
            int horasCursada5 = notaB;

            //Valor total de horas dos cursos//
            int totalHoras = 0;
            totalHoras = horasCurso1 + horasCurso2 + horasCurso3 + horasCurso4 + horasCurso5;

            //Valor total de NOtas obtidas de cada cuso, calculadas através da multiplicação das horas com a nota obtida//
            int pontosGanhos = 0;
            pontosGanhos += horasCurso1 * horasCursada1;
            pontosGanhos += horasCurso2 * horasCursada2;
            pontosGanhos += horasCurso3 * horasCursada3;
            pontosGanhos += horasCurso4 * horasCursada4;
            pontosGanhos += horasCurso5 * horasCursada5;

            //calculando o GPA do estudante e mostrando somente os 3 primeiros digitos//
            decimal gpa = (decimal)pontosGanhos / totalHoras;
            double digito = (double)gpa;

            //Utilizando o método Math para deixar somente 2 digitos depois do ponto//
            Math.Round(digito, 2);


            
            Console.WriteLine($"Estudante: {nomeEstudante}\n");
            Console.WriteLine($"Curso\t\t Horas Necessárias\t Horas Cursadas");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($" {curso1}\t\t\t {horasCurso1}\t\t\t {horasCursada1}");
            Console.WriteLine($" {curso2}\t\t {horasCurso2}\t\t\t {horasCursada2}");
            Console.WriteLine($" {curso3}\t\t {horasCurso3}\t\t\t {horasCursada3}");
            Console.WriteLine($" {curso4}\t\t {horasCurso4}\t\t\t {horasCursada4}");
            Console.WriteLine($" {curso5}\t\t {horasCurso5}\t\t\t {horasCursada5}\n");
            Console.WriteLine($"Final GPA: \t\t" + Math.Round(digito, 2).ToString() + ".");


        }
    }
}
