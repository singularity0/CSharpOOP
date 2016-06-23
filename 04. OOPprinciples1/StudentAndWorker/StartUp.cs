using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorker
{
    class StartUP
    {
        static void Main()
        {
            var workerPeyo = new Worker("Peyo", "Peev", 600, 8);
            var workerGincho = new Worker("Gincho", "Kostov", 500, 7);
            var workerVili = new Worker("Violeta", "Znaeva", 1600, 6);
            var workerPencho = new Worker("Penchoo", "Penev", 600, 6);
            var workerGalina = new Worker("Galina", "Vangova", 150, 8);
            var workerMaria = new Worker("Maria", "Miteva", 600, 18);
            var workerHrisi = new Worker("Hristina", "Komandareva", 600, 2);
            var workerStanka = new Worker("Stanka", "Kamenarova", 60, 1);
            var workerZdravko = new Worker("Zdravko", "Zhelqzkov", 100, 12);
            var workerSimo = new Worker("Smeone", "Frankofonchev", 150, 20);

            var workersSample = new List<Worker>() { workerPeyo, workerGincho, workerVili, workerPencho, workerGalina, workerMaria,
               workerHrisi,workerStanka, workerZdravko,workerSimo};

            var sortByMoneyPerHour = workersSample
                .OrderByDescending(x => x.MoneyEarnedPerHour())
                .Select(x => x.Firstname + " " + x.MoneyEarnedPerHour());
            Console.WriteLine("Workers Sorted by money Earned:");
            foreach (var item in sortByMoneyPerHour)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Students Sorted by Grade:");
            //creating some random students
            var studentPeyo = new Student("Peyo", "Peev", 3);
            var studentGincho = new Student("Gwincho", "Kostov",3);
            var studentVili = new Student("Vqioleta", "Anaeva", 2);
            var studentPencho = new Student("Penchoo", "APenev", 6);
            var studentGalina = new Student("Galina", "QWangova", 5);
            var studentMaria = new Student("Maria", "PMiteva", 5);
            var studentHrisis = new Student("AHristina", "zmandareva", 3);
            var studentStanka = new Student("EStanka", "Kamenarova", 6);
            var studentZdravko = new Student("AAZdravko", "Zhelqzkov", 4);
            var studentSimo = new Student("RTSmeone", "SFrankofonchev", 4);
            //adding all studetns to soem List
            var studentsList = new List<Student>() { studentPeyo, studentGincho, studentVili, studentPencho, studentGalina, studentMaria,
                studentHrisis ,studentStanka , studentZdravko, studentSimo };

            var sortedStudentsByGrade = studentsList.OrderBy(x => x.Grade).Select(x => x.Grade + " " + x.Firstname + " " + x.Lastname);
            foreach (var item in sortedStudentsByGrade)
            {
                Console.WriteLine(item);
            }

            var mergedLists = workersSample.Concat<Human>(studentsList)
                .OrderBy(x => x.Firstname)
               .ThenBy(x => x.Lastname);

            foreach (var item in mergedLists)
            {
                Console.WriteLine(item.Firstname + " " + item.Lastname);
            }




        }
    }
}
