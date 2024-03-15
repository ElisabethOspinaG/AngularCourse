import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environments';
import { Cuestionario } from '../models/custionario';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CuestionarioService {

    myAppUrl: string;
    myApiUrl: string;
    tituloCuestionario: string;
    descripcionCuestionario: string;

  constructor(private http: HttpClient) {
    this.myAppUrl = environment.endpoint;
    this.myApiUrl = '/api/cuestionario';
    this.tituloCuestionario = "";
    this.descripcionCuestionario = "";
  }

  guardarCuestionario(cuestionario: Cuestionario): Observable<any>{
    return this.http.post(this.myAppUrl + this.myApiUrl, cuestionario);
  }
}
