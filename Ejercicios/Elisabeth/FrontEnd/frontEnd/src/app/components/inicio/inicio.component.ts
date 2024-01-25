import { Component } from '@angular/core';
import { BienvenidaComponent } from './bienvenida/bienvenida.component';
import { RouterOutlet, RouterLink } from '@angular/router';

@Component({
  selector: 'app-inicio',
  standalone: true,
  imports: [BienvenidaComponent, RouterOutlet, RouterLink],
  templateUrl: './inicio.component.html',
  styleUrl: './inicio.component.css'
})
export class InicioComponent {

}
