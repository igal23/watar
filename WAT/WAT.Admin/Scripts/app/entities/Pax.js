function Pax() {
    this.paxId = null;
    this.apellido = '';
    this.nombre = '';
    this.email = '';
    this.telefono = '';
    this.fechaNacimiento = '';
    this.ciudad = new Item(0, 'Otro');
    this.universidad = new Item(0, 'Otro');
    this.aceptaTerminos = true;

    this.getDescripcion = function () {
        return this.apellido + ', ' + this.nombre;
    };
}

function Item(id, descripcion){
    this.id = id;
    this.descripcion = descripcion;
}