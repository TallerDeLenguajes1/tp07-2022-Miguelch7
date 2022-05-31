List<Tarea> listadoTareas = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

var random = new Random();
string auxDescripcion;
int auxRealizada;

Console.Write("Ingrese la cantidad de tareas a realizar: ");
int cantidadTareas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < cantidadTareas; i++) {
    Console.Write("Ingrese la descripción de la tarea: ");
    auxDescripcion = Console.ReadLine()!;

    listadoTareas.Insert(i, new Tarea(i, auxDescripcion, (int) random.Next(1, 60)));
};

for (int i = 0; i < cantidadTareas; i++) {
    
    listadoTareas[i].mostrarTarea();
    
    Console.Write("Esta tarea fue realizada?: (1: si | 0: No)");
    auxRealizada = Convert.ToInt32(Console.ReadLine());
    
    if (auxRealizada == 1) {
        tareasRealizadas.Add(listadoTareas[i]);
    };
};

listadoTareas = listadoTareas.Except(tareasRealizadas).ToList();

Console.WriteLine("===== Tareas Realizadas =====");
foreach (Tarea tarea in tareasRealizadas) {
    tarea.mostrarTarea();
};

Console.WriteLine("===== Tareas Pendientes =====");
foreach (Tarea tarea in listadoTareas) {
    tarea.mostrarTarea();
};