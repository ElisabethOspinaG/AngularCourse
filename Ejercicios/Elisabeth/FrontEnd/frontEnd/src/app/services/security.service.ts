import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../models/usuario';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {

  constructor(private htpp: HttpClient) { };

  // LogIn(loginInfo: Usuario ): Observable<boolean>{
  //   appURL: String = "https://localhost:7039/api/"
  //   controllerURL: string = "";
  //   return this.http.get<boolean>("https://localhost:7039/api/Login/acceseAcount?user=${loginInfo.nombreUsuario}&password=${loginInfo.password}");
  // }
}
