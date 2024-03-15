import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { CuestionarioService } from '../../../../../services/cuestionario.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-paso-uno',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './paso-uno.component.html',
  styleUrl: './paso-uno.component.css'
})
export class PasoUnoComponent {
  datosCuestionario: FormGroup;

  constructor( private fb: FormBuilder,
    private router: Router,
    private cuestionarioService: CuestionarioService
    ){
      this.datosCuestionario = this.fb.group({
        titulo: ['', Validators.required],
        descripcion: ['', Validators.required]
      });
  }

  PasoUno(): void {
    this.cuestionarioService.tituloCuestionario = this.datosCuestionario.value.titulo;
    this.cuestionarioService.descripcionCuestionario = this.datosCuestionario.value.descripcion;
    this.router.navigate(['/dashboard/nuevoCuestionario/pasoDos']);
  }

}
