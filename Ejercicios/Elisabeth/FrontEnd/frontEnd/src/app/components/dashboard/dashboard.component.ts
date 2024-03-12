import { Component } from '@angular/core';
import { CuestionariosComponent } from './cuestionarios/cuestionarios.component';
import { RouterLink, RouterOutlet } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { NavbarProductsComponent } from './forms/products/navbar-products/navbar-products.component';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [NavbarComponent, RouterOutlet, RouterLink, NavbarProductsComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {

}
