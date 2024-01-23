import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { InicioComponent } from './components/inicio/inicio.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, InicioComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  listEstudiantes: any[] = [
    { nombre: "Tomas Gonzalez", estado: "Promocionado" },
    { nombre: "Lucas Perez", estado: "Regular" },
    { nombre: "Patricia Funez", estado: "Libre" },
    { nombre: "Juan Garcia", estado: "Regular" },
    { nombre: "Marta Perez", estado: "Promocionado" },
    { nombre: "Nicolas Gomez", estado: "Libre" },

  ]
  mostrar = true;

  toggle(): void {
    this.mostrar = !this.mostrar;
  }
}
