class Tarea {
    private int ID;
    private string Descripcion;
    private int Duracion;

    public Tarea(int id, string descripcion, int duracion) {
        ID = id;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public void mostrarTarea() {
        Console.WriteLine($"----- Tarea { ID } -----");
        Console.WriteLine("Descripcion: " + Descripcion);
        Console.WriteLine("Duracion: " + Duracion);
    }
}