import { Routes } from '@angular/router';
import { BienvenidaComponent } from './components/inicio/bienvenida/bienvenida.component';
import { LoginComponent } from './components/inicio/login/login.component';
import { RegisterComponent } from './components/inicio/register/register.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { CuestionariosComponent } from './components/dashboard/cuestionarios/cuestionarios.component';
import { CambiarPasswordComponent } from './components/dashboard/cambiar-password/cambiar-password.component';
import { ListProductsComponent } from './components/dashboard/forms/products/list-products/list-products/list-products.component';
import { AddEditProductsComponent } from './components/dashboard/forms/products/add-edit-products/add-edit-products.component';
import { NuevoCuestionarioComponent } from './components/dashboard/cuestionarios/nuevo-cuestionario/nuevo-cuestionario.component';
import { PasoUnoComponent } from './components/dashboard/cuestionarios/nuevo-cuestionario/paso-uno/paso-uno.component';
import { PasoDosComponent } from './components/dashboard/cuestionarios/nuevo-cuestionario/paso-dos/paso-dos.component';


export const routes: Routes = [
  { path: '', redirectTo: '/inicio', pathMatch: 'full' },
  { path: 'inicio', component: InicioComponent, children: [
    { path: '', component: BienvenidaComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'login', component: LoginComponent },
  ]},
  {path: 'dashboard', component: DashboardComponent, children: [
    { path: '', component: ListProductsComponent },
    { path: 'add', component: AddEditProductsComponent},
    { path: 'edit/:id', component: AddEditProductsComponent },
    { path: 'cuestionarios', component: CuestionariosComponent },
    { path: 'cambiarPassword', component: CambiarPasswordComponent },
    { path: 'nuevoCuestionario', component: NuevoCuestionarioComponent, children: [
      {path: 'pasoUno', component: PasoUnoComponent},
      {path: 'pasoDos', component: PasoDosComponent}
    ]}
  ]},
  { path: '**', redirectTo: '/inicio', pathMatch: 'full'},
];
