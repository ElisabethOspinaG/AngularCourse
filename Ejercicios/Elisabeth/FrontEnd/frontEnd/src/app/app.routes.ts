import { Routes } from '@angular/router';
import { BienvenidaComponent } from './components/inicio/bienvenida/bienvenida.component';
import { LoginComponent } from './components/inicio/login/login.component';
import { RegisterComponent } from './components/inicio/register/register.component';

export const routes: Routes = [
  { path: '', redirectTo: '/bienvenidos', pathMatch: 'full'},
  { path: 'bienvenidos', component: BienvenidaComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: '**', redirectTo: '/bienvenidos', pathMatch: 'full'},
];
