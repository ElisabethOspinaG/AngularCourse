export class Respuesta{
  id?: number; // se pone ? porque es opcional
  descripcion: string;
  esCorrecta: boolean;

  constructor(descripcion: string, esCorrecta: boolean, id?: number){
    this.id = id;
    this.descripcion = descripcion;
    this.esCorrecta = esCorrecta;
  }
}
