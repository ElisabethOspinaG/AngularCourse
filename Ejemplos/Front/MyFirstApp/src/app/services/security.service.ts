import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {

  constructor(private http: HttpClient) { }

  LogIn(loginInfo: User): Observable<boolean>{
    return this.http.get<boolean>(`https://localhost:7182/api/Login/Login?username=${loginInfo.email}&password=${loginInfo.password}`);    
  }
}
