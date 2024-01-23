import { Component } from '@angular/core';
import { BienvenidaComponent } from './bienvenida/bienvenida.component';

@Component({
  selector: 'app-inicio',
  standalone: true,
  imports: [BienvenidaComponent],
  templateUrl: './inicio.component.html',
  styleUrl: './inicio.component.css'
})
export class InicioComponent {

}
