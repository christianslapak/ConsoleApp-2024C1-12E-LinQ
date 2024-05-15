namespace ConsoleApp_2024C1_12E_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            Estudiante[] misEstudantes =
            {
                new Estudiante() {Id = 1, Nombre = "Alejandra", Edad = 18 },
                new Estudiante() {Id = 2, Nombre = "Mario", Edad = 19 },
                new Estudiante() {Id = 3, Nombre = "Ayelen", Edad = 23 },
                new Estudiante() {Id = 4, Nombre = "Cecilia", Edad = 29 },
                new Estudiante() {Id = 5, Nombre = "Miguel", Edad = 32 },
                new Estudiante() {Id = 6, Nombre = "Federico", Edad = 14 },
                new Estudiante() {Id = 7, Nombre = "Gabriela", Edad = 31 },
                new Estudiante() {Id = 8, Nombre = "Nicolas", Edad = 26 },
            };

            Console.WriteLine("Salida con if");
            Estudiante[] miRetorno = new Estudiante[8];
            int i = 0;
            foreach (var elemEstudiante in misEstudantes)
            {
                if (elemEstudiante.Edad >= 13 && elemEstudiante.Edad <= 18)
                {
                    miRetorno[i] = elemEstudiante;
                    i++;
                }
            }
            for (int x = 0; x < i; x++)
            {
                Console.WriteLine("Nombre " + miRetorno[x].Nombre + " " + miRetorno[x].Edad);
            }

            Console.WriteLine("LinQ - Expresion de Consulta");
            var consultaQE = from estu in misEstudantes where estu.Edad >=13 && estu.Edad <= 18 select estu;
            foreach (var itemEstdiante in consultaQE)
            {
                Console.WriteLine("Nombre " + itemEstdiante.Nombre + " " + itemEstdiante.Edad);
            }

            Console.WriteLine("LinQ - Expresion Lambda");
            var consultaLE = misEstudantes.Where(estu => estu.Edad >=13 && estu.Edad<=18);
            foreach (var itemEstdiante in consultaLE)
            {
                Console.WriteLine("Nombre " + itemEstdiante.Nombre + " " + itemEstdiante.Edad);
            }

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
